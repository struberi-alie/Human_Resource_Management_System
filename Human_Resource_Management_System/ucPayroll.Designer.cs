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
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll Management";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Manage and process employee payroll records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Search Employee";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(20, 130);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 25);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Text = "Enter employee name or ID";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Teal;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(339, 125);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlPayrollHeader
            // 
            this.pnlPayrollHeader.BackColor = System.Drawing.Color.Teal;
            this.pnlPayrollHeader.Controls.Add(this.label4);
            this.pnlPayrollHeader.Location = new System.Drawing.Point(20, 190);
            this.pnlPayrollHeader.Name = "pnlPayrollHeader";
            this.pnlPayrollHeader.Size = new System.Drawing.Size(650, 45);
            this.pnlPayrollHeader.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 21);
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
            this.dvgPayroll.Location = new System.Drawing.Point(20, 251);
            this.dvgPayroll.Name = "dvgPayroll";
            this.dvgPayroll.ReadOnly = true;
            this.dvgPayroll.RowHeadersVisible = false;
            this.dvgPayroll.RowHeadersWidth = 51;
            this.dvgPayroll.Size = new System.Drawing.Size(650, 350);
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
            this.pnlPayrollDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlPayrollDetails.Location = new System.Drawing.Point(732, 110);
            this.pnlPayrollDetails.Name = "pnlPayrollDetails";
            this.pnlPayrollDetails.Size = new System.Drawing.Size(320, 549);
            this.pnlPayrollDetails.TabIndex = 7;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(15, 500);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(280, 20);
            this.dtpPaymentDate.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(15, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Payment Date";
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(15, 440);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(280, 20);
            this.txtNetPay.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Net Pay";
            // 
            // txtDeductions
            // 
            this.txtDeductions.Location = new System.Drawing.Point(15, 380);
            this.txtDeductions.Name = "txtDeductions";
            this.txtDeductions.Size = new System.Drawing.Size(280, 20);
            this.txtDeductions.TabIndex = 12;
            this.txtDeductions.TextChanged += new System.EventHandler(this.txtDeductions_TextChanged);
            this.txtDeductions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeductions_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Deductions";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(15, 320);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.Size = new System.Drawing.Size(280, 20);
            this.txtGrossPay.TabIndex = 10;
            this.txtGrossPay.TextChanged += new System.EventHandler(this.txtGrossPay_TextChanged);
            this.txtGrossPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrossPay_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Gross Pay";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(15, 260);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(280, 20);
            this.dtpEnd.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 240);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Pay Period End";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(15, 200);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(280, 20);
            this.dtpStart.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Pay Period Start";
            // 
            // cboEmployee
            // 
            this.cboEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployee.FormattingEnabled = true;
            this.cboEmployee.Location = new System.Drawing.Point(15, 140);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Size = new System.Drawing.Size(280, 21);
            this.cboEmployee.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Employee";
            // 
            // txtPayrollID
            // 
            this.txtPayrollID.Location = new System.Drawing.Point(15, 80);
            this.txtPayrollID.Name = "txtPayrollID";
            this.txtPayrollID.ReadOnly = true;
            this.txtPayrollID.Size = new System.Drawing.Size(280, 20);
            this.txtPayrollID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Payroll ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Payroll Details";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Teal;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(20, 639);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(180, 45);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Payroll";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(219, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Payroll";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(420, 639);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 45);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Payroll";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ucPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.Name = "ucPayroll";
            this.Size = new System.Drawing.Size(1126, 689);
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
