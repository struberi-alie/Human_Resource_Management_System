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
            this.Dock = DockStyle.Fill;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        //ADD BUTTON
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void LoadDepartments()
        {
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FilterEmployeesByDepartment(string departmentName)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
