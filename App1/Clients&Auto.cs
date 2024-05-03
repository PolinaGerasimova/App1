using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Clients_Auto : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        string title = "AutoCar";
        public Clients_Auto()
        {
            InitializeComponent();
            loadClients();
            loadAuto();
            loadClientsAuto();
        }

        #region ClietsAddAuto
        private void txtSeachClient_TextChanged(object sender, EventArgs e)
        {
            loadClients();
        }
        private void loadClients()
        {
            try
            {
                clbClients.Items.Clear();
                string searchQuery = txtSeachClient.Text;
                string query = $"SELECT id_client, name FROM clients WHERE name LIKE '%{searchQuery}%'";
                cmd = new MySqlCommand(query, con.connect_());
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["name"].ToString();
                    int id = Convert.ToInt32(reader["id_client"]);
                    clbClients.Items.Add(new KeyValuePair<int, string>(id, name));
                    clbClients.DisplayMember = "Value";
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void txtSearchAuto_TextChanged(object sender, EventArgs e)
        {
            loadAuto();
        }
        private void loadAuto()
        {
            try
            {
                clbAuto.Items.Clear();
                string searchQuery = txtSearchAuto.Text;
                string query = $"SELECT id_auto, goss_number FROM auto WHERE goss_number LIKE '%{searchQuery}%'";
                cmd = new MySqlCommand(query, con.connect_());
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string gossNumber = reader["goss_number"].ToString();
                    int id = Convert.ToInt32(reader["id_auto"]);
                    clbAuto.Items.Add(new KeyValuePair<int, string>(id, gossNumber));
                    clbAuto.DisplayMember = "Value";
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите привязать автомобиль к клиенту?", "Связывание автомобиля с клиентом", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    con.open();
                    foreach (object selectedClient in clbClients.CheckedItems)
                    {
                        KeyValuePair<int, string> clientPair = (KeyValuePair<int, string>)selectedClient;
                        int clientId = clientPair.Key;
                        foreach (object selectedAuto in clbAuto.CheckedItems)
                        {
                            KeyValuePair<int, string> autoPair = (KeyValuePair<int, string>)selectedAuto;
                            int autoId = autoPair.Key;

                            MySqlCommand getBrandCmd = new MySqlCommand("SELECT brand FROM auto WHERE id_auto = @autoId", con.connect_());
                            getBrandCmd.Parameters.AddWithValue("@autoId", autoId);
                            object brandResult = getBrandCmd.ExecuteScalar();
                            if (brandResult == null)
                            {
                                throw new Exception("Brand для указанного auto_id не найден.");
                            }

                            string insertQuery = "INSERT INTO clients_has_auto (clients_id, auto_id, brand) VALUES (@clients_id, @auto_id, @brand)";
                            cmd = new MySqlCommand(insertQuery, con.connect_());
                            cmd.Parameters.AddWithValue("@clients_id", clientId);
                            cmd.Parameters.AddWithValue("@auto_id", autoId);
                            cmd.Parameters.AddWithValue("@brand", brandResult);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    loadClientsAuto();
                    MessageBox.Show("Изменения сохранены", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
                finally
                {
                    con.close();
                }
                for (int i = 0; i < clbClients.Items.Count; i++)
                {
                    clbClients.SetItemChecked(i, false);
                }
                for (int i = 0; i < clbAuto.Items.Count; i++)
                {
                    clbAuto.SetItemChecked(i, false);
                }
            }
        }
        #endregion ClietsAddAuto  

        #region ClientsWithAuto
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadClientsAuto();
        }

        private void dgwClientsAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgwClientsAuto.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Вы уверены, что хотите удалить это связывание?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        string clientName = dgwClientsAuto.Rows[e.RowIndex].Cells["name"].Value.ToString();
                        string autoGosNumber = dgwClientsAuto.Rows[e.RowIndex].Cells["goss_number"].Value.ToString();

                        string getClientIdQuery = "SELECT id_client FROM clients WHERE name = @clientName";
                        string getAutoIdQuery = "SELECT id_auto FROM auto WHERE goss_number = @autoGosNumber";
                        string deleteQuery = "DELETE FROM clients_has_auto WHERE clients_id = @clientId AND auto_id = @autoId";

                        con.open();
                        MySqlCommand getClientIdCmd = new MySqlCommand(getClientIdQuery, con.connect_());
                        getClientIdCmd.Parameters.AddWithValue("@clientName", clientName);
                        object clientIdResult = getClientIdCmd.ExecuteScalar();

                        MySqlCommand getAutoIdCmd = new MySqlCommand(getAutoIdQuery, con.connect_());
                        getAutoIdCmd.Parameters.AddWithValue("@autoGosNumber", autoGosNumber);
                        object autoIdResult = getAutoIdCmd.ExecuteScalar();

                        if (clientIdResult != null && autoIdResult != null)
                        {
                            MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con.connect_());
                            deleteCmd.Parameters.AddWithValue("@clientId", clientIdResult);
                            deleteCmd.Parameters.AddWithValue("@autoId", autoIdResult);
                            deleteCmd.ExecuteNonQuery();
                            MessageBox.Show("Связь успешно удалена.", "Успех", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        con.close();
                        loadClientsAuto();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка при удалении связи: " + ex.Message,
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.close();
                    }
                }
            }
        }

        public void loadClientsAuto()
        {
            try
            {
                dgwClientsAuto.Rows.Clear();
                string query = @"
                               SELECT c.name, a.goss_number, b.brand_name 
                               FROM clients_has_auto cha 
                               JOIN clients c ON cha.clients_id = c.id_client
                               JOIN auto a ON cha.auto_id = a.id_auto
                               JOIN brand b ON a.brand = b.brand_id
                               WHERE CONCAT(c.name, ' ', a.goss_number, ' ', b.brand_name)
                               LIKE @searchTerm";
                cmd = new MySqlCommand(query, con.connect_());
                cmd.Parameters.AddWithValue("@searchTerm", "%" + txtSearch.Text + "%");

                con.open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string clientName = reader["name"].ToString();
                    string autoGosNumber = reader["goss_number"].ToString();
                    string brandName = reader["brand_name"].ToString();

                    dgwClientsAuto.Rows.Add(clientName, autoGosNumber, brandName);
                }
                lblCount.Text = "0000";
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnSearchMore_Click(object sender, EventArgs e)
        {
            LoadClientsWithMoreThanOneCar();
        }

        private void btnClearChois_Click(object sender, EventArgs e)
        {
            loadClientsAuto();
        }

        public void LoadClientsWithMoreThanOneCar()
        {
            try
            {
                dgwClientsAuto.Rows.Clear();
                string query = @"
            SELECT c.name, COUNT(a.id_auto) AS car_count
            FROM clients c
            JOIN clients_has_auto cha ON cha.clients_id = c.id_client
            JOIN auto a ON cha.auto_id = a.id_auto
            GROUP BY c.name
            HAVING COUNT(a.id_auto) > 1;"; 

                MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                con.open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string clientName = reader["name"].ToString();                    
                    dgwClientsAuto.Rows.Add(clientName);
                }
                lblCount.Text = dgwClientsAuto.Rows.Count.ToString(); 
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion ClientsWithAuto
    }
}
