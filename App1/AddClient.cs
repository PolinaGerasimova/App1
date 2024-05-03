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
    public partial class AddClient : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();

        string title = "AutoCar";
        Clients client;
        bool check = false;
        public AddClient(Clients clnt)
        {
            InitializeComponent();
            client = clnt;
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Вы точно хотите создать нового клиента?", "Запись нового клиента", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string formattedPhone = "+7" + txtPhone.Text; 
                        cmd = new MySqlCommand("INSERT INTO clients(name, phone, birthday) VALUES(@name, @phone, @birthday)", con.connect_());
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", formattedPhone); 
                        cmd.Parameters.AddWithValue("@birthday", dtBirhtday.Value.Date);
                        con.open();
                        cmd.ExecuteNonQuery();
                        con.close();
                        MessageBox.Show("Клиент записан", title);
                        Clear();
                        check = false;
                        this.Dispose();
                        client.loadClient();
                    }
                }
            }
            catch (Exception ex)
            {
                con.close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {
                    if (MessageBox.Show("Вы точно хотите обновить информацию?", "Редактирование записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string formattedPhone = "+7" + txtPhone.Text; 
                        cmd = new MySqlCommand("UPDATE clients SET name=@name, phone=@phone, birthday=@birthday WHERE id_client=@id_client", con.connect_());
                        cmd.Parameters.AddWithValue("@id_client", lblCid.Text);
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@phone", formattedPhone); 
                        cmd.Parameters.AddWithValue("@birthday", dtBirhtday.Value.Date);
                        con.open();
                        cmd.ExecuteNonQuery();
                        con.close();
                        MessageBox.Show("Информация о клиенте обновлена", title);
                        Clear();
                        this.Dispose();
                        client.loadClient();
                    }
                }
            }
            catch (Exception ex)
            {
                con.close();
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        #region method
        public void Clear()
        {
            txtName.Clear();
            txtPhone.Clear();
            dtBirhtday.Value = DateTime.Now;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }

        public void checkField()
        {
            if (txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Внимание");
                return;
            }
            if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("Номер телефона должен содержать 10 цифр.", "Внимание");
                return;
            }

            if (checkAge(dtBirhtday.Value) < 18)
            {
                MessageBox.Show("Клиент не может быть моложе 18 лет!", "Внимание");
                return;
            }
            check = true;
        }

        private static int checkAge(DateTime birthday)
        {
            int age = DateTime.Now.Year - birthday.Year;
            if (DateTime.Now.Year < birthday.DayOfYear)
                age = age - 1;
            return age;        
        }
        #endregion method
    }
}
