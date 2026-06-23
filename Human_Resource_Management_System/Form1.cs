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

        public void LoadUserControl(UserControl uc)
        {
            // 1. Clear any current content
            panelMainContainer.Controls.Clear();

            // 2. Setup the new control
            uc.Dock = DockStyle.Fill;
            uc.AutoSize = false;    

            // 3. Add to the panel
            panelMainContainer.Controls.Add(uc);

            // 4. Ensure it sits on top
            uc.BringToFront();
        }

        //HIGHLIGHTING THE BUTTONS
        private void HighlightButton(Button clickedButton)
        {
            // Reset all buttons to default color
            foreach (Button btn in panelSideBar.Controls.OfType<Button>())
                btn.BackColor = Color.Teal;

            // Highlight the clicked button
            clickedButton.BackColor = Color.FromArgb(0, 122, 204);
        }


        private void frmMainForm_Load(object sender, EventArgs e)
        {
            MainDashboard dashboard = new MainDashboard();
            LoadUserControl(dashboard);
            this.HighlightButton(buttonDashboard);
        }

        //employee button
        private void button1_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new dashboard());
            this.HighlightButton(buttonEmployee);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MainDashboard());
            this.HighlightButton(buttonDashboard);
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Ash());
            this.HighlightButton(buttonAttendance);
        }

        private void buttonLRequest_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucLeaveRequestUD());
            this.HighlightButton(buttonLRequest);
        }

        private void buttonPayroll_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucPayroll());
            this.HighlightButton(buttonPayroll);
        }

        private void buttonDepartment_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ucDepartment());
            this.HighlightButton(buttonDepartment);
        }

        private void panelSideBar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelMainContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
