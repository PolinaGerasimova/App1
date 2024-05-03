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
    public partial class Clients : Form
    {
        connect con = new connect();
        MySqlCommand cmd;
        string title = "AutoCar";
        MySqlDataReader reader;
        public Clients()
        {
            InitializeComponent();
            loadClient();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClient module = new AddClient(this);
            module.btnUpdate.Enabled = false;
            module.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadClient();
        }

        private void dgwClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgwClient.Columns[e.ColumnIndex].Name;
            if (colName == "EditClient")
            {
                AddClient module = new AddClient(this);
                module.lblCid.Text = dgwClient.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txtName.Text = dgwClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtPhone.Text = dgwClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                object cellValue = dgwClient.Rows[e.RowIndex].Cells[3].Value;

                if (cellValue is IConvertible)
                {
                    try
                    {
                        DateTime date = Convert.ToDateTime(cellValue);
                        module.dtBirhtday.Value = date;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Формат даты не корректен.");
                    }
                }
                else
                {
                    MessageBox.Show("Значение ячейки невозможно преобразовать в дату.");
                }

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.ShowDialog();
                loadClient();
            }
            else if (colName == "DeleteClient")
            {

                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idClient = dgwClient.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string query = "DELETE FROM clients WHERE id_client = @idClient";

                    connect con = new connect();
                    try
                    {
                        con.open();
                        MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                        cmd.Parameters.AddWithValue("@idClient", idClient);
                        cmd.ExecuteNonQuery();
                        con.close();

                        MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgwClient.Rows.RemoveAt(e.RowIndex);
                        loadClient();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка");
                        con.close();
                    }
                }
            }
        }
        #region method
        public void loadClient()
        {
            try
            {
                dgwClient.Rows.Clear();
                cmd = new MySqlCommand("SELECT * FROM clients WHERE CONCAT (id_client, name, phone, birthday) LIKE '%" + txtSearch.Text + "%'", con.connect_());
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime birthday = Convert.ToDateTime(reader[3]);
                    string formatedDate = birthday.ToString("dd-MM-yyyy");

                    dgwClient.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), formatedDate);
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method  
    }
}
