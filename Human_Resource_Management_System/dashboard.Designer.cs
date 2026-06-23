namespace Human_Resource_Management_System
{
    partial class dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlStudentDetails = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtpHD = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefreshClear = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.pnlLabel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilterCourse = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlStudentList = new System.Windows.Forms.Panel();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employee_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthly_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlStudentDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLabel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlStudentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(18, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 41);
            this.panel1.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "| Employee List";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnlStudentDetails
            // 
            this.pnlStudentDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudentDetails.BackColor = System.Drawing.Color.White;
            this.pnlStudentDetails.Controls.Add(this.label1);
            this.pnlStudentDetails.Controls.Add(this.cmbStatus);
            this.pnlStudentDetails.Controls.Add(this.dtpHD);
            this.pnlStudentDetails.Controls.Add(this.txtLastName);
            this.pnlStudentDetails.Controls.Add(this.label14);
            this.pnlStudentDetails.Controls.Add(this.label13);
            this.pnlStudentDetails.Controls.Add(this.label11);
            this.pnlStudentDetails.Controls.Add(this.label10);
            this.pnlStudentDetails.Controls.Add(this.label9);
            this.pnlStudentDetails.Controls.Add(this.label8);
            this.pnlStudentDetails.Controls.Add(this.label7);
            this.pnlStudentDetails.Controls.Add(this.panel2);
            this.pnlStudentDetails.Controls.Add(this.txtPhone);
            this.pnlStudentDetails.Controls.Add(this.txtFirstName);
            this.pnlStudentDetails.Controls.Add(this.cmbDepartment);
            this.pnlStudentDetails.Controls.Add(this.txtEmail);
            this.pnlStudentDetails.Controls.Add(this.txtStudentID);
            this.pnlStudentDetails.Location = new System.Drawing.Point(17, 50);
            this.pnlStudentDetails.Name = "pnlStudentDetails";
            this.pnlStudentDetails.Size = new System.Drawing.Size(1444, 314);
            this.pnlStudentDetails.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(367, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "- Select Status-";
            // 
            // cmbStatus
            // 
            this.cmbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Leave",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(370, 267);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(286, 24);
            this.cmbStatus.TabIndex = 26;
            this.cmbStatus.Text = "- Select Status-";
            // 
            // dtpHD
            // 
            this.dtpHD.Location = new System.Drawing.Point(370, 193);
            this.dtpHD.Name = "dtpHD";
            this.dtpHD.Size = new System.Drawing.Size(286, 22);
            this.dtpHD.TabIndex = 25;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastName.ForeColor = System.Drawing.Color.DimGray;
            this.txtLastName.Location = new System.Drawing.Point(38, 125);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(281, 22);
            this.txtLastName.TabIndex = 24;
            this.txtLastName.Text = " Surname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Gray;
            this.label14.Location = new System.Drawing.Point(35, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "PHONE NUMBER";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(372, 164);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "HIRE DATE";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Gray;
            this.label11.Location = new System.Drawing.Point(367, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "First Name";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(35, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "EMAIL ADDRESS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(367, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "DEPARTMENT";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(35, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(35, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "EMPLOYEE ID";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnRefreshClear);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(717, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 268);
            this.panel2.TabIndex = 8;
            // 
            // btnRefreshClear
            // 
            this.btnRefreshClear.BackColor = System.Drawing.Color.DimGray;
            this.btnRefreshClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshClear.ForeColor = System.Drawing.Color.White;
            this.btnRefreshClear.Location = new System.Drawing.Point(18, 221);
            this.btnRefreshClear.Name = "btnRefreshClear";
            this.btnRefreshClear.Size = new System.Drawing.Size(203, 38);
            this.btnRefreshClear.TabIndex = 4;
            this.btnRefreshClear.Text = "Refresh / Clear";
            this.btnRefreshClear.UseVisualStyleBackColor = false;
            this.btnRefreshClear.Click += new System.EventHandler(this.btnRefreshClear_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Brown;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(18, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(18, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(18, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(203, 38);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "ACTIONS";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.ForeColor = System.Drawing.Color.DimGray;
            this.txtPhone.Location = new System.Drawing.Point(38, 269);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(281, 22);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "  09XX-XXX-XXXX";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.txtFirstName.Location = new System.Drawing.Point(370, 48);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(286, 22);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "First Name";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.ForeColor = System.Drawing.Color.DimGray;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Finance Dpt.",
            "Marketing/Sales Dpt",
            "Research and Development Dept",
            "Operations Dept"});
            this.cmbDepartment.Location = new System.Drawing.Point(370, 123);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(286, 24);
            this.cmbDepartment.TabIndex = 3;
            this.cmbDepartment.Text = "   - Select Department -";
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(38, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 22);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "ex. juandelacruz@email.com";
            // 
            // txtStudentID
            // 
            this.txtStudentID.ForeColor = System.Drawing.Color.DimGray;
            this.txtStudentID.Location = new System.Drawing.Point(38, 50);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(281, 22);
            this.txtStudentID.TabIndex = 0;
            this.txtStudentID.Text = "ex. XXXXX";
            // 
            // pnlLabel1
            // 
            this.pnlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLabel1.BackColor = System.Drawing.Color.Teal;
            this.pnlLabel1.Controls.Add(this.label3);
            this.pnlLabel1.Location = new System.Drawing.Point(3, 3);
            this.pnlLabel1.Name = "pnlLabel1";
            this.pnlLabel1.Size = new System.Drawing.Size(1467, 41);
            this.pnlLabel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "| Employee Details";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbFilterCourse
            // 
            this.cmbFilterCourse.BackColor = System.Drawing.Color.White;
            this.cmbFilterCourse.DropDownWidth = 400;
            this.cmbFilterCourse.ForeColor = System.Drawing.Color.DimGray;
            this.cmbFilterCourse.FormattingEnabled = true;
            this.cmbFilterCourse.Items.AddRange(new object[] {
            "Bachelor of Science in Accountancy (BSA)",
            "Bachelor of Science in Computer Engineering (BSCpE)",
            "Bachelor of Science in Entrepreneurship (BSEntrep)",
            "Bachelor of Science in Hospitality Management (BSHM)",
            "Bachelor of Science in Information Technology (BSIT)",
            "Bachelor of Secondary Education Major in English (BSEDEN)",
            "Bachelor of Secondary Education Major in Math (BSEDMT)",
            "Diploma in Office Management Technology (DOMT)"});
            this.cmbFilterCourse.Location = new System.Drawing.Point(434, 11);
            this.cmbFilterCourse.Name = "cmbFilterCourse";
            this.cmbFilterCourse.Size = new System.Drawing.Size(266, 24);
            this.cmbFilterCourse.TabIndex = 1;
            this.cmbFilterCourse.Text = "All Department";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(15, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(413, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search Name";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(17, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1444, 0);
            this.panel3.TabIndex = 12;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(13, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(165, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "| Employee Information";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 2;
            // 
            // pnlStudentList
            // 
            this.pnlStudentList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStudentList.BackColor = System.Drawing.Color.White;
            this.pnlStudentList.Controls.Add(this.cmbFilterCourse);
            this.pnlStudentList.Controls.Add(this.txtSearch);
            this.pnlStudentList.Location = new System.Drawing.Point(18, 435);
            this.pnlStudentList.Name = "pnlStudentList";
            this.pnlStudentList.Size = new System.Drawing.Size(1444, 53);
            this.pnlStudentList.TabIndex = 11;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.ColumnHeadersHeight = 29;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employee_id,
            this.first_name,
            this.phone,
            this.email,
            this.hire_date,
            this.status,
            this.reg_date,
            this.monthly_salary});
            this.dgvEmployee.Location = new System.Drawing.Point(19, 558);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEmployee.Size = new System.Drawing.Size(1443, 142);
            this.dgvEmployee.TabIndex = 7;
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // employee_id
            // 
            this.employee_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.employee_id.DataPropertyName = "EMPLOYEE ID";
            this.employee_id.HeaderText = "EMPLOYEE ID";
            this.employee_id.MinimumWidth = 6;
            this.employee_id.Name = "employee_id";
            this.employee_id.Width = 125;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.DataPropertyName = "FIRST NAME";
            this.first_name.HeaderText = "FIRST NAME";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "Phone Number";
            this.phone.HeaderText = "PHONE";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "EMAIL";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            // 
            // hire_date
            // 
            this.hire_date.DataPropertyName = "HIRE DATE";
            this.hire_date.HeaderText = "HIRE DATE";
            this.hire_date.MinimumWidth = 6;
            this.hire_date.Name = "hire_date";
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "STATUS";
            this.status.HeaderText = "STATUS";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.Width = 91;
            // 
            // reg_date
            // 
            this.reg_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reg_date.DataPropertyName = "Regularization Date";
            this.reg_date.HeaderText = "REGULARIZATION DATE";
            this.reg_date.MinimumWidth = 6;
            this.reg_date.Name = "reg_date";
            // 
            // monthly_salary
            // 
            this.monthly_salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monthly_salary.DataPropertyName = "MonthlySalary";
            this.monthly_salary.HeaderText = "MONTHLY SALARY";
            this.monthly_salary.MinimumWidth = 6;
            this.monthly_salary.Name = "monthly_salary";
            this.monthly_salary.Width = 158;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(17, 511);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1444, 41);
            this.panel4.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "| Employees";
            // 
            // dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlStudentDetails);
            this.Controls.Add(this.pnlLabel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlStudentList);
            this.Controls.Add(this.dgvEmployee);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "dashboard";
            this.Size = new System.Drawing.Size(1502, 848);
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlStudentDetails.ResumeLayout(false);
            this.pnlStudentDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLabel1.ResumeLayout(false);
            this.pnlLabel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlStudentList.ResumeLayout(false);
            this.pnlStudentList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlStudentDetails;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshClear;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Panel pnlLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilterCourse;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlStudentList;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.DateTimePicker dtpHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn employee_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn hire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthly_salary;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}
