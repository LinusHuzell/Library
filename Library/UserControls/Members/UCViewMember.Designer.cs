namespace Library.UserControls.Members
{
    partial class UCViewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCViewMember));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMemberInformation = new System.Windows.Forms.Panel();
            this.txtTotalDebt = new System.Windows.Forms.TextBox();
            this.lblTotalDebt = new System.Windows.Forms.Label();
            this.txtPersonalID = new System.Windows.Forms.TextBox();
            this.txtRegistered = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblRegistered = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPersonalID = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLoans = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lvLoans = new System.Windows.Forms.ListView();
            this.chBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLoanDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEditMember = new System.Windows.Forms.Button();
            this.pnlLoanInformation = new System.Windows.Forms.Panel();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.lblDebt = new System.Windows.Forms.Label();
            this.txtOverdue = new System.Windows.Forms.TextBox();
            this.lblOnTime = new System.Windows.Forms.Label();
            this.txtOnTime = new System.Windows.Forms.TextBox();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.txtTimeOfReturn = new System.Windows.Forms.TextBox();
            this.lblTimeOfReturn = new System.Windows.Forms.Label();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtDateOfLoan = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblDateOfLoan = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMemberInformation.SuspendLayout();
            this.pnlLoanInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(820, 54);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "View Member";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemberInformation
            // 
            this.pnlMemberInformation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMemberInformation.Controls.Add(this.txtTotalDebt);
            this.pnlMemberInformation.Controls.Add(this.lblTotalDebt);
            this.pnlMemberInformation.Controls.Add(this.txtPersonalID);
            this.pnlMemberInformation.Controls.Add(this.txtRegistered);
            this.pnlMemberInformation.Controls.Add(this.txtUsername);
            this.pnlMemberInformation.Controls.Add(this.lblRegistered);
            this.pnlMemberInformation.Controls.Add(this.lblUsername);
            this.pnlMemberInformation.Controls.Add(this.lblLastName);
            this.pnlMemberInformation.Controls.Add(this.lblPersonalID);
            this.pnlMemberInformation.Controls.Add(this.lblFirstname);
            this.pnlMemberInformation.Controls.Add(this.txtFirstname);
            this.pnlMemberInformation.Controls.Add(this.txtLastName);
            this.pnlMemberInformation.Location = new System.Drawing.Point(88, 72);
            this.pnlMemberInformation.Name = "pnlMemberInformation";
            this.pnlMemberInformation.Size = new System.Drawing.Size(703, 143);
            this.pnlMemberInformation.TabIndex = 30;
            // 
            // txtTotalDebt
            // 
            this.txtTotalDebt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTotalDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalDebt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDebt.Location = new System.Drawing.Point(460, 104);
            this.txtTotalDebt.Name = "txtTotalDebt";
            this.txtTotalDebt.ReadOnly = true;
            this.txtTotalDebt.Size = new System.Drawing.Size(181, 20);
            this.txtTotalDebt.TabIndex = 36;
            // 
            // lblTotalDebt
            // 
            this.lblTotalDebt.AutoSize = true;
            this.lblTotalDebt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDebt.Location = new System.Drawing.Point(327, 103);
            this.lblTotalDebt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblTotalDebt.Name = "lblTotalDebt";
            this.lblTotalDebt.Size = new System.Drawing.Size(93, 21);
            this.lblTotalDebt.TabIndex = 35;
            this.lblTotalDebt.Text = "Total Debt:";
            // 
            // txtPersonalID
            // 
            this.txtPersonalID.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtPersonalID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonalID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalID.Location = new System.Drawing.Point(460, 59);
            this.txtPersonalID.Name = "txtPersonalID";
            this.txtPersonalID.ReadOnly = true;
            this.txtPersonalID.Size = new System.Drawing.Size(181, 20);
            this.txtPersonalID.TabIndex = 34;
            // 
            // txtRegistered
            // 
            this.txtRegistered.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtRegistered.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegistered.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegistered.Location = new System.Drawing.Point(140, 104);
            this.txtRegistered.Name = "txtRegistered";
            this.txtRegistered.ReadOnly = true;
            this.txtRegistered.Size = new System.Drawing.Size(181, 20);
            this.txtRegistered.TabIndex = 33;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(140, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(181, 20);
            this.txtUsername.TabIndex = 32;
            // 
            // lblRegistered
            // 
            this.lblRegistered.AutoSize = true;
            this.lblRegistered.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistered.Location = new System.Drawing.Point(7, 103);
            this.lblRegistered.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblRegistered.Name = "lblRegistered";
            this.lblRegistered.Size = new System.Drawing.Size(123, 21);
            this.lblRegistered.TabIndex = 31;
            this.lblRegistered.Text = "Member Since:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(7, 59);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(327, 16);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(94, 21);
            this.lblLastName.TabIndex = 29;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblPersonalID
            // 
            this.lblPersonalID.AutoSize = true;
            this.lblPersonalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalID.Location = new System.Drawing.Point(327, 59);
            this.lblPersonalID.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblPersonalID.Name = "lblPersonalID";
            this.lblPersonalID.Size = new System.Drawing.Size(101, 21);
            this.lblPersonalID.TabIndex = 28;
            this.lblPersonalID.Text = "Personal ID:";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(7, 15);
            this.lblFirstname.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(96, 21);
            this.lblFirstname.TabIndex = 25;
            this.lblFirstname.Text = "First Name:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.Location = new System.Drawing.Point(140, 16);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.ReadOnly = true;
            this.txtFirstname.Size = new System.Drawing.Size(181, 20);
            this.txtFirstname.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(460, 17);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(181, 20);
            this.txtLastName.TabIndex = 9;
            // 
            // lblLoans
            // 
            this.lblLoans.AutoSize = true;
            this.lblLoans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoans.Location = new System.Drawing.Point(84, 248);
            this.lblLoans.Name = "lblLoans";
            this.lblLoans.Size = new System.Drawing.Size(54, 21);
            this.lblLoans.TabIndex = 32;
            this.lblLoans.Text = "Loans";
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 32);
            this.btnBack.TabIndex = 29;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lvLoans
            // 
            this.lvLoans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvLoans.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBook,
            this.chLoanDate});
            this.lvLoans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLoans.FullRowSelect = true;
            this.lvLoans.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLoans.HideSelection = false;
            this.lvLoans.Location = new System.Drawing.Point(88, 272);
            this.lvLoans.MultiSelect = false;
            this.lvLoans.Name = "lvLoans";
            this.lvLoans.Size = new System.Drawing.Size(282, 165);
            this.lvLoans.TabIndex = 34;
            this.lvLoans.UseCompatibleStateImageBehavior = false;
            this.lvLoans.View = System.Windows.Forms.View.Details;
            this.lvLoans.SelectedIndexChanged += new System.EventHandler(this.lvLoans_SelectedIndexChanged);
            // 
            // chBook
            // 
            this.chBook.Text = "Book";
            this.chBook.Width = 185;
            // 
            // chLoanDate
            // 
            this.chLoanDate.Text = "Date of Loan";
            this.chLoanDate.Width = 80;
            // 
            // btnEditMember
            // 
            this.btnEditMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(162)))), ((int)(((byte)(212)))));
            this.btnEditMember.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEditMember.FlatAppearance.BorderSize = 0;
            this.btnEditMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMember.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMember.ForeColor = System.Drawing.Color.White;
            this.btnEditMember.Image = ((System.Drawing.Image)(resources.GetObject("btnEditMember.Image")));
            this.btnEditMember.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMember.Location = new System.Drawing.Point(622, 220);
            this.btnEditMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(169, 33);
            this.btnEditMember.TabIndex = 35;
            this.btnEditMember.Text = "  Edit Member";
            this.btnEditMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMember.UseVisualStyleBackColor = false;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // pnlLoanInformation
            // 
            this.pnlLoanInformation.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlLoanInformation.Controls.Add(this.txtDebt);
            this.pnlLoanInformation.Controls.Add(this.lblDebt);
            this.pnlLoanInformation.Controls.Add(this.txtOverdue);
            this.pnlLoanInformation.Controls.Add(this.lblOnTime);
            this.pnlLoanInformation.Controls.Add(this.txtOnTime);
            this.pnlLoanInformation.Controls.Add(this.lblOverdue);
            this.pnlLoanInformation.Controls.Add(this.txtTimeOfReturn);
            this.pnlLoanInformation.Controls.Add(this.lblTimeOfReturn);
            this.pnlLoanInformation.Controls.Add(this.txtDueDate);
            this.pnlLoanInformation.Controls.Add(this.txtDateOfLoan);
            this.pnlLoanInformation.Controls.Add(this.lblDueDate);
            this.pnlLoanInformation.Controls.Add(this.lblDateOfLoan);
            this.pnlLoanInformation.Controls.Add(this.lblBookName);
            this.pnlLoanInformation.Controls.Add(this.txtBook);
            this.pnlLoanInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoanInformation.Location = new System.Drawing.Point(406, 272);
            this.pnlLoanInformation.Name = "pnlLoanInformation";
            this.pnlLoanInformation.Size = new System.Drawing.Size(385, 165);
            this.pnlLoanInformation.TabIndex = 36;
            this.pnlLoanInformation.Visible = false;
            // 
            // txtDebt
            // 
            this.txtDebt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.ForeColor = System.Drawing.Color.Red;
            this.txtDebt.Location = new System.Drawing.Point(288, 124);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(73, 16);
            this.txtDebt.TabIndex = 41;
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(194, 122);
            this.lblDebt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(42, 17);
            this.lblDebt.TabIndex = 40;
            this.lblDebt.Text = "Debt:";
            // 
            // txtOverdue
            // 
            this.txtOverdue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtOverdue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOverdue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverdue.ForeColor = System.Drawing.Color.Red;
            this.txtOverdue.Location = new System.Drawing.Point(104, 124);
            this.txtOverdue.Name = "txtOverdue";
            this.txtOverdue.ReadOnly = true;
            this.txtOverdue.Size = new System.Drawing.Size(73, 16);
            this.txtOverdue.TabIndex = 39;
            // 
            // lblOnTime
            // 
            this.lblOnTime.AutoSize = true;
            this.lblOnTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnTime.Location = new System.Drawing.Point(194, 88);
            this.lblOnTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblOnTime.Name = "lblOnTime";
            this.lblOnTime.Size = new System.Drawing.Size(65, 17);
            this.lblOnTime.TabIndex = 38;
            this.lblOnTime.Text = "On Time:";
            // 
            // txtOnTime
            // 
            this.txtOnTime.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtOnTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOnTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnTime.Location = new System.Drawing.Point(288, 90);
            this.txtOnTime.Name = "txtOnTime";
            this.txtOnTime.ReadOnly = true;
            this.txtOnTime.Size = new System.Drawing.Size(73, 16);
            this.txtOnTime.TabIndex = 37;
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdue.Location = new System.Drawing.Point(7, 122);
            this.lblOverdue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(64, 17);
            this.lblOverdue.TabIndex = 36;
            this.lblOverdue.Text = "Overdue:";
            // 
            // txtTimeOfReturn
            // 
            this.txtTimeOfReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtTimeOfReturn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimeOfReturn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimeOfReturn.Location = new System.Drawing.Point(104, 90);
            this.txtTimeOfReturn.Name = "txtTimeOfReturn";
            this.txtTimeOfReturn.ReadOnly = true;
            this.txtTimeOfReturn.Size = new System.Drawing.Size(73, 16);
            this.txtTimeOfReturn.TabIndex = 35;
            // 
            // lblTimeOfReturn
            // 
            this.lblTimeOfReturn.AutoSize = true;
            this.lblTimeOfReturn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeOfReturn.Location = new System.Drawing.Point(7, 88);
            this.lblTimeOfReturn.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblTimeOfReturn.Name = "lblTimeOfReturn";
            this.lblTimeOfReturn.Size = new System.Drawing.Size(68, 17);
            this.lblTimeOfReturn.TabIndex = 34;
            this.lblTimeOfReturn.Text = "Returned:";
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDueDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(288, 56);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(73, 16);
            this.txtDueDate.TabIndex = 33;
            // 
            // txtDateOfLoan
            // 
            this.txtDateOfLoan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDateOfLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateOfLoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateOfLoan.Location = new System.Drawing.Point(104, 56);
            this.txtDateOfLoan.Name = "txtDateOfLoan";
            this.txtDateOfLoan.ReadOnly = true;
            this.txtDateOfLoan.Size = new System.Drawing.Size(73, 16);
            this.txtDateOfLoan.TabIndex = 32;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(194, 54);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(70, 17);
            this.lblDueDate.TabIndex = 31;
            this.lblDueDate.Text = "Due Date:";
            // 
            // lblDateOfLoan
            // 
            this.lblDateOfLoan.AutoSize = true;
            this.lblDateOfLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfLoan.Location = new System.Drawing.Point(7, 54);
            this.lblDateOfLoan.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblDateOfLoan.Name = "lblDateOfLoan";
            this.lblDateOfLoan.Size = new System.Drawing.Size(92, 17);
            this.lblDateOfLoan.TabIndex = 30;
            this.lblDateOfLoan.Text = "Date of Loan:";
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(7, 20);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(44, 17);
            this.lblBookName.TabIndex = 25;
            this.lblBookName.Text = "Book:";
            // 
            // txtBook
            // 
            this.txtBook.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBook.Location = new System.Drawing.Point(104, 19);
            this.txtBook.Name = "txtBook";
            this.txtBook.ReadOnly = true;
            this.txtBook.Size = new System.Drawing.Size(260, 18);
            this.txtBook.TabIndex = 12;
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(285, 4);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(43, 47);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 37;
            this.pb.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.pnlLoanInformation);
            this.Controls.Add(this.btnEditMember);
            this.Controls.Add(this.lvLoans);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlMemberInformation);
            this.Controls.Add(this.lblLoans);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCViewMember";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCViewMember_VisibleChanged);
            this.pnlMemberInformation.ResumeLayout(false);
            this.pnlMemberInformation.PerformLayout();
            this.pnlLoanInformation.ResumeLayout(false);
            this.pnlLoanInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMemberInformation;
        private System.Windows.Forms.Label lblPersonalID;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLoans;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView lvLoans;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRegistered;
        private System.Windows.Forms.TextBox txtPersonalID;
        private System.Windows.Forms.TextBox txtRegistered;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Panel pnlLoanInformation;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.TextBox txtDateOfLoan;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label lblDateOfLoan;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ColumnHeader chBook;
        private System.Windows.Forms.ColumnHeader chLoanDate;
        private System.Windows.Forms.TextBox txtOnTime;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.TextBox txtTimeOfReturn;
        private System.Windows.Forms.Label lblTimeOfReturn;
        private System.Windows.Forms.TextBox txtTotalDebt;
        private System.Windows.Forms.Label lblTotalDebt;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label lblDebt;
        private System.Windows.Forms.TextBox txtOverdue;
        private System.Windows.Forms.Label lblOnTime;
        private System.Windows.Forms.Label label2;
    }
}
