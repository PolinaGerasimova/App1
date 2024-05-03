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
    public partial class ManageAutoType : Form
    {
        connect con = new connect();// вызов класса connect
        MySqlCommand cmd = new MySqlCommand();        
        string title = "AutoCar";
        Auto auto;
        public ManageAutoType(Auto au)
        {
            InitializeComponent();
            auto = au;
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameBrand.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }
                if (MessageBox.Show("Вы точно хотите записать новый бренд?", "Запись нового бренда", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("INSERT INTO brand (brand_name) VALUES(@brand_name)", con.connect_());
                    cmd.Parameters.AddWithValue("@brand_name", txtNameBrand.Text);
                    con.open();
                    cmd.ExecuteNonQuery();
                    con.close();

                    auto.loadAutoType(); // Обновляем список брендов в главном окне после добавления нового бренда
                    MessageBox.Show("Новый бренд успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(); // Закрываем форму добавления бренда
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameBrand.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }
                if (MessageBox.Show("Вы точно хотите изменить бренд?", "Запись бренда", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("UPDATE brand SET brand_name=@brand_name WHERE brand_id=@brand_id", con.connect_());
                    cmd.Parameters.AddWithValue("@brand_id", lblBid.Text);
                    cmd.Parameters.AddWithValue("@brand_name", txtNameBrand.Text);

                    con.open(); 
                    cmd.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Бренд изменен", title);
                    Clear();
                    auto.loadAutoType();
                    auto.loadAuto();
                    this.Dispose();
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
        }

        #region method
        public void Clear()
        {
            txtNameBrand.Clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion method
    }
}
