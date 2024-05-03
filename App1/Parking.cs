using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Parking : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        string title = "AutoCar";
        public Parking()
        {
            InitializeComponent();
            loadParking();
        }

        private void btnAddParking_Click(object sender, EventArgs e)
        {
            AddParking module = new AddParking(this);
            module.btnUpdate.Enabled = false;
            module.FormClosed += (s, args) => { loadParking(); };
            module.ShowDialog();
        }

        private void txtSearchParking_TextChanged(object sender, EventArgs e)
        {
            loadParking();
        }

        private void dgwParking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgwParking.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                AddParking module = new AddParking(this);
                module.lblPid.Text = dgwParking.Rows[e.RowIndex].Cells[0].Value.ToString();
                module.txtNumberParking.Text = dgwParking.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtCostParking.Text = dgwParking.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.btnSave.Enabled = false;
                module.ShowDialog();
                module.FormClosed += (s, args) =>
                {
                    loadParking();
                };
            }
            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string idParking = dgwParking.Rows[e.RowIndex].Cells[0].Value.ToString();
                        cmd = new MySqlCommand("DELETE FROM parking WHERE id_parking = @id_parking", con.connect_());
                        cmd.Parameters.AddWithValue("@id_parking", idParking);
                        con.open();
                        cmd.ExecuteNonQuery();
                        con.close();
                        MessageBox.Show("Запись удалена!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadParking();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            else if (colName == "DeleteAuto")
            {
                try
                {
                    string idParking = dgwParking.Rows[e.RowIndex].Cells[0].Value.ToString();
                    MySqlCommand cmd = new MySqlCommand("UPDATE parking SET auto_id = 0, date_parking = NULL WHERE id_parking = @id_parking", con.connect_());
                    cmd.Parameters.AddWithValue("@id_parking", idParking);

                    con.open();
                    int result = cmd.ExecuteNonQuery();
                    con.close();

                    if (result > 0)
                    {
                        MessageBox.Show("Автомобиль успешно удалён из парковки!", "Удаление автомобиля", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при удалении автомобиля из парковки или автомобиля не было на парковке.", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    loadParking();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка обновления парковки");
                }
            }

        }

        public void loadParking()
        {
            try
            {
                dgwParking.Rows.Clear();
                if (!dgwParking.Columns.Contains("date_parking"))
                {
                    DataGridViewCalendarColumn dateColumn = new DataGridViewCalendarColumn();
                    dateColumn.Name = "date_parking";
                    dateColumn.HeaderText = "Дата заезда";
                    dateColumn.DefaultCellStyle.Format = "d";
                    dateColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    dgwParking.Columns.Add(dateColumn);
                }
                DataGridViewComboBoxColumn gossNumberAutoColumn = (DataGridViewComboBoxColumn)dgwParking.Columns["goss_numberAuto"];
                DataTable autoDataTable = new DataTable();
                MySqlCommand autoCmd = new MySqlCommand(@"SELECT id_auto, goss_number 
                                                FROM auto WHERE id_auto NOT IN
                                                ( SELECT auto_id FROM parking  WHERE auto_id IS NOT NULL )", con.connect_());
                MySqlDataAdapter adapter = new MySqlDataAdapter(autoCmd);

                adapter.Fill(autoDataTable);
                var autoLookup = autoDataTable.AsEnumerable()
                            .ToDictionary(row => row.Field<int>("id_auto"),
                            row => row.Field<string>("goss_number"));
                gossNumberAutoColumn.DataSource = autoDataTable;
                gossNumberAutoColumn.DisplayMember = "goss_number";
                gossNumberAutoColumn.ValueMember = "id_auto";

                string searchPattern = "%" + txtSearchParking.Text + "%";
                string query = @"SELECT p.id_parking, p.parking_namber, p.cost_to_month, p.date_parking, a.id_auto, a.goss_number
                       FROM parking p LEFT JOIN auto a ON p.auto_id = a.id_auto 
                       WHERE CONCAT(p.parking_namber, p.cost_to_month) LIKE @searchPattern";
                con.open();
                using (MySqlCommand cmd = new MySqlCommand(query, con.connect_()))
                {
                    cmd.Parameters.AddWithValue("@searchPattern", searchPattern);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int index = dgwParking.Rows.Add(reader["id_parking"].ToString(),
                                                        reader["parking_namber"].ToString(),
                                                        reader["cost_to_month"].ToString()
                                                        );
                        DataGridViewRow row = dgwParking.Rows[index];

                        if (reader["id_auto"] != DBNull.Value)
                        {
                            int id_auto = Convert.ToInt32(reader["id_auto"]);
                            if (autoLookup.ContainsKey(id_auto))
                            {
                                row.Cells["goss_numberAuto"].Value = id_auto;
                            }
                            else
                            {
                                var cell = new DataGridViewTextBoxCell();
                                cell.Value = reader["goss_number"].ToString();
                                row.Cells["goss_numberAuto"] = cell;
                            }
                        }
                        if (reader["date_parking"] != DBNull.Value)
                        {
                            row.Cells["date_parking"].Value = Convert.ToDateTime(reader["date_parking"]).ToShortDateString();
                        }
                    }
                    con.close();
                    dgwParking.Columns[0].Visible = false;
                    dgwParking.Columns["goss_numberAuto"].DefaultCellStyle.Font = new Font("Arial", 11);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка загрузки парковки");
            }
        }

        private void dgwParking_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgwParking.CurrentCell.ColumnIndex == dgwParking.Columns["goss_numberAuto"].Index && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= new EventHandler(comboBox_SelectedIndexChanged);
                comboBox.SelectedIndexChanged += new EventHandler(comboBox_SelectedIndexChanged);
            }
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                DataGridViewRow currentRow = dgwParking.CurrentRow;
                if (currentRow != null)
                {
                    int id_auto = Convert.ToInt32(comboBox.SelectedValue);
                    int id_parking = Convert.ToInt32(currentRow.Cells["id_parking"].Value);

                    string query = "UPDATE parking SET auto_id = @auto_id WHERE id_parking = @id_parking";
                    try
                    {
                        using (MySqlConnection conn = con.connect_())
                        {
                            using (MySqlCommand updateCmd = new MySqlCommand(query, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@auto_id", id_auto);
                                updateCmd.Parameters.AddWithValue("@id_parking", id_parking);
                                conn.Open();
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        loadParking();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, title);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dgwParking.CurrentRow;
            if (currentRow != null)
            {
                string id_parking = currentRow.Cells[0].Value.ToString();
                string checkQuery = "SELECT auto_id FROM parking WHERE id_parking = @id_parking";
                string updateQuery = "UPDATE parking SET auto_id = @auto_id, date_parking = @date_parking WHERE id_parking = @id_parking";
                int? existingAutoId = null;

                using (MySqlConnection conn = con.connect_())
                {
                    conn.Open();
                    using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@id_parking", id_parking);

                        using (var reader = checkCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                existingAutoId = reader["auto_id"] != DBNull.Value ? (int?)reader["auto_id"] : null;
                            }
                        }
                    }

                    DataGridViewComboBoxCell comboBoxCell = currentRow.Cells["goss_numberAuto"] as DataGridViewComboBoxCell;
                    int? id_auto = existingAutoId;
                    if (comboBoxCell != null && comboBoxCell.Value != null)
                    {
                        if (int.TryParse(comboBoxCell.Value.ToString(), out int selectedValue))
                        {
                            id_auto = selectedValue;
                        }
                    }

                    DataGridViewTextBoxCell dateCell = currentRow.Cells["date_parking"] as DataGridViewTextBoxCell;
                    DateTime? newDateParking = null;
                    if (dateCell != null && dateCell.Value != null && DateTime.TryParse(dateCell.Value.ToString(), out DateTime date))
                    {
                        newDateParking = date;
                    }

                    using (MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@id_parking", id_parking);
                        updateCmd.Parameters.AddWithValue("@auto_id", id_auto ?? (object)DBNull.Value);
                        updateCmd.Parameters.AddWithValue("@date_parking", newDateParking.HasValue ? (object)newDateParking.Value : DBNull.Value);

                        if (!id_auto.HasValue && newDateParking.HasValue)
                        {
                            MessageBox.Show("Нельзя установить дату без машины", title);
                        }
                        else if (id_auto.HasValue && !newDateParking.HasValue)
                        {
                            MessageBox.Show("Выберите дату установки на парковку", title);
                        }
                        else
                        {
                            updateCmd.ExecuteNonQuery();
                            MessageBox.Show("Информация о парковке была обновлена. Auto_id: " + (id_auto.HasValue ? id_auto.ToString() : (existingAutoId.HasValue ? existingAutoId.ToString() : "не изменено")), "Успех");
                            UpdateCreditAfterParking(id_parking, id_auto, newDateParking);
                        }
                    }
                }
                loadParking();
            }
        }
        private void UpdateCreditAfterParking(string id_parking, int? newAutoId, DateTime? newDateParking)
        {
            if (newAutoId == null)
            {
                MessageBox.Show("Отсутствует ID автомобиля. Обновление в credit невозможно.", title);
                return;
            }
            string getCostToMonthQuery = "SELECT cost_to_month FROM parking WHERE id_parking = @id_parking";

            string getClientAndAutoQuery = @"
            SELECT c.id_client, cha.auto_id 
            FROM clients_has_auto cha
            JOIN clients c ON cha.clients_id = c.id_client
            WHERE cha.auto_id = @auto_id
            LIMIT 1";

            string insertCreditQuery = @"
    INSERT INTO credit(parking_id, credit_date, credit_summ, auto_id, clients_id)
    VALUES (@parking_id, @credit_date, @credit_summ, @auto_id, @clients_id)";

            using (MySqlConnection conn = con.connect_())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                int cost_to_month = 0;
                using (MySqlCommand getCostCmd = new MySqlCommand(getCostToMonthQuery, conn))
                {
                    getCostCmd.Parameters.AddWithValue("@id_parking", id_parking);

                    using (var reader = getCostCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cost_to_month = reader.GetInt32("cost_to_month");
                        }
                    }
                }

                if (cost_to_month == 0)
                {
                    MessageBox.Show("Не удалось получить стоимость из парковки.", title);
                    return;
                }
                int? clientId = null;
                string autoDescription = null;
                using (MySqlCommand getClientCmd = new MySqlCommand(getClientAndAutoQuery, conn))
                {
                    getClientCmd.Parameters.AddWithValue("@auto_id", newAutoId.Value);

                    using (var reader = getClientCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clientId = reader.GetInt32("id_client");
                            autoDescription = reader["auto_id"].ToString();
                        }
                    }
                }

                if (clientId != null && autoDescription != null)
                {
                    using (MySqlCommand insertCreditCmd = new MySqlCommand(insertCreditQuery, conn))
                    {
                        insertCreditCmd.Parameters.AddWithValue("@parking_id", id_parking);
                        insertCreditCmd.Parameters.AddWithValue("@credit_date", newDateParking ?? DateTime.Now);
                        insertCreditCmd.Parameters.AddWithValue("@credit_summ", cost_to_month);
                        insertCreditCmd.Parameters.AddWithValue("@auto_id", autoDescription);
                        insertCreditCmd.Parameters.AddWithValue("@clients_id", clientId.Value);

                        insertCreditCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Кредитная информация обновлена с суммой {cost_to_month}.", title);
                }
                else
                {
                    MessageBox.Show("Не удалось получить данные клиента и автомобиля для обновления кредита.", title);
                }
            }
        }
    }
}
