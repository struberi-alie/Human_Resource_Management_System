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
    public partial class MainDashboard : UserControl
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            RefreshDashboardStats();
            LoadRecentActivity();
            LoadDepartmentHeadcount();
        }

        private void RefreshDashboardStats()
        {
            lblNumTE.Text = "142";
            lblNumLT.Text = "8";
            lblNumOLT.Text = "4";
            lblNumPLR.Text = "12";
        }

        private void LoadRecentActivity()
        {
            lstbxRecentActivity.Items.Clear();
            lstbxRecentActivity.Items.Add($"{DateTime.Now:yyyy-MM-dd} 08:05 | New employee record created");
            lstbxRecentActivity.Items.Add($"{DateTime.Now:yyyy-MM-dd} 09:12 | Employee #104 marked late");
            lstbxRecentActivity.Items.Add($"{DateTime.Now:yyyy-MM-dd} 10:30 | Leave request #12 approved");
            lstbxRecentActivity.Items.Add($"{DateTime.Now:yyyy-MM-dd} 13:45 | New leave request submitted");
            lstbxRecentActivity.Items.Add($"{DateTime.Now:yyyy-MM-dd} 15:20 | Employee details updated");
        }

        private void LoadDepartmentHeadcount()
        {
            int totalEmployees = 142;

            progressBarFinance.Maximum = totalEmployees;
            progressBarMarketingSales.Maximum = totalEmployees;
            progressBarResearchDev.Maximum = totalEmployees;
            progressBarOperations.Maximum = totalEmployees;

            progressBarFinance.Value = 38;
            lblFinanceCount.Text = $"38 / {totalEmployees}";

            progressBarMarketingSales.Value = 29;
            lblMarketingSalesCount.Text = $"29 / {totalEmployees}";

            progressBarResearchDev.Value = 25;
            lblResearchDevCount.Text = $"25 / {totalEmployees}";

            progressBarOperations.Value = 50;
            lblOperationsCount.Text = $"50 / {totalEmployees}";
        }

        // Mga Event Handlers (Dito nakalagay sa loob ng class)
        private void lstbxRecentActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ilagay ang logic mo rito kung meron
        }

        private void pnltotalemployee_Paint(object sender, PaintEventArgs e)
        {
            // Ilagay ang logic mo rito kung meron
        }
    }
}