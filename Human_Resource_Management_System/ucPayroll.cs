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
    public partial class ucPayroll : UserControl
    {
        public ucPayroll()
        {
            InitializeComponent();

            txtSearch.Text = "Enter employee name or ID...";
            txtSearch.ForeColor = Color.Gray;

            cboEmployee.Items.Add("- Select Employee -");
            cboEmployee.SelectedIndex = 0;
            cboEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Validation Functions

        private bool IsInputValid()
        {
            // validate employee selection
            if (cboEmployee.SelectedIndex == 0)
            {
                MessageBox.Show("Please select an employee.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEmployee.Focus();
                return false;
            }

            // validate gross pay
            decimal grossPay;

            if (string.IsNullOrWhiteSpace(txtGrossPay.Text))
            {
                MessageBox.Show("Please enter the Gross Pay.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrossPay.Focus();
                return false;
                
            }

            if (!decimal.TryParse(txtGrossPay.Text, out grossPay))
            {
                MessageBox.Show("Gross Pay must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrossPay.Focus();
                return false;
            }

            if (grossPay <= 0)
            {
                MessageBox.Show("Gross Pay must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGrossPay.Focus();
                return false;
            }

            // validate deductions
            decimal deductions;

            if (string.IsNullOrWhiteSpace(txtDeductions.Text))
            {
                MessageBox.Show("Please enter the Deductions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeductions.Focus();
                return false;
            }

            if (!decimal.TryParse(txtDeductions.Text, out deductions))
            {
                MessageBox.Show("Deductions must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeductions.Focus();
                return false;
            }

            if (deductions < 0)
            {
                MessageBox.Show("Deductions cannot be negative.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDeductions.Focus();
                return false;
            }

            // validate pay period
            if (dtpEnd.Value.Date < dtpStart.Value.Date)
            {
                MessageBox.Show("End Date cannot be earlier than Start Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpEnd.Focus();
                return false;
            }

            // validate payment date
            if (dtpPaymentDate.Value.Date < dtpEnd.Value.Date)
            {
                MessageBox.Show("Payment Date cannot be earlier than End Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpPaymentDate.Focus();
                return false;
            }

            return true;
        }

        private void ComputeNetPay()
        {
            decimal grossPay = 0;
            decimal deductions = 0;

            decimal.TryParse(txtGrossPay.Text, out grossPay);
            decimal.TryParse(txtDeductions.Text, out deductions);

            decimal netPay = grossPay - deductions;

            if (netPay < 0)
            {
                netPay = 0;
            }

            txtNetPay.Text = netPay.ToString("N2");
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!IsInputValid())
                return;

            MessageBox.Show("Payroll information has been successfully validated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtGrossPay.Clear();
            txtDeductions.Clear();
            txtNetPay.Clear();

            cboEmployee.SelectedIndex = 0;

            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            dtpPaymentDate.Value = DateTime.Today;

            txtSearch.Text = "Enter employee name or ID...";
            txtSearch.ForeColor = Color.Gray;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dvgPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payroll record first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsInputValid())
                return;

            MessageBox.Show("Payroll information has been successfully validated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtGrossPay_TextChanged(object sender, EventArgs e)
        {
            ComputeNetPay();
        }

        private void txtGrossPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digits, control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // prevent multiple decimal points
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtDeductions_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digits, control keys
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // prevent multiple decimal points
            if (e.KeyChar == '.' && ((TextBox)sender).Text.Contains("."))
            {
                e.Handled = true;
            }

        }

        private void txtDeductions_TextChanged(object sender, EventArgs e)
        {
            ComputeNetPay();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dvgPayroll.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a payroll record first.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this payroll record?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Payroll record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text == "Enter employee name or ID...")
            {
                MessageBox.Show("Please enter an employee name or employee ID .", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSearch.Focus();
                return;
            }

            MessageBox.Show("Search validation passed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
