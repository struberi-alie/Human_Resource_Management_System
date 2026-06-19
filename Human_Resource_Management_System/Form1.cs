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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void HighlightButton(Button clickedButton)
        {
            // Reset all buttons to default color
            foreach (Button btn in pnlSidebar.Controls.OfType<Button>())
                btn.BackColor = Color.FromArgb(45, 45, 48);

            // Highlight the clicked button
            clickedButton.BackColor = Color.FromArgb(0, 122, 204);
        }

        private void ucLeaveRequest_Load(object sender, EventArgs e)
        {
        }

        private void btnLeaveRequests_Click(object sender, EventArgs e)
        {
            // Create an instance of your UserControl
            ucLeaveRequest leavePage = new ucLeaveRequest();

            // Load it into the container
            LoadUserControl(leavePage);
        }
    }
}
