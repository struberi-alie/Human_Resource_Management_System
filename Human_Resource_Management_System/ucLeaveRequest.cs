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
    public partial class ucLeaveRequest : UserControl
    {
        public ucLeaveRequest()
        {
            InitializeComponent();
        }

        private void ucLeaveRequests_Load(object sender, EventArgs e)
        {
            LoadLeaveData();
        }

        private void LoadLeaveData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT id, employee_name, leave_type, start_date, end_date, status FROM leaveRequests";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLeaveRequests.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void dgvLeaveRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = dgvLeaveRequests.Rows[e.RowIndex];

                lblEmployeeName.Text = row.Cells["employee_name"].Value.ToString();
                lblLeaveType.Text = row.Cells["leave_type"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string filter = textBox1.Text;

            var dt = dgvLeaveRequests.DataSource as DataTable;
            if (dt != null)
            {
                try
                {
                    dt.DefaultView.RowFilter = $"employee_name LIKE '%{filter.Replace("'", "''")}%'";
                }
                catch
                {
                    dt.DefaultView.RowFilter = string.Empty;
                }
            }
        }

        private void dgvLeaveRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                // Designer named the placeholder label 'lblPlaceHolder'
                lblPlaceHolder.Visible = false;

                DataGridViewRow row = dgvLeaveRequests.Rows[e.RowIndex];

                lblEmployeeName.Text = "Name: " + row.Cells["employee_name"].Value.ToString();
                lblLeaveType.Text = "Type: " + row.Cells["leave_type"].Value.ToString();
            }
        }

        private void lblEmployeeName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
