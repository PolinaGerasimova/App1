using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace App1
{
    public partial class Cash : Form
    {
        connect con = new connect();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;
        string title = "AutoCar";
        public Cash()
        {
            InitializeComponent();
            loadCredit();
            loadPay();
            loadBalans();
        }

        #region Credit
        private void dgwAuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

        private void txtSearchCredit_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchCredit.Text.Trim();
            foreach (DataGridViewRow row in dgwAuto.Rows)
            {
                if (row.Cells["client_name"].Value != null && row.Cells["goss_number"].Value != null)
                {
                    if (row.Cells["client_name"].Value.ToString().Contains(searchText) || row.Cells["goss_number"].Value.ToString().Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        public void loadCredit()
        {
            try
            {
                dgwAuto.Rows.Clear();
                cmd = new MySqlCommand(@"SELECT c.id_credit, cl.name AS client_name, a.goss_number, p.parking_namber, c.credit_date, c.credit_summ
                FROM credit AS c
                INNER JOIN auto AS a ON c.auto_id = a.id_auto
                INNER JOIN parking AS p ON c.parking_id = p.id_parking
                INNER JOIN clients AS cl ON c.clients_id = cl.id_client
                WHERE a.goss_number LIKE @searchText OR p.parking_namber LIKE @searchText", con.connect_());

                cmd.Parameters.AddWithValue("@searchText", "%" + txtSearchCredit.Text.Trim() + "%");

                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime credit_date = Convert.ToDateTime(reader["credit_date"]);
                    string formattedDate = credit_date.ToString("dd-MM-yyyy");

                    dgwAuto.Rows.Add(reader["id_credit"].ToString(),
                                     reader["client_name"].ToString(),
                                     reader["goss_number"].ToString(),
                                     reader["parking_namber"].ToString(),
                                     formattedDate,
                                     reader["credit_summ"].ToString());
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion Credit

        #region Pay

        private void btnAddPay_Click(object sender, EventArgs e)
        {
            AddPay module = new AddPay(this);
            module.ShowDialog();
        }
        private void dgwPay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string colName = dgwPay.Columns[e.ColumnIndex].Name;
                if (colName == "DeletePay")
                {
                    if (MessageBox.Show("Вы точно хотите удалить запись?", "Удаление записи", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string idPay = dgwPay.Rows[e.RowIndex].Cells[0].Value.ToString();
                        string query = "DELETE FROM pay WHERE id_pay = @idPay";

                        connect con = new connect();
                        try
                        {
                            con.open();
                            MySqlCommand cmd = new MySqlCommand(query, con.connect_());
                            cmd.Parameters.AddWithValue("@idPay", idPay);
                            cmd.ExecuteNonQuery();
                            con.close();

                            MessageBox.Show("Запись удалена!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgwPay.Rows.RemoveAt(e.RowIndex);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, title);
                            con.close();
                        }
                    }
                }
            }
        }
        public void loadPay()
        {
            try
            {
                dgwPay.Rows.Clear();
                cmd = new MySqlCommand(@"SELECT pay.id_pay, cl.name AS client_name, a.goss_number, p.parking_namber,pay.pay_date, pay.pay_summ
                                FROM pay
                                INNER JOIN auto AS a ON pay.auto_id = a.id_auto
                                INNER JOIN parking AS p ON pay.parking_id = p.id_parking
                                INNER JOIN clients AS cl ON pay.clients_id = cl.id_client
                                WHERE a.goss_number LIKE @searchText OR p.parking_namber LIKE @searchText",
                                        con.connect_());

                cmd.Parameters.AddWithValue("@searchText", "%" + txtSearchCredit.Text + "%");

                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    DateTime pay_date = Convert.ToDateTime(reader["pay_date"]);
                    string formatedDate = pay_date.ToString("dd-MM-yyyy");

                    dgwPay.Rows.Add(reader["id_pay"].ToString(),
                            reader["client_name"].ToString(),
                            reader["goss_number"].ToString(),
                            reader["parking_namber"].ToString(),
                            formatedDate,
                            reader["pay_summ"].ToString());
                }
                con.close();
                loadBalans();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion Pay

        #region Balans
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim();
            loadBalans(searchQuery);
        }

        public void loadBalans(string searchQuery = "")
        {
            try
            {
                dgwBalans.Rows.Clear();
                string query = $@"
                        SELECT 
                        cl.name AS Client,
                        a.goss_number AS Auto_goss_number,
                        MAX(p.pay_date) AS date_last_pay,
                        COALESCE(SUM(p.pay_summ), 0) AS All_Pay,
                        COALESCE(SUM(c.credit_summ), 0) AS All_Credit,
                        (COALESCE(SUM(c.credit_summ), 0) - COALESCE(SUM(p.pay_summ), 0)) AS balans
                    FROM  clients cl
                    INNER JOIN clients_has_auto cha ON cl.id_client = cha.clients_id
                    INNER JOIN auto a ON cha.auto_id = a.id_auto
                    LEFT JOIN (
                        SELECT clients_id, auto_id, SUM(pay_summ) AS pay_summ, MAX(pay_date) AS pay_date
                        FROM pay
                        GROUP BY clients_id, auto_id
                    ) p ON p.clients_id = cha.clients_id AND p.auto_id = cha.auto_id
                    LEFT JOIN (
                        SELECT clients_id, auto_id, SUM(credit_summ) AS credit_summ
                        FROM credit
                        GROUP BY clients_id, auto_id
                    ) c ON c.clients_id = cha.clients_id AND c.auto_id = cha.auto_id
                    WHERE cl.name LIKE @searchQuery OR a.goss_number LIKE @searchQuery
                    GROUP BY cl.name, a.goss_number
                    ORDER BY cl.name, a.goss_number;";
                cmd = new MySqlCommand(query, con.connect_());
                con.open();
                cmd.Parameters.AddWithValue("@searchQuery", $"%{searchQuery}%");
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    DateTime date_last_pay = reader.IsDBNull(reader.GetOrdinal("date_last_pay")) ? DateTime.MinValue : Convert.ToDateTime(reader["date_last_pay"]);
                    string formattedDateLastPay = date_last_pay == DateTime.MinValue ? "" : date_last_pay.ToString("dd-MM-yyyy");
                    dgwBalans.Rows.Add(reader["Client"].ToString(),
                                       reader["Auto_goss_number"].ToString(),
                                       formattedDateLastPay,
                                       reader["All_Pay"].ToString(),
                                       reader["All_Credit"].ToString(),
                                       reader["balans"].ToString());
                }
                con.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion Balans

        #region Min&Max

        private void btnClear_Click(object sender, EventArgs e)
        {
            loadBalans();
        }
        private void btnMaxCredit_Click(object sender, EventArgs e)
        {
            findMaxDebtClientOverall();
        }

        public void findMaxDebtClientOverall()
        {
            try
            {
                dgwBalans.Rows.Clear();
                var connection = new connect();

                string query = @"
                                SELECT 
                                    cl.name AS Client,
                                    a.goss_number AS Auto_goss_number,
                                    MAX(p.pay_date) AS date_last_pay,
                                    COALESCE(SUM(p.pay_summ), 0) AS All_Pay,
                                    COALESCE(SUM(c.credit_summ), 0) AS All_Credit,
                                    (COALESCE(SUM(c.credit_summ), 0) - COALESCE(SUM(p.pay_summ), 0)) AS balans
                                FROM clients cl
                                INNER JOIN clients_has_auto cha ON cl.id_client = cha.clients_id
                                INNER JOIN auto a ON cha.auto_id = a.id_auto
                                LEFT JOIN (
                                    SELECT clients_id, auto_id, SUM(pay_summ) AS pay_summ, MAX(pay_date) AS pay_date
                                    FROM pay
                                    GROUP BY clients_id, auto_id
                                ) p ON p.clients_id = cha.clients_id AND p.auto_id = cha.auto_id
                                LEFT JOIN (
                                    SELECT clients_id, auto_id, SUM(credit_summ) AS credit_summ
                                    FROM credit
                                    GROUP BY clients_id, auto_id
                                ) c ON c.clients_id = cha.clients_id AND c.auto_id = cha.auto_id
                                GROUP BY cl.name, a.goss_number
                                ORDER BY balans DESC
                                LIMIT 1;";

                connection.open();
                using (var cmd = new MySqlCommand(query, connection.connect_()))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime date_last_pay = reader.IsDBNull(reader.GetOrdinal("date_last_pay")) ? DateTime.MinValue : Convert.ToDateTime(reader["date_last_pay"]);
                            string formattedDateLastPay = date_last_pay == DateTime.MinValue ? "N/A" : date_last_pay.ToString("dd-MM-yyyy");
                            dgwBalans.Rows.Add(reader["Client"].ToString(),
                                            reader["Auto_goss_number"].ToString(),
                                            formattedDateLastPay,
                                            reader["All_Pay"].ToString(),
                                            reader["All_Credit"].ToString(),
                                            reader["balans"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Не найдены данные по заданным критериям.");
                        }
                    }
                }
                connection.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        private void btnMinCredit_Click(object sender, EventArgs e)
        {
            findMinDebtClientForPeriod(dtp1.Value, dtp2.Value);
        }

        public void findMinDebtClientForPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                dgwBalans.Rows.Clear();
                var connection = new connect();

                string query = $@"
                                SELECT
                                    cl.name AS Client,
                                    a.goss_number AS Auto_goss_number,
                                    COALESCE(SUM(c.credit_summ) - SUM(p.pay_summ), 0) AS balans
                                FROM clients cl
                                INNER JOIN clients_has_auto cha ON cl.id_client = cha.clients_id
                                INNER JOIN auto a ON cha.auto_id = a.id_auto
                                LEFT JOIN pay p ON p.clients_id = cha.clients_id 
                                                AND p.auto_id = cha.auto_id 
                                                AND p.pay_date BETWEEN @startDate 
                                                AND @endDate
                                LEFT JOIN credit c ON c.clients_id = cha.clients_id 
                                                AND c.auto_id = cha.auto_id 
                                                AND c.credit_date BETWEEN @startDate 
                                                AND @endDate
                                GROUP BY cl.name, a.goss_number
                                ORDER BY balans ASC
                                LIMIT 1;";

                connection.open();

                using (var cmd = new MySqlCommand(query, connection.connect_()))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string client = reader["Client"].ToString();
                            string autoGossNumber = reader["Auto_goss_number"].ToString();
                            string balans = reader["balans"].ToString();

                            dgwBalans.Rows.Add(client, autoGossNumber, "", "", balans);
                        }
                        else
                        {
                            MessageBox.Show("Не найдены данные по заданным критериям.");
                        }
                    }
                }

                connection.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnAllDebt_Click(object sender, EventArgs e)
        {
            findAllDebtForPeriod(dtp1.Value, dtp2.Value);
        }

        public void findAllDebtForPeriod(DateTime startDate, DateTime endDate)
        {
            try
            {
                dgwBalans.Rows.Clear();
                var connection = new connect();

                string query = $@"SELECT
                            COALESCE(SUM(creditSum) - SUM(paySum), 0) AS totalDebt
                        FROM
                            (
                                SELECT
                                    cl.id_client,
                                    COALESCE(SUM(c.credit_summ), 0) AS creditSum,
                                    0 AS paySum
                                FROM clients cl
                                INNER JOIN clients_has_auto cha ON cl.id_client = cha.clients_id
                                INNER JOIN auto a ON cha.auto_id = a.id_auto
                                LEFT JOIN credit c ON c.clients_id = cha.clients_id 
                                    AND c.auto_id = cha.auto_id 
                                    AND c.credit_date BETWEEN @startDate 
                                    AND @endDate
                                GROUP BY cl.id_client

                                UNION ALL

                                SELECT
                                    cl.id_client,
                                    0 AS creditSum,
                                    COALESCE(SUM(p.pay_summ), 0) AS paySum
                                FROM clients cl
                                INNER JOIN clients_has_auto cha ON cl.id_client = cha.clients_id
                                INNER JOIN auto a ON cha.auto_id = a.id_auto
                                LEFT JOIN pay p ON p.clients_id = cha.clients_id 
                                    AND p.auto_id = cha.auto_id 
                                AND p.pay_date BETWEEN @startDate AND @endDate
                                GROUP BY cl.id_client
                            ) AS subQuery";

                connection.open();

                using (var cmd = new MySqlCommand(query, connection.connect_()))
                {
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@endDate", endDate.ToString("yyyy-MM-dd"));

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string totalDebt = reader["totalDebt"].ToString();
                            dgwBalans.Rows.Add("Общая задолженность", "", "", "", "", totalDebt);
                        }
                        else
                        {
                            MessageBox.Show("No data found for the given period.");
                        }
                    }
                }

                connection.close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion Min&Max
    }
}




