using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace App1
{
    public partial class AddAuto : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        string title = "AutoCar";

        Auto auto;
        public AddAuto(Auto au)
        {
            InitializeComponent();
            auto = au;
            LoadBrandsIntoComboBox();
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGosNumber.Text == "" || cbBrands.Text == "" || txtAutoRelis.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }

                if (!Regex.IsMatch(txtGosNumber.Text.ToUpper(), @"^[АВЕКМНОРСТУХABEKMHOPCTYX]{1}\d{3}[АВЕКМНОРСТУХABEKMHOPCTYX]{2}\d{2,3}$"))
                {
                    MessageBox.Show("Номер автомобиля должен быть в формате А888НА174!", "Некорректный формат номера");
                    return;
                }

                cmd = new MySqlCommand("SELECT COUNT(*) FROM auto WHERE goss_number = @goss_number", con.connect_());
                cmd.Parameters.AddWithValue("@goss_number", txtGosNumber.Text.ToUpper());

                con.open();
                int exists = Convert.ToInt32(cmd.ExecuteScalar());
                con.close();

                if (exists > 0)
                {
                    MessageBox.Show("Автомобиль с таким номером уже существует!", "Внимание");
                    return;
                }

                if (!Regex.IsMatch(txtAutoRelis.Text, @"^\d{4}$"))
                {
                    MessageBox.Show("Год выпуска должен быть четырехзначным числом!", "Некорректный год выпуска");
                    return;
                }

                if (MessageBox.Show("Вы точно хотите записать новый автомобиль?", "Запись нового автомобиля", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("INSERT INTO auto (goss_number, date_relis, brand) VALUES(@goss_number, @date_relis, @brand)", con.connect_());
                    cmd.Parameters.AddWithValue("@goss_number", txtGosNumber.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@date_relis", txtAutoRelis.Text);
                    cmd.Parameters.AddWithValue("@brand", Convert.ToInt32(cbBrands.SelectedValue));

                    con.open();
                    cmd.ExecuteNonQuery();
                    con.close();

                    MessageBox.Show("Автомобиль записан.", title);
                    Clear();
                    this.Dispose();
                    auto.loadAuto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGosNumber.Text == "" || cbBrands.Text == "" || txtAutoRelis.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }

                if (!Regex.IsMatch(txtGosNumber.Text.ToUpper(), @"^[АВЕКМНОРСТУХABEKMHOPCTYX]{1}\d{3}[АВЕКМНОРСТУХABEKMHOPCTYX]{2}\d{2,3}$"))
                {
                    MessageBox.Show("Номер автомобиля должен быть в формате А888НА174!", "Некорректный формат номера");
                    return;
                }

                string idAuto = lblAid.Text;
                MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM auto WHERE goss_number = @goss_number AND id_auto != @id_auto", con.connect_());
                cmd.Parameters.AddWithValue("@goss_number", txtGosNumber.Text.ToUpper());
                cmd.Parameters.AddWithValue("@id_auto", idAuto);

                con.open();
                int exists = Convert.ToInt32(cmd.ExecuteScalar());
                con.close();

                if (exists > 0)
                {
                    MessageBox.Show("Другой автомобиль с таким номером уже существует!", title);
                    return;
                }

                if (!Regex.IsMatch(txtAutoRelis.Text, @"^\d{4}$"))
                {
                    MessageBox.Show("Год выпуска должен быть четырехзначным числом!", "Некорректный год выпуска");
                    return;
                }

                if (MessageBox.Show("Редактировать запись?", "Редактирование", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand(@"UPDATE auto SET goss_number=@goss_number, 
                                                            date_relis=@date_relis, 
                                                            brand=@brand 
                                                            WHERE id_auto=@id_auto ", 
                                                            con.connect_());
                    cmd.Parameters.AddWithValue("@id_auto", idAuto);
                    cmd.Parameters.AddWithValue("@goss_number", txtGosNumber.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@date_relis", txtAutoRelis.Text);
                    cmd.Parameters.AddWithValue("@brand", Convert.ToInt32(cbBrands.SelectedValue));

                    con.open();
                    cmd.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Автомобиль отредактирован", title);

                    Clear();
                    auto.loadAuto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void LoadBrandsIntoComboBox()
        {
            try
            {
                con.open();
                cmd = new MySqlCommand("SELECT brand_id, brand_name FROM brand", con.connect_());
                MySqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                cbBrands.DataSource = dt;
                cbBrands.DisplayMember = "brand_name"; 
                cbBrands.ValueMember = "brand_id"; 

                reader.Close();
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region method
        
        public void Clear()
        {
            txtGosNumber.Clear();
            cbBrands.SelectedIndex = -1;
            txtAutoRelis.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion method
    }
}
