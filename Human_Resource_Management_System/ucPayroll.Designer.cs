namespace Human_Resource_Management_System
{
    partial class ucPayroll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlPayrollHeader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgPayroll = new System.Windows.Forms.DataGridView();
            this.PayrollID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayPeriodStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayPeriodEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deductions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlPayrollDetails = new System.Windows.Forms.Panel();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDeductions = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboEmployee = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPayrollID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlPayrollHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPayroll)).BeginInit();
            this.pnlPayrollDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(32, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(364, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage and process employee payroll records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Employee";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(27, 160);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(399, 29);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Enter employee name or ID";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(452, 154);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(133, 43);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // pnlPayrollHeader
            // 
            this.pnlPayrollHeader.BackColor = System.Drawing.Color.Teal;
            this.pnlPayrollHeader.Controls.Add(this.label4);
            this.pnlPayrollHeader.Location = new System.Drawing.Point(27, 234);
            this.pnlPayrollHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPayrollHeader.Name = "pnlPayrollHeader";
            this.pnlPayrollHeader.Size = new System.Drawing.Size(867, 55);
            this.pnlPayrollHeader.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Payroll Records";
            // 
            // dvgPayroll
            // 
            this.dvgPayroll.AllowUserToAddRows = false;
            this.dvgPayroll.AllowUserToDeleteRows = false;
            this.dvgPayroll.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgPayroll.BackgroundColor = System.Drawing.Color.White;
            this.dvgPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PayrollID,
            this.EmployeeID,
            this.EmployeeName,
            this.PayPeriodStart,
            this.PayPeriodEnd,
            this.GrossPay,
            this.Deductions,
            this.NetPay,
            this.PaymentDate});
            this.dvgPayroll.Location = new System.Drawing.Point(27, 309);
            this.dvgPayroll.Margin = new System.Windows.Forms.Padding(4);
            this.dvgPayroll.Name = "dvgPayroll";
            this.dvgPayroll.ReadOnly = true;
            this.dvgPayroll.RowHeadersVisible = false;
            this.dvgPayroll.RowHeadersWidth = 51;
            this.dvgPayroll.Size = new System.Drawing.Size(867, 431);
            this.dvgPayroll.TabIndex = 6;
            // 
            // PayrollID
            // 
            this.PayrollID.HeaderText = "Payroll ID";
            this.PayrollID.MinimumWidth = 6;
            this.PayrollID.Name = "PayrollID";
            this.PayrollID.ReadOnly = true;
            // 
            // EmployeeID
            // 
            this.EmployeeID.HeaderText = "Employee ID";
            this.EmployeeID.MinimumWidth = 6;
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // PayPeriodStart
            // 
            this.PayPeriodStart.HeaderText = "Pay Period Start";
            this.PayPeriodStart.MinimumWidth = 6;
            this.PayPeriodStart.Name = "PayPeriodStart";
            this.PayPeriodStart.ReadOnly = true;
            // 
            // PayPeriodEnd
            // 
            this.PayPeriodEnd.HeaderText = "Pay Period End";
            this.PayPeriodEnd.MinimumWidth = 6;
            this.PayPeriodEnd.Name = "PayPeriodEnd";
            this.PayPeriodEnd.ReadOnly = true;
            // 
            // GrossPay
            // 
            this.GrossPay.HeaderText = "Gross Pay";
            this.GrossPay.MinimumWidth = 6;
            this.GrossPay.Name = "GrossPay";
            this.GrossPay.ReadOnly = true;
            // 
            // Deductions
            // 
            this.Deductions.HeaderText = "Deductions";
            this.Deductions.MinimumWidth = 6;
            this.Deductions.Name = "Deductions";
            this.Deductions.ReadOnly = true;
            // 
            // NetPay
            // 
            this.NetPay.HeaderText = "Net Pay";
            this.NetPay.MinimumWidth = 6;
            this.NetPay.Name = "NetPay";
            this.NetPay.ReadOnly = true;
            // 
            // PaymentDate
            // 
            this.PaymentDate.HeaderText = "Payment Date";
            this.PaymentDate.MinimumWidth = 6;
            this.PaymentDate.Name = "PaymentDate";
            this.PaymentDate.ReadOnly = true;
            // 
            // pnlPayrollDetails
            // 
            this.pnlPayrollDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPayrollDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPayrollDetails.Controls.Add(this.dtpPaymentDate);
            this.pnlPayrollDetails.Controls.Add(this.label13);
            this.pnlPayrollDetails.Controls.Add(this.txtNetPay);
            this.pnlPayrollDetails.Controls.Add(this.label12);
            this.pnlPayrollDetails.Controls.Add(this.txtDeductions);
            this.pnlPayrollDetails.Controls.Add(this.label11);
            this.pnlPayrollDetails.Controls.Add(this.txtGrossPay);
            this.pnlPayrollDetails.Controls.Add(this.label10);
            this.pnlPayrollDetails.Controls.Add(this.dtpEnd);
            this.pnlPayrollDetails.Controls.Add(this.label9);
            this.pnlPayrollDetails.Controls.Add(this.dtpStart);
            this.pnlPayrollDetails.Controls.Add(this.label8);
            this.pnlPayrollDetails.Controls.Add(this.cboEmployee);
            this.pnlPayrollDetails.Controls.Add(this.label7);
            this.pnlPayrollDetails.Controls.Add(this.txtPayrollID);
            this.pnlPayrollDetails.Controls.Add(this.label6);
            this.pnlPayrollDetails.Controls.Add(this.label5);
            this.pnlPayrollDetails.Location = new System.Drawing.Point(926, 135);
            this.pnlPayrollDetails.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPayrollDetails.Name = "pnlPayrollDetails";
            this.pnlPayrollDetails.Size = new System.Drawing.Size(426, 675);
            this.pnlPayrollDetails.TabIndex = 7;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(20, 615);
            this.dtpPaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(372, 22);
            this.dtpPaymentDate.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 591);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Payment Date";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(20, 542);
            this.txtNetPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(372, 22);
            this.txtNetPay.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 517);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Net Pay";
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(20, 468);
            this.txtDeductions.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(372, 22);
            this.txtDeductions.TabIndex = 12;
            this.txtDeductions.Text = "Enter deductions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 443);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Deductions";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(20, 394);
            this.txtGrossPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(372, 22);
            this.txtGrossPay.TabIndex = 10;
            this.txtGrossPay.Text = "Enter gross pay";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 369);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gross Pay";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(20, 320);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(372, 22);
            this.dtpEnd.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 295);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pay Period End";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(20, 246);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(372, 22);
            this.dtpStart.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 222);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pay Period Start";
            // 
            // cboEmployee
            // 
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(20, 172);
            this.cboEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(372, 24);
            this.cboEmployee.TabIndex = 4;
            this.cboEmployee.Text = "- Select Employee -";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Employee";
            // 
            // txtPayrollID
            // 
            this.txtPayrollID.Location = new System.Drawing.Point(20, 98);
            this.txtPayrollID.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayrollID.Name = "txtPayrollID";
            this.txtPayrollID.ReadOnly = true;
            this.txtPayrollID.Size = new System.Drawing.Size(372, 22);
            this.txtPayrollID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 74);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Payroll ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payroll Details";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Teal;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(27, 786);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(240, 55);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Payroll";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(292, 786);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(240, 55);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Payroll";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(560, 786);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 55);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Payroll";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // ucPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.pnlPayrollDetails);
            this.Controls.Add(this.dvgPayroll);
            this.Controls.Add(this.pnlPayrollHeader);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucPayroll";
            this.Size = new System.Drawing.Size(1502, 848);
            this.pnlPayrollHeader.ResumeLayout(false);
            this.pnlPayrollHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPayroll)).EndInit();
            this.pnlPayrollDetails.ResumeLayout(false);
            this.pnlPayrollDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlPayrollHeader;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayrollID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayPeriodStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayPeriodEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deductions;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentDate;
        private System.Windows.Forms.Panel pnlPayrollDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPayrollID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboEmployee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDeductions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
