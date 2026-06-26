namespace Human_Resource_Management_System
{
    partial class frmMainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.panelSideBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonLRequest = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.buttonDepartment = new System.Windows.Forms.Button();
            this.panelSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideBar
            // 
            this.panelSideBar.BackColor = System.Drawing.Color.Teal;
            this.panelSideBar.Controls.Add(this.buttonDepartment);
            this.panelSideBar.Controls.Add(this.buttonPayroll);
            this.panelSideBar.Controls.Add(this.buttonLRequest);
            this.panelSideBar.Controls.Add(this.buttonAttendance);
            this.panelSideBar.Controls.Add(this.buttonEmployee);
            this.panelSideBar.Controls.Add(this.buttonDashboard);
            this.panelSideBar.Controls.Add(this.panel2);
            this.panelSideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSideBar.Name = "panelSideBar";
            this.panelSideBar.Size = new System.Drawing.Size(368, 1039);
            this.panelSideBar.TabIndex = 0;
            this.panelSideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSideBar_Paint_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(374, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 1036);
            this.panel2.TabIndex = 0;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Location = new System.Drawing.Point(377, 3);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1509, 1021);
            this.panelMainContainer.TabIndex = 1;
            this.panelMainContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainContainer_Paint_1);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDashboard.Location = new System.Drawing.Point(0, 92);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(365, 87);
            this.buttonDashboard.TabIndex = 2;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.FlatAppearance.BorderSize = 0;
            this.buttonEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployee.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmployee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEmployee.Location = new System.Drawing.Point(0, 354);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(365, 87);
            this.buttonEmployee.TabIndex = 3;
            this.buttonEmployee.Text = "Employee";
            this.buttonEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAttendance.Location = new System.Drawing.Point(0, 179);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(365, 87);
            this.buttonAttendance.TabIndex = 4;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonLRequest
            // 
            this.buttonLRequest.FlatAppearance.BorderSize = 0;
            this.buttonLRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLRequest.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLRequest.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLRequest.Location = new System.Drawing.Point(0, 442);
            this.buttonLRequest.Name = "buttonLRequest";
            this.buttonLRequest.Size = new System.Drawing.Size(365, 87);
            this.buttonLRequest.TabIndex = 5;
            this.buttonLRequest.Text = "Leave Request";
            this.buttonLRequest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLRequest.UseVisualStyleBackColor = true;
            this.buttonLRequest.Click += new System.EventHandler(this.buttonLRequest_Click);
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.FlatAppearance.BorderSize = 0;
            this.buttonPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayroll.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPayroll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPayroll.Location = new System.Drawing.Point(0, 528);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(365, 87);
            this.buttonPayroll.TabIndex = 6;
            this.buttonPayroll.Text = "Payroll";
            this.buttonPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.buttonPayroll_Click);
            // 
            // buttonDepartment
            // 
            this.buttonDepartment.FlatAppearance.BorderSize = 0;
            this.buttonDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartment.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDepartment.Location = new System.Drawing.Point(0, 267);
            this.buttonDepartment.Name = "buttonDepartment";
            this.buttonDepartment.Size = new System.Drawing.Size(365, 87);
            this.buttonDepartment.TabIndex = 7;
            this.buttonDepartment.Text = "Department";
            this.buttonDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDepartment.UseVisualStyleBackColor = true;
            this.buttonDepartment.Click += new System.EventHandler(this.buttonDepartment_Click);
            // 
            // frmMainForm
            // 
            this.ClientSize = new System.Drawing.Size(1898, 1029);
            this.Controls.Add(this.panelMainContainer);
            this.Controls.Add(this.panelSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMainForm";
            this.Text = "HRMS";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.panelSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonDepartment;
        private System.Windows.Forms.Button buttonPayroll;
        private System.Windows.Forms.Button buttonLRequest;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonEmployee;
    }
}

