using infomanagement;
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


namespace Human_Resource_Management_System
{
    public partial class Ash : UserControl
    {
        public Ash()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
            private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void prgLoading1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private async void Ash_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblDate.Text = $"{DateTime.Now:dddd, MMMM d, yyyy}";

            try
            {
                using (var conn = new MySqlConnection(DatabaseConnection.ConnectionString))
                using (var cmd = new MySqlCommand("SP_AttendanceOverview", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@p_TargetDate", DateTime.Today.Date);

                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            lblPresent.Text = reader["TotalPresent"] != DBNull.Value ? reader["TotalPresent"].ToString() : "0";
                            lblAbsent.Text = reader["TotalAbsent"] != DBNull.Value ? reader["TotalAbsent"].ToString() : "0";
                            lblLate.Text = reader["TotalLate"] != DBNull.Value ? reader["TotalLate"].ToString() : "0";
                        }
                        else
                        {
                            lblPresent.Text = "0";
                            lblAbsent.Text = "0";
                            lblLate.Text = "0";
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                var attList = new List<AttendanceInfo>();

                using (var conn = new MySqlConnection(DatabaseConnection.ConnectionString))
                using (var cmd = new MySqlCommand("SP_GetAllAttendance", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    await conn.OpenAsync();

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            attList.Add(new AttendanceInfo
                            {
                                EmployeeId = reader["empId"] != DBNull.Value ? reader["empId"].ToString() : "N/A",
                                EmployeeFirstName = reader["firstName"] != DBNull.Value ? reader["firstName"].ToString() : "N/A",
                                EmployeeLastName = reader["lastName"] != DBNull.Value ? reader["lastName"].ToString() : "N/A",
                                AttendanceDate = reader["attendanceDate"] != DBNull.Value ? Convert.ToDateTime(reader["attendanceDate"]).ToString("yyyy-MM-dd") : "N/A",
                                TimeIn = reader["clockTimeIn"] != DBNull.Value
                                ? (DateTime.Today + (TimeSpan)reader["clockTimeIn"]).ToString("hh:mm tt")
                                : "N/A",
                                TimeOut = reader["clockTimeOut"] != DBNull.Value
                                ? (DateTime.Today + (TimeSpan)reader["clockTimeOut"]).ToString("hh:mm tt")
                                : "N/A",
                                AttendanceStatus = reader["attendanceStatus"] != DBNull.Value ? reader["attendanceStatus"].ToString() : "Unspecified"
                            });
                        }
                    }
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = attList;
        }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database DataGrid Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred on the DataGridView: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblStatNumber1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void PrgLoading3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private class AttendanceInfo
        {
            public string EmployeeId { get; set; }
            public string EmployeeFirstName { get; set; }
            public string EmployeeLastName { get; set; }
            public string AttendanceDate { get; set; }
            public string TimeIn { get; set; }
            public string TimeOut { get; set; }
            public string AttendanceStatus { get; set; }
        }
    }
}
