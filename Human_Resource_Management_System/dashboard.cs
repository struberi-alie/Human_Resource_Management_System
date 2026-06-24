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

            txtEmployeeId.Text = "  e. g. xxxxx";
            txtFirstName.Text = "First Name";
            txtLastName.Text = "  Last Name";
            txtEmail.Text = "  e. g. juandelacruz@email.com";
            txtPhone.Text = "  09XX-XXX-XXXX";


            dtpHD.Value = DateTime.Now;



            cmbDepartment.SelectedIndex = -1;
            cmbDepartment.Text = "   - Select Department -";

            cmbStatus.SelectedIndex = -1;
            cmbStatus.Text = "   - Select Status -";



            MessageBox.Show("Refresh Successfully!", "System Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dashboard_Load(sender, e);
        }


        //FOR DATA GRID VIEW
        private void dashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        //ADD BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) //validation first
            {
                return; 
            }

            //adding to database 
            try
            {
                //this is where u put the connection string to your database

                MessageBox.Show("Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // refresh the ui  to clear the form after saving
                btnRefreshClear_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }


        private bool ValidateInputs()
        {
            // 1. Validate Employee ID
            if (string.IsNullOrWhiteSpace(txtEmployeeId.Text) || txtEmployeeId.Text.Contains("e. g. xxxxx"))
            {
                MessageBox.Show("Please enter a valid Employee ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmployeeId.Focus();
                return false;
            }

            // 2. Validate First Name
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || txtFirstName.Text.Contains("First Name"))
            {
                MessageBox.Show("Please enter a valid First Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirstName.Focus();
                return false;
            }

            // 3. Validate Last Name
            if (string.IsNullOrWhiteSpace(txtLastName.Text) || txtLastName.Text.Contains("Last Name"))
            {
                MessageBox.Show("Please enter a valid Last Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastName.Focus();
                return false;
            }

            // 4. Validate Department Dropdown
            if (cmbDepartment.SelectedIndex == -1 || cmbDepartment.Text.Contains("- Select Department -"))
            {
                MessageBox.Show("Please select a Department.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDepartment.Focus();
                return false;
            }

            // 5. Validate Status Dropdown
            if (cmbStatus.SelectedIndex == -1 || cmbStatus.Text.Contains("- Select Status -"))
            {
                MessageBox.Show("Please select a Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            // 6. Validate Email Format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Contains("e. g.") || !Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // 7. Validate Phone Number
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
    }
}
