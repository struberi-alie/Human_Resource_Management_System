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
            this.SuspendLayout();
            // 
            // frmMainForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLeaveRequests;
        private System.Windows.Forms.Button btnPayroll;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
    }
}

