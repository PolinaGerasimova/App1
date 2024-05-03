using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
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
    public partial class Auto : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        string title = "AutoCar";
        public Auto()
        {
            InitializeComponent();
            loadAutoType();
            loadAuto();            
        }

        #region AutoType
        private void txtSearchAuto_TextChanged_1(object sender, EventArgs e)
        {
            loadAutoType();
        }

        private void btnAddBrand_Click_1(object sender, EventArgs e)
        {
            ManageAutoType module = new ManageAutoType(this);
            module.btnUpdate.Enabled = false;
            module.FormClosed += (s, args) =>
            {
                loadAutoType();
                loadAuto();
            };
            module.ShowDialog();
        }
       
        private void dgwBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgwBrands.Columns[e.ColumnIndex].Name;
            if (colName == "EditBrand")
            {
                ManageAutoType module = new ManageAutoType(this);
                module.lblBid.Text = dgwBrands.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txtNameBrand.Text = dgwBrands.Rows[e.RowIndex].Cells[1].Value.ToString();

                module.btnSave.Enabled = false;
                module.ShowDialog();
                module.FormClosed += (s, args) => 
                {
                    loadAutoType();
                    loadAuto(); 
                };
            }

            else if (colName == "DeleteBrand")
            {
                try
                {
                    if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string brandId = dgwBrands.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cmd = new MySqlCommand("DELETE FROM brand WHERE brand_id = @brand_id", con.connect_()); 
                        cmd.Parameters.AddWithValue("@brand_id", brandId);
                        con.open();
                        cmd.ExecuteNonQuery();
                        con.close();
                        MessageBox.Show("Запись удалена!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadAutoType();
                        loadAuto();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        public void loadAutoType()
        {
            try
            {
                dgwBrands.Rows.Clear();
                cmd = new MySqlCommand("SELECT brand_id, brand_name FROM brand WHERE CONCAT(brand_name) LIKE '%" + txtSearchAuto.Text + "%'", con.connect_());
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {                    
                    dgwBrands.Rows.Add(reader["brand_id"].ToString(), reader["brand_name"].ToString());
                }
                con.close();
                dgwBrands.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion AutoType    

        #region AddAutoInform
        private void btnAddAuto_Click(object sender, EventArgs e)
        {
            AddAuto module = new AddAuto(this);
            module.btnUpdate.Enabled = false;
            module.ShowDialog();
        }

        private void txtSearchAutoInform_TextChanged(object sender, EventArgs e)
        {
            loadAuto();
        }

        private void dgwAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgwAuto.Columns[e.ColumnIndex].Name;
            if (colName == "EditAuto")
            {
                AddAuto module = new AddAuto(this);
                module.lblAid.Text = dgwAuto.Rows[e.RowIndex].Cells[0].Value.ToString(); 
                module.txtGosNumber.Text = dgwAuto.Rows[e.RowIndex].Cells[1].Value.ToString(); 
                module.txtAutoRelis.Text = dgwAuto.Rows[e.RowIndex].Cells[2].Value.ToString();
                int index = module.cbBrands.FindStringExact(dgwAuto.Rows[e.RowIndex].Cells[3].Value.ToString()); 
                module.cbBrands.SelectedIndex = index >= 0 ? index : -1;

                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true; 
                module.ShowDialog();

                loadAuto();
            }
            else if (colName == "DeleteAuto")
            {
                if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idAuto = dgwAuto.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string query = "DELETE FROM auto WHERE id_auto = @idAuto";

                    connect con = new connect();
                    try
                    {
                        con.open(); 
                        MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                        cmd.Parameters.AddWithValue("@idAuto", idAuto);
                        cmd.ExecuteNonQuery(); 
                        con.close();

                        MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgwAuto.Rows.RemoveAt(e.RowIndex);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title);
                        con.close(); 
                    }
                }
            }
        }

        public void loadAuto()
        {
            try
            {
                dgwAuto.Rows.Clear();

                cmd = new MySqlCommand(@"SELECT auto.id_auto, auto.goss_number, auto.date_relis, brand.brand_name FROM auto 
                INNER JOIN brand ON auto.brand = brand.brand_id 
                WHERE CONCAT(auto.goss_number, brand.brand_name) LIKE '%" + txtSearchAutoInform.Text + "%'", con.connect_());
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgwAuto.Rows.Add(
                       reader["id_auto"].ToString(),    
                       reader["goss_number"].ToString(),
                       reader["date_relis"].ToString(),
                       reader["brand_name"].ToString());
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion AddAutoInform 
    }

}
