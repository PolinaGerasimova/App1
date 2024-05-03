using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Xml.Linq;

namespace App1
{
    public partial class AddPay : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        string title = "AutoCar";
        Cash cash;

        public AddPay(Cash csh)
        {
            InitializeComponent();
            LoadClients();
            cbSearchClient.SelectedIndexChanged += cbSearchClient_SelectedIndexChanged;
            cash = csh;
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbSearchClient.Text == "" || cbSearchAuto.Text == "" || txtSumm.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }

                int auto_id = GetAutoId(cbSearchAuto.Text);
                int clients_id = Convert.ToInt32(cbSearchClient.SelectedValue);
                int parking_id = GetParkingId(auto_id);

                decimal pay_summ = Convert.ToDecimal(txtSumm.Text);
                DateTime pay_date = DateTime.Now.Date;

                con.open();
                string query = "INSERT INTO pay (auto_id, clients_id, parking_id, pay_summ, pay_date) VALUES (@auto_id, @clients_id, @parking_id, @pay_summ, @pay_date)";
                MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                cmd.Parameters.AddWithValue("@auto_id", auto_id);
                cmd.Parameters.AddWithValue("@clients_id", clients_id);
                cmd.Parameters.AddWithValue("@parking_id", parking_id);
                cmd.Parameters.AddWithValue("@pay_summ", pay_summ);
                cmd.Parameters.AddWithValue("@pay_date", pay_date);

                cmd.ExecuteNonQuery();
                con.close();
                MessageBox.Show("Оплата сохранена успешно!", "Успех");
                Clear();
                this.Dispose();
                cash.loadPay();
                cash.loadBalans();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении оплаты: {ex.Message}", title);
            }
        }

 
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnSave.Enabled = true;
        }

        private void txtSearchClient_TextChanged(object sender, EventArgs e)
        {
            LoadClients(txtSearchClient.Text);
        }

        private void LoadClients(string searchTerm = "")
        {
            try
            {
                con.open();
                string query = "SELECT id_client, name FROM clients";
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE name LIKE @searchTerm";
                }

                MySqlCommand cmd = new MySqlCommand(query, con.connect_());

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                }

                MySqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                cbSearchClient.DataSource = dt;
                cbSearchClient.DisplayMember = "name";
                cbSearchClient.ValueMember = "id_client";

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
            finally
            {
                con.close();
            }
        }

        private void LoadCars(int clientId)
        {
            try
            {
                cbSearchAuto.Items.Clear();
                con.open();
                MySqlCommand cmd = new MySqlCommand("SELECT a.goss_number FROM auto a INNER JOIN clients_has_auto cha ON a.id_auto = cha.auto_id WHERE cha.clients_id = @clientId", con.connect_());
                cmd.Parameters.AddWithValue("@clientId", clientId);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbSearchAuto.Items.Add(reader["goss_number"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке автомобилей клиента");
            }
            finally
            {
                con.close();
            }
        }

        private void cbSearchClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSearchClient.SelectedValue != null)
            {
                int selectedClientId = Convert.ToInt32(cbSearchClient.SelectedValue);
                LoadCars(selectedClientId);
            }
        }

        #region method

        public void Clear()
        {
            txtSearchClient.Clear();
            txtSumm.Clear();
            cbSearchClient.SelectedIndex = -1;
            cbSearchAuto.SelectedIndex = -1;

            btnSave.Enabled = true;
        }
        private int GetAutoId(string gossNumber)
        {
            int autoId = -1;
            try
            {
                con.open();
                string query = "SELECT id_auto FROM auto WHERE goss_number = @gossNumber LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                cmd.Parameters.AddWithValue("@gossNumber", gossNumber);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    autoId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении ID автомобиля: {ex.Message}", title);
            }
            finally
            {
                con.close();
            }
            return autoId;
        }
        private int GetParkingId(int autoId)
        {
            int parkingId = -1;
            try
            {
                con.open();
                string query = "SELECT id_parking FROM parking WHERE auto_id = @autoId LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                cmd.Parameters.AddWithValue("@autoId", autoId);

                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    parkingId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении ID парковки: {ex.Message}", "Ошибка");
            }
            finally
            {
                con.close();
            }
            return parkingId;
        }
        #endregion method       
    }
}
