namespace Human_Resource_Management_System
{
    partial class ucLeaveRequest
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
            this.components = new System.ComponentModel.Container();
            this.dgvLeaveRequests = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnPending = new System.Windows.Forms.Button();
            this.btnApproved = new System.Windows.Forms.Button();
            this.btnRejected = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblLeaveType = new System.Windows.Forms.Label();
            this.lblPlaceHolder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLeaveRequests
            // 
            this.dgvLeaveRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLeaveRequests.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvLeaveRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaveRequests.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvLeaveRequests.Location = new System.Drawing.Point(30, 156);
            this.dgvLeaveRequests.Name = "dgvLeaveRequests";
            this.dgvLeaveRequests.RowHeadersWidth = 51;
            this.dgvLeaveRequests.RowTemplate.Height = 24;
            this.dgvLeaveRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeaveRequests.Size = new System.Drawing.Size(1085, 469);
            this.dgvLeaveRequests.TabIndex = 0;
            this.dgvLeaveRequests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeaveRequests_CellContentClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAll);
            this.flowLayoutPanel1.Controls.Add(this.btnPending);
            this.flowLayoutPanel1.Controls.Add(this.btnApproved);
            this.flowLayoutPanel1.Controls.Add(this.btnRejected);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(656, 50);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(3, 3);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(134, 47);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // btnPending
            // 
            this.btnPending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPending.Location = new System.Drawing.Point(143, 3);
            this.btnPending.Name = "btnPending";
            this.btnPending.Size = new System.Drawing.Size(136, 47);
            this.btnPending.TabIndex = 3;
            this.btnPending.Text = "Pending";
            this.btnPending.UseVisualStyleBackColor = true;
            // 
            // btnApproved
            // 
            this.btnApproved.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproved.Location = new System.Drawing.Point(285, 3);
            this.btnApproved.Name = "btnApproved";
            this.btnApproved.Size = new System.Drawing.Size(142, 47);
            this.btnApproved.TabIndex = 4;
            this.btnApproved.Text = "Approved";
            this.btnApproved.UseVisualStyleBackColor = true;
            // 
            // btnRejected
            // 
            this.btnRejected.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejected.Location = new System.Drawing.Point(433, 3);
            this.btnRejected.Name = "btnRejected";
            this.btnRejected.Size = new System.Drawing.Size(152, 47);
            this.btnRejected.TabIndex = 5;
            this.btnRejected.Text = "Rejected";
            this.btnRejected.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(6, 21);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(582, 37);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search Employee";
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPlaceHolder);
            this.panel1.Controls.Add(this.lblLeaveType);
            this.panel1.Controls.Add(this.lblEmployeeName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1140, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 1064);
            this.panel1.TabIndex = 4;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.Location = new System.Drawing.Point(32, 156);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(155, 31);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Click += new System.EventHandler(this.lblEmployeeName_Click);
            // 
            // lblLeaveType
            // 
            this.lblLeaveType.Location = new System.Drawing.Point(32, 213);
            this.lblLeaveType.Name = "lblLeaveType";
            this.lblLeaveType.Size = new System.Drawing.Size(155, 31);
            this.lblLeaveType.TabIndex = 1;
            // 
            // lblPlaceHolder
            // 
            this.lblPlaceHolder.Location = new System.Drawing.Point(30, 253);
            this.lblPlaceHolder.Name = "lblPlaceHolder";
            this.lblPlaceHolder.Size = new System.Drawing.Size(155, 31);
            this.lblPlaceHolder.TabIndex = 2;
            // 
            // ucLeaveRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dgvLeaveRequests);
            this.Name = "ucLeaveRequest";
            this.Size = new System.Drawing.Size(1400, 1064);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaveRequests)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaveRequests;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnPending;
        private System.Windows.Forms.Button btnApproved;
        private System.Windows.Forms.Button btnRejected;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLeaveType;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblPlaceHolder;
    }
}
