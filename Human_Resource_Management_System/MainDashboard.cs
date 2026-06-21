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
        lblNumTE.Text = "142";     // Total Employees
        lblNumLT.Text = "8";       // Late Today
        lblNumOLT.Text = "4";      // On Leave Today
        lblNumPLR.Text = "12";     // Pending Leave Request
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
        
        int totalEmployees;
        if (!int.TryParse(lblNumTE.Text, out totalEmployees) || totalEmployees <= 0)
        {
            totalEmployees = 142; // Fallback value if label is empty/invalid
        }

        progressBarFinance.Maximum = totalEmployees;
        progressBarMarketingSales.Maximum = totalEmployees;
        progressBarResearchDev.Maximum = totalEmployees;
        progressBarOperations.Maximum = totalEmployees;

        int financeCount = 38;
        progressBarFinance.Value = financeCount;
        lblFinanceCount.Text = $"{financeCount} / {totalEmployees}";

        int marketingCount = 29;
        progressBarMarketingSales.Value = marketingCount;
        lblMarketingSalesCount.Text = $"{marketingCount} / {totalEmployees}";

        int rndCount = 25;
        progressBarResearchDev.Value = rndCount;
        lblResearchDevCount.Text = $"{rndCount} / {totalEmployees}";

        int operationsCount = 50;
        progressBarOperations.Value = operationsCount;
        lblOperationsCount.Text = $"{operationsCount} / {totalEmployees}";
        }

        private void lstbxRecentActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void pnltotalemployee_Paint(object sender, PaintEventArgs e)
        {
        
        }
    }
}