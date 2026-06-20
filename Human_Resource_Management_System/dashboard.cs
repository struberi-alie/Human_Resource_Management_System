using infomanagement;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_Resource_Management_System
{
    public partial class dashboard : UserControl
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshClear_Click(object sender, EventArgs e)
        {

            txtStudentID.Text = "  e. g. xxxxx";
            txtFirstName.Text = "First Name";
            txtLastName.Text = "  Last Name";
            txtEmail.Text = "  e. g. juandelacruz@email.com";
            txtPhone.Text = "  09XX-XXX-XXXX";


            dtpHD.Value = DateTime.Now;



            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "   - Select Department -";

            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "   - Select Status -";



            MessageBox.Show("Fields have been reset to default placeholders! Ready to refresh data.", "System Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dashboard_Load(sender, e);
        }


        //FOR DATA GRID VIEW
        private void dashboard_Load(object sender, EventArgs e)
        {
            string query = "SELECT empId AS 'Employee ID', firstName AS 'First Name', lastName AS 'Last Name', " +
                           "emailAddress AS 'Email', phoneNumber AS 'Phone', hireDate AS 'Hire Date', " +
                           "employmentStatus AS 'Status', monthlySalary AS 'Monthly Salary' " +
                           "FROM employee";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvEmployee.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        //ADD BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            // 1. Get data from textboxes
            string fName = txtFirstName.Text.Trim();
            string lName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // 2. Define the SQL query with parameters (@parameterName)
            string query = "INSERT INTO employee (firstName, lastName, emailAddress, phoneNumber, hireDate, employmentStatus, regularizationDate, monthlySalary) " +
                           "VALUES (@fName, @lName, @email, @phone, @hireDate, @status, @regularizationDate, @monthlySalary)";

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // 3. Bind the values to the parameters
                    cmd.Parameters.AddWithValue("@fName", fName);
                    cmd.Parameters.AddWithValue("@lName", lName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);

                    // 4. Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee added successfully!");
                        // Refresh your DataGridView to show the new record
                        dashboard_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding data: " + ex.Message);
                }
            }
        }

        private void LoadDepartments()
        {
            // Optimized query if you have a separate Departments table
            string query = @"SELECT e.* FROM Employees e 
                 JOIN Departments d ON e.departmentId = d.departmentId 
                 WHERE d.deptName = @dept"; using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                cmbDepartment.Items.Clear();
                while (reader.Read())
                {
                    cmbDepartment.Items.Add(reader["deptName"].ToString());
                }
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDepartment.SelectedIndex == -1) return;

            string selectedDept = cmbDepartment.SelectedItem.ToString();

            FilterEmployeesByDepartment(selectedDept);
        }

        private void FilterEmployeesByDepartment(string departmentName)
        {
            string query = "SELECT * FROM Employee WHERE departmentId = @dept"; ;

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dept", departmentName);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvEmployee.DataSource = dt;
            }
        }
    }
}
