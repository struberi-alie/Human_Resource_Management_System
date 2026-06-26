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
    public partial class ucLeaveRequestUD : UserControl
    {
        public ucLeaveRequestUD()
        {
            InitializeComponent();

            txtSearch.Text = "Enter employee name or ID...";
            txtSearch.ForeColor = Color.Gray;

            cboEmployee.Items.Add("- Select Employee -");
            cboEmployee.Items.Add("EMP-0001 - Juan Dela Cruz");
            cboEmployee.Items.Add("EMP-0002 - Maria Santos");
            cboEmployee.SelectedIndex = 0;


            cboLeaveType.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboApprovedBy.SelectedIndex = 0;
        }

        private bool IsInputValid()
        {
            // validate employee
            if (cboEmployee.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEmployee.Focus();
                return false;
            }

            // validate leave type
            if (cboLeaveType.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a leave type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLeaveType.Focus();
                return false;
            }

            // validate status
            if (cboStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select the leave status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboStatus.Focus();
                return false;
            }

            // validate approver
            if (cboApprovedBy.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an approver.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboApprovedBy.Focus();
                return false;
            }

            // validate reason
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Please enter the reason for the leave request.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReason.Focus();
                return false;
            }

            if (txtReason.Text.Trim().Length < 5)
            {
                MessageBox.Show("Reason must contain at least 5 characters long.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtReason.Focus();
                return false;
            }

            if (dtpEndDate.Value.Date < dtpStartDate.Value.Date)
            {
                MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEndDate.Focus();
                return false;
            }

            if (dtpStartDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Start Date cannot be earlier than today's date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpStartDate.Focus();
                return false;
            }
            return true;
        }

        private void ucPayrollUD_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter employee name or ID...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Enter employee name or ID...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Enter employee name or ID...")
            {
                MessageBox.Show("Please enter an employee name or ID to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            MessageBox.Show("Search validation passed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            MessageBox.Show("Leave request has been successfully validated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtReason.Clear();

            cboEmployee.SelectedIndex = 0;
            cboLeaveType.SelectedIndex = 0;
            cboStatus.SelectedIndex = 0;
            cboApprovedBy.SelectedIndex = 0;

            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Today;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsInputValid())
                return;

            MessageBox.Show("Leave request has been successfully validated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLeaveRequests.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a leave request to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this leave request?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Leave request deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
