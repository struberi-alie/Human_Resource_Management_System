using Human_Resource_Management_System;
using infomanagement;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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

        private void dashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            LoadEmployeeData();

        }

        private void btnRefreshClear_Click(object sender, EventArgs e)
        {
            txtEmployeeId.Text = "XXXXX";
            txtFirstName.Text = "First Name";
            txtLastName.Text = "  Last Name";
            txtEmail.Text = "  e. g. juandelacruz@email.com";
            txtPhone.Text = "  09XX-XXX-XXXX";


            dtpHD.Value = DateTime.Now;



            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "   - Select Department -";

            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "   - Select Status -";

            cmbShift.SelectedIndex = -1;
            cmbShift.Text = "   - Select Schedule -";


            MessageBox.Show("Refresh Successfully!", "System Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dashboard_Load(sender, e);
        }



        private string GenerateUsername(string firstName, string lastName)
        {
            // Takes the first letter of the first name + full last name, converted to lowercase
            string username = firstName.Substring(0, 1).ToLower() + lastName.ToLower();

            // Remove any accidental spaces
            return username.Replace(" ", "");
        }

        private bool ValidateInputs()
        {


            // Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text.Contains("First Name"))
            {
                MessageBox.Show("Please enter a valid First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text.Contains("Last Name"))
            {
                MessageBox.Show("Please enter a valid Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // Validate Department Dropdown
            if (cmbDepartment.SelectedIndex == -1 || cmbDepartment.Text.Contains("- Select Department -"))
            {
                MessageBox.Show("Please select a Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            // Validate Status Dropdown
            if (cmbStatus.SelectedIndex == -1 || cmbStatus.Text.Contains("- Select Status -"))
            {
                MessageBox.Show("Please select a Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            // Validate Email Format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Contains("e. g.") || !Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // Validate Phone Number
            // We remove any dashes the user might have typed before checking
            string cleanPhone = txtPhone.Text.Replace("-", "").Replace(" ", "");
            string phonePattern = @"^(09)\d{9}$";

            if (string.IsNullOrWhiteSpace(txtPhone.Text) || txtPhone.Text.Contains("09XX") || !Regex.IsMatch(cleanPhone, phonePattern))
            {
                MessageBox.Show("Please enter a valid 11-digit Phone Number (e.g., 09123456789).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return false;
            }

            // If all checks pass
            return true;
        }

        private void LoadEmployeeData()
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_GetAllEmployees", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dgvEmployee.AutoGenerateColumns = false;
                            dgvEmployee.DataSource = dt;

                            dgvEmployee.Columns["empID"].DataPropertyName = "empId";
                            dgvEmployee.Columns["firstname"].DataPropertyName = "firstName";
                            dgvEmployee.Columns["lastname"].DataPropertyName = "lastName";
                            dgvEmployee.Columns["email"].DataPropertyName = "emailAddress";
                            dgvEmployee.Columns["phone"].DataPropertyName = "phoneNumber";
                            dgvEmployee.Columns["hiredate"].DataPropertyName = "HireDate";
                            dgvEmployee.Columns["regdate"].DataPropertyName = "regularizationDate";
                            dgvEmployee.Columns["status"].DataPropertyName = "EmploymentStatus";
                            dgvEmployee.Columns["department"].DataPropertyName = "departmentName";
                            dgvEmployee.Columns["shift"].DataPropertyName = "ShiftName";

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void dgvEmployee_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];

                txtEmployeeId.Text = row.Cells["empID"].Value.ToString();
                txtFirstName.Text = row.Cells["firstname"].Value.ToString();
                txtLastName.Text = row.Cells["lastname"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                txtPhone.Text = row.Cells["phone"].Value.ToString();
                cmbDepartment.Text = row.Cells["department"].Value.ToString();
                cmbShift.Text = row.Cells["shift"].Value.ToString();
                cmbStatus.Text = row.Cells["status"].Value.ToString();
            }
        }

        private void pnlStudentDetails_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
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

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        //CRUD

        //ADD BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            // 1. Generate the default password (e.g., 20260625) using hiredate
            string defaultPassword = dtpHD.Value.ToString("yyyyMMdd");

            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SP_CreateEmployeeWithUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@p_lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@p_email", txtEmail.Text.Trim());

                        string cleanPhone = txtPhone.Text.Replace("-", "").Replace(" ", "");
                        cmd.Parameters.AddWithValue("@p_phone", cleanPhone);

                        cmd.Parameters.AddWithValue("@p_deptName", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("@p_employmentStatus", cmbStatus.Text);
                        cmd.Parameters.AddWithValue("@p_hireDate", dtpHD.Value.Date);
                        cmd.Parameters.AddWithValue("@p_shiftName", cmbShift.Text);


                        //auto generated
                        cmd.Parameters.AddWithValue("@p_username", GenerateUsername(txtFirstName.Text.Trim(), txtLastName.Text.Trim()));
                        cmd.Parameters.AddWithValue("@p_password", defaultPassword);

                        // Execute the stored procedure
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error:\n" + ex.Message, "MySQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadEmployeeData();
            btnRefreshClear_Click(sender, e);

        }


        //FOR UPDATE
        private void button3_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DatabaseConnection.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SP_UpdateEmployee", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("p_empId", txtEmployeeId.Text);
                        cmd.Parameters.AddWithValue("p_firstName", txtFirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("p_lastName", txtLastName.Text.Trim());
                        cmd.Parameters.AddWithValue("p_email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("p_phone", txtPhone.Text.Trim());
                        cmd.Parameters.AddWithValue("p_hireDate", dtpHD.Value.Date);
                        cmd.Parameters.AddWithValue("p_deptName", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("p_shiftName", cmbShift.Text);
                        cmd.Parameters.AddWithValue("p_employmentStatus", cmbStatus.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee updated successfully!");

                        LoadEmployeeData(); // Refresh grid
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message);
                }
            }
        }


        //FOR DELETION
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this employee? This cannot be undone.",
                                                  "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    try
                    {
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand("SP_DeleteEmployee", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("p_empId", txtEmployeeId.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Employee deleted successfully!");

                            // Refresh data and clear fields
                            LoadEmployeeData();
                            btnRefreshClear_Click(sender, e);

                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Database Error: " + ex.Message);
                    }
                }
            }
        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
