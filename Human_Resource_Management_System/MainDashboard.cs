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
using infomanagement;


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
            this.Dock = DockStyle.Fill;
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

        private bool IsDashboardDataValid()
        {
            // 1. Chinecheck kung ang kabuuang bilang ng empleyado ay hindi negative or zero
            int totalEmployees = 142;
            if (totalEmployees <= 0)
            {
                MessageBox.Show("Total Employees cannot be zero or negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Chinecheck kung ang bilang ng empleyadong naka-leave ay korique
            int onLeaveToday = 8;
            if (onLeaveToday < 0 || onLeaveToday > totalEmployees)
            {
                MessageBox.Show("Number of employees on leave is invalid. It cannot be negative or more than total employees.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 3. Chinecheck kung ang bilang ng late employees ay tama
            int lateToday = 4;
            if (lateToday < 0 || lateToday > totalEmployees)
            {
                MessageBox.Show("Number of late employees is invalid. It cannot be negative or more than total employees.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 4. Chinecheck kung ang bilang ng mga pending leave request ay korique
            int pendingLeave = 12;
            if (pendingLeave < 0)
            {
                MessageBox.Show("Pending leave requests cannot be negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 5. Chinecheck kung ang bilang sa mga departments ay korique
            int financeCount = 38;
            int marketingCount = 29;
            int rndCount = 25;
            int operationsCount = 50;

            if (financeCount < 0 || marketingCount < 0 || rndCount < 0 || operationsCount < 0)
            {
                MessageBox.Show("Department headcount cannot be negative.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 6. Chinecheck kung ang kabuuang bilang ng bawat departments ay hindi lumampas sa total number of employees
            int sumOfDepartments = financeCount + marketingCount + rndCount + operationsCount;
            if (sumOfDepartments > totalEmployees)
            {
                MessageBox.Show("Total employees across departments cannot be more than overall total employees.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 7. Chineheck kung may laman ang mga recent activities na ilalagay sa listahan
            string sampleActivity = $"{DateTime.Now:yyyy-MM-dd} 08:05 | New employee record created";
            if (string.IsNullOrWhiteSpace(sampleActivity))
            {
                MessageBox.Show("Activity records cannot be empty.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void lstbxRecentActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pnltotalemployee_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void progressBarResearchDev_Click(object sender, EventArgs e)
        {

        }


        private void RefreshDashboardStats_click(object sender, EventArgs e)
        {
            DatabaseConnection db = new DatabaseConnection();


            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();


                // TOTAL EMPLOYEES
                string employeeQuery =
                "SELECT COUNT(*) FROM employee";


                MySqlCommand cmdEmployee =
                new MySqlCommand(employeeQuery, conn);


                int totalEmployees =
                Convert.ToInt32(cmdEmployee.ExecuteScalar());


                lblNumTE.Text = totalEmployees.ToString();



                // LATE TODAY
                string lateQuery =
                @"SELECT COUNT(*) 
          FROM attendance
          WHERE attendanceDate = CURDATE()
          AND clockTimeIn > '08:00:00'";


                MySqlCommand cmdLate =
                new MySqlCommand(lateQuery, conn);


                int lateToday =
                Convert.ToInt32(cmdLate.ExecuteScalar());


                lblNumLT.Text = lateToday.ToString();



                // ON LEAVE TODAY
                string leaveQuery =
                @"SELECT COUNT(*)
          FROM leaverequest
          WHERE CURDATE()
          BETWEEN startDate AND endDate
          AND status='Approved'";


                MySqlCommand cmdLeave =
                new MySqlCommand(leaveQuery, conn);


                int onLeave =
                Convert.ToInt32(cmdLeave.ExecuteScalar());


                lblNumOLT.Text = onLeave.ToString();



                // PENDING LEAVE REQUEST
                string pendingQuery =
                @"SELECT COUNT(*)
          FROM leaverequest
          WHERE status='Pending'";


                MySqlCommand cmdPending =
                new MySqlCommand(pendingQuery, conn);


                int pending =
                Convert.ToInt32(cmdPending.ExecuteScalar());


                lblNumPLR.Text = pending.ToString();


            }
        }
    }
}