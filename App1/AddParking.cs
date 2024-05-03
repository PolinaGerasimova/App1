using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace App1
{   
    public partial class AddParking : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        string title = "AutoCar";
        Parking parking;
        public AddParking(Parking pr)
        {
            InitializeComponent();
            parking = pr;

        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNumberParking.Text == "" || txtCostParking.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }
                Regex rx = new Regex(@"^(?:[1-9]|[1-9]\d|1\d\d|2\d\d|3\d\d|4\d\d|5\d\d|6\d\d|7\d\d|8\d\d|9\d\d)$");
                if (!rx.IsMatch(txtNumberParking.Text))
                {
                    MessageBox.Show("Номер парковочного места должен быть числом от 1 до 999!", "Ошибка");
                    return;
                }

                if (MessageBox.Show("Вы точно хотите записать новое место?", "Запись парковочного места", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("INSERT INTO parking (parking_namber, cost_to_month) VALUES(@parking_namber, @cost_to_month)", con.connect_());
                    cmd.Parameters.AddWithValue("@parking_namber", txtNumberParking.Text);
                    cmd.Parameters.AddWithValue("@cost_to_month", txtCostParking.Text);
                    con.open();
                    cmd.ExecuteNonQuery();
                    con.close();

                    parking.loadParking();
                    MessageBox.Show("Новое место добавлено!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose(); 
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
                if (txtNumberParking.Text == "" || txtCostParking.Text == "")
                {
                    MessageBox.Show("Заполните все поля!", "Внимание");
                    return;
                }

                Regex rx = new Regex(@"^(?:[1-9]|[1-9]\d|1\d\d|2\d\d|3\d\d|4\d\d|5\d\d|6\d\d|7\d\d|8\d\d|9\d\d)$");

                if (!rx.IsMatch(txtNumberParking.Text))
                {
                    MessageBox.Show("Номер парковочного места должен быть числом от 1 до 999!", "Ошибка");
                    return;
                }

                if (MessageBox.Show("Вы точно хотите информацию?", "Изменение парковки", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new MySqlCommand("UPDATE parking SET parking_namber=@parking_namber, cost_to_month=@cost_to_month WHERE id_parking=@id_parking", con.connect_());
                    cmd.Parameters.AddWithValue("@id_parking", lblPid.Text);
                    cmd.Parameters.AddWithValue("@parking_namber", txtNumberParking.Text);
                    cmd.Parameters.AddWithValue("@cost_to_month", txtCostParking.Text);

                    con.open();
                    cmd.ExecuteNonQuery();
                    con.close();
                    MessageBox.Show("Изменено", title);
                    Clear();
                    parking.loadParking();
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
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        #region method

        public void Clear()
        {
            txtNumberParking.Clear();
            txtCostParking.Clear();

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        #endregion method   
    }
}
