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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void pnlMainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void LoadUserControl(UserControl uc)
        {
            // 1. Clear any current content
            pnlMainContainer.Controls.Clear();

            // 2. Setup the new control
            uc.Dock = DockStyle.Fill;

            // 3. Add to the panel
            pnlMainContainer.Controls.Add(uc);

            // 4. Ensure it sits on top
            uc.BringToFront();
        }

        //HIGHLIGHTING THE BUTTONS
        private void HighlightButton(Button clickedButton)
        {
            // Reset all buttons to default color
            foreach (Button btn in pnlSidebar.Controls.OfType<Button>())
                btn.BackColor = Color.FromArgb(45, 45, 48);

            // Highlight the clicked button
            clickedButton.BackColor = Color.FromArgb(0, 122, 204);
        }


        //FOR LEAVE REQUEST
        private void btnLeaveRequests_Click(object sender, EventArgs e)
        {
            HighlightButton(btnLeaveRequests);
            // Create an instance of your UserControl
            ucLeaveRequestUD leavePage = new ucLeaveRequestUD();
            LoadUserControl(leavePage);
        }


        //FOR PAYROLL
        private void button1_Click(object sender, EventArgs e)
        {
            HighlightButton(btnPayroll);
            ucPayroll payrollPage = new ucPayroll();

            LoadUserControl(payrollPage);
        }


        //FOR EMPLOYEES
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of your UserControl
            dashboard dashb = new dashboard();

            // Load it into the container
            LoadUserControl(dashb);
        }



        //FOR ATTENDANCE
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            {
                // Create an instance of your UserControl
                MainDashboard MainDashboard = new MainDashboard();

                // Load it into the container
                LoadUserControl(MainDashboard);
            }
        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(null);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
        }
    }
}
