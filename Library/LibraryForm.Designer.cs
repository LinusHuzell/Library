namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.pnlTabBg = new System.Windows.Forms.Panel();
            this.pnlCurrentTab = new System.Windows.Forms.Panel();
            this.btnHelpTab = new System.Windows.Forms.Button();
            this.btnMembersTab = new System.Windows.Forms.Button();
            this.btnBooksTab = new System.Windows.Forms.Button();
            this.btnLoansTab = new System.Windows.Forms.Button();
            this.btnHomeTab = new System.Windows.Forms.Button();
            this.pnlHeaderBg = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.ucHome = new Library.UserControls.UCHome(this);
            this.ucLoans = new Library.UserControls.Loans.UCLoans(this);
            this.ucLoansSearch = new Library.UserControls.Loans.UCLoansSearch(this);
            this.ucLoanBook = new Library.UserControls.Loans.UCLoanBook(this);
            this.ucReturnBook = new Library.UserControls.Loans.UCReturnBook(this);
            this.ucEdit = new Library.UserControls.Books.UCEdit(this);
            this.ucAuthor = new Library.UserControls.Books.UCAuthor(this);
            this.ucBook = new Library.UserControls.Books.UCBook(this);
            this.ucMembers = new Library.UserControls.Members.UCMembers(this);
            this.ucMember = new Library.UserControls.Members.UCMember(this);
            this.ucViewMember = new Library.UserControls.Members.UCViewMember(this);
            this.ucHelp = new Library.UserControls.UCHelp(this);
            this.pnlTabBg.SuspendLayout();
            this.pnlHeaderBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTabBg
            // 
            this.pnlTabBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(41)))));
            this.pnlTabBg.Controls.Add(this.pnlCurrentTab);
            this.pnlTabBg.Controls.Add(this.btnHelpTab);
            this.pnlTabBg.Controls.Add(this.btnMembersTab);
            this.pnlTabBg.Controls.Add(this.btnBooksTab);
            this.pnlTabBg.Controls.Add(this.btnLoansTab);
            this.pnlTabBg.Controls.Add(this.btnHomeTab);
            this.pnlTabBg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTabBg.Location = new System.Drawing.Point(0, 0);
            this.pnlTabBg.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTabBg.Name = "pnlTabBg";
            this.pnlTabBg.Size = new System.Drawing.Size(153, 585);
            this.pnlTabBg.TabIndex = 2;
            // 
            // pnlCurrentTab
            // 
            this.pnlCurrentTab.BackColor = System.Drawing.Color.White;
            this.pnlCurrentTab.Location = new System.Drawing.Point(0, 109);
            this.pnlCurrentTab.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCurrentTab.Name = "pnlCurrentTab";
            this.pnlCurrentTab.Size = new System.Drawing.Size(10, 52);
            this.pnlCurrentTab.TabIndex = 5;
            // 
            // btnHelpTab
            // 
            this.btnHelpTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelpTab.FlatAppearance.BorderSize = 0;
            this.btnHelpTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpTab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpTab.ForeColor = System.Drawing.Color.White;
            this.btnHelpTab.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpTab.Image")));
            this.btnHelpTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpTab.Location = new System.Drawing.Point(10, 533);
            this.btnHelpTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnHelpTab.Name = "btnHelpTab";
            this.btnHelpTab.Size = new System.Drawing.Size(143, 52);
            this.btnHelpTab.TabIndex = 4;
            this.btnHelpTab.Text = "  Help";
            this.btnHelpTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelpTab.UseVisualStyleBackColor = true;
            this.btnHelpTab.Click += new System.EventHandler(this.btnHelpTab_Click);
            // 
            // btnMembersTab
            // 
            this.btnMembersTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMembersTab.FlatAppearance.BorderSize = 0;
            this.btnMembersTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembersTab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersTab.ForeColor = System.Drawing.Color.White;
            this.btnMembersTab.Image = ((System.Drawing.Image)(resources.GetObject("btnMembersTab.Image")));
            this.btnMembersTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMembersTab.Location = new System.Drawing.Point(10, 265);
            this.btnMembersTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnMembersTab.Name = "btnMembersTab";
            this.btnMembersTab.Size = new System.Drawing.Size(143, 52);
            this.btnMembersTab.TabIndex = 3;
            this.btnMembersTab.Text = "  Members";
            this.btnMembersTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMembersTab.UseVisualStyleBackColor = true;
            this.btnMembersTab.Click += new System.EventHandler(this.btnMembersTab_Click);
            // 
            // btnBooksTab
            // 
            this.btnBooksTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBooksTab.FlatAppearance.BorderSize = 0;
            this.btnBooksTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooksTab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksTab.ForeColor = System.Drawing.Color.White;
            this.btnBooksTab.Image = ((System.Drawing.Image)(resources.GetObject("btnBooksTab.Image")));
            this.btnBooksTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBooksTab.Location = new System.Drawing.Point(10, 213);
            this.btnBooksTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnBooksTab.Name = "btnBooksTab";
            this.btnBooksTab.Size = new System.Drawing.Size(143, 52);
            this.btnBooksTab.TabIndex = 2;
            this.btnBooksTab.Text = "  Edit";
            this.btnBooksTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBooksTab.UseVisualStyleBackColor = true;
            this.btnBooksTab.Click += new System.EventHandler(this.btnBooksTab_Click);
            // 
            // btnLoansTab
            // 
            this.btnLoansTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoansTab.FlatAppearance.BorderSize = 0;
            this.btnLoansTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoansTab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoansTab.ForeColor = System.Drawing.Color.White;
            this.btnLoansTab.Image = ((System.Drawing.Image)(resources.GetObject("btnLoansTab.Image")));
            this.btnLoansTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoansTab.Location = new System.Drawing.Point(10, 161);
            this.btnLoansTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoansTab.Name = "btnLoansTab";
            this.btnLoansTab.Size = new System.Drawing.Size(143, 52);
            this.btnLoansTab.TabIndex = 1;
            this.btnLoansTab.Text = "  Loans";
            this.btnLoansTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoansTab.UseVisualStyleBackColor = true;
            this.btnLoansTab.Click += new System.EventHandler(this.btnLoansTab_Click);
            // 
            // btnHomeTab
            // 
            this.btnHomeTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(119)))));
            this.btnHomeTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomeTab.FlatAppearance.BorderSize = 0;
            this.btnHomeTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHomeTab.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeTab.ForeColor = System.Drawing.Color.White;
            this.btnHomeTab.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeTab.Image")));
            this.btnHomeTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeTab.Location = new System.Drawing.Point(10, 109);
            this.btnHomeTab.Margin = new System.Windows.Forms.Padding(0);
            this.btnHomeTab.Name = "btnHomeTab";
            this.btnHomeTab.Size = new System.Drawing.Size(143, 52);
            this.btnHomeTab.TabIndex = 0;
            this.btnHomeTab.Text = "  Home";
            this.btnHomeTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHomeTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomeTab.UseVisualStyleBackColor = false;
            this.btnHomeTab.Click += new System.EventHandler(this.btnHomeTab_Click);
            // 
            // pnlHeaderBg
            // 
            this.pnlHeaderBg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnlHeaderBg.Controls.Add(this.pbIcon);
            this.pnlHeaderBg.Controls.Add(this.btnQuit);
            this.pnlHeaderBg.Controls.Add(this.lblHeader);
            this.pnlHeaderBg.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderBg.Location = new System.Drawing.Point(153, 0);
            this.pnlHeaderBg.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeaderBg.Name = "pnlHeaderBg";
            this.pnlHeaderBg.Size = new System.Drawing.Size(820, 81);
            this.pnlHeaderBg.TabIndex = 3;
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(158, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(73, 56);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 6;
            this.pbIcon.TabStop = false;
            this.pbIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbIcon_MouseDown);
            // 
            // btnQuit
            // 
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.FlatAppearance.BorderSize = 0;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.Location = new System.Drawing.Point(788, 2);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(30, 30);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.TabStop = false;
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(3, 2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(817, 79);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Amazing Library App";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            // 
            // ucHome
            // 
            this.ucHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucHome.Location = new System.Drawing.Point(153, 81);
            this.ucHome.Margin = new System.Windows.Forms.Padding(0);
            this.ucHome.Name = "ucHome";
            this.ucHome.Size = new System.Drawing.Size(820, 504);
            this.ucHome.TabIndex = 18;
            this.ucHome.Visible = false;
            // 
            // ucLoans
            // 
            this.ucLoans.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucLoans.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLoans.Location = new System.Drawing.Point(153, 81);
            this.ucLoans.Margin = new System.Windows.Forms.Padding(0);
            this.ucLoans.Name = "ucLoans";
            this.ucLoans.Size = new System.Drawing.Size(820, 504);
            this.ucLoans.TabIndex = 17;
            this.ucLoans.Visible = false;
            // 
            // ucLoansSearch
            // 
            this.ucLoansSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucLoansSearch.Location = new System.Drawing.Point(153, 81);
            this.ucLoansSearch.Margin = new System.Windows.Forms.Padding(0);
            this.ucLoansSearch.Name = "ucLoansSearch";
            this.ucLoansSearch.Size = new System.Drawing.Size(820, 504);
            this.ucLoansSearch.TabIndex = 16;
            this.ucLoansSearch.Visible = false;
            // 
            // ucLoanBook
            // 
            this.ucLoanBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucLoanBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLoanBook.Location = new System.Drawing.Point(153, 81);
            this.ucLoanBook.Margin = new System.Windows.Forms.Padding(0);
            this.ucLoanBook.Name = "ucLoanBook";
            this.ucLoanBook.Size = new System.Drawing.Size(820, 504);
            this.ucLoanBook.TabIndex = 15;
            this.ucLoanBook.Visible = false;
            // 
            // ucReturnBook
            // 
            this.ucReturnBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucReturnBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucReturnBook.Location = new System.Drawing.Point(153, 81);
            this.ucReturnBook.Margin = new System.Windows.Forms.Padding(0);
            this.ucReturnBook.Name = "ucReturnBook";
            this.ucReturnBook.Size = new System.Drawing.Size(820, 504);
            this.ucReturnBook.TabIndex = 14;
            this.ucReturnBook.Visible = false;
            // 
            // ucEdit
            // 
            this.ucEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucEdit.Location = new System.Drawing.Point(153, 81);
            this.ucEdit.Margin = new System.Windows.Forms.Padding(0);
            this.ucEdit.Name = "ucEdit";
            this.ucEdit.Size = new System.Drawing.Size(820, 504);
            this.ucEdit.TabIndex = 13;
            this.ucEdit.Visible = false;
            // 
            // ucAuthor
            // 
            this.ucAuthor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucAuthor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAuthor.Location = new System.Drawing.Point(153, 81);
            this.ucAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.ucAuthor.Name = "ucAuthor";
            this.ucAuthor.Size = new System.Drawing.Size(820, 504);
            this.ucAuthor.TabIndex = 11;
            this.ucAuthor.Visible = false;
            // 
            // ucBook
            // 
            this.ucBook.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucBook.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBook.Location = new System.Drawing.Point(153, 81);
            this.ucBook.Margin = new System.Windows.Forms.Padding(0);
            this.ucBook.Name = "ucBook";
            this.ucBook.Size = new System.Drawing.Size(820, 504);
            this.ucBook.TabIndex = 12;
            this.ucBook.Visible = false;
            // 
            // ucMembers
            // 
            this.ucMembers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMembers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMembers.Location = new System.Drawing.Point(153, 81);
            this.ucMembers.Margin = new System.Windows.Forms.Padding(0);
            this.ucMembers.Name = "ucMembers";
            this.ucMembers.Size = new System.Drawing.Size(820, 504);
            this.ucMembers.TabIndex = 8;
            this.ucMembers.Visible = false;
            // 
            // ucAddMember
            // 
            this.ucMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMember.Location = new System.Drawing.Point(153, 81);
            this.ucMember.Margin = new System.Windows.Forms.Padding(0);
            this.ucMember.Name = "ucAddMember";
            this.ucMember.Size = new System.Drawing.Size(820, 504);
            this.ucMember.TabIndex = 7;
            this.ucMember.Visible = false;
            // 
            // ucViewMember
            // 
            this.ucViewMember.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ucViewMember.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucViewMember.Location = new System.Drawing.Point(153, 81);
            this.ucViewMember.Margin = new System.Windows.Forms.Padding(0);
            this.ucViewMember.Name = "ucViewMember";
            this.ucViewMember.Size = new System.Drawing.Size(820, 504);
            this.ucViewMember.TabIndex = 6;
            this.ucViewMember.Visible = false;
            // 
            // ucHelp
            // 
            this.ucHelp.Location = new System.Drawing.Point(153, 81);
            this.ucHelp.Margin = new System.Windows.Forms.Padding(0);
            this.ucHelp.Name = "ucHelp";
            this.ucHelp.Size = new System.Drawing.Size(820, 504);
            this.ucHelp.TabIndex = 4;
            this.ucHelp.Visible = false;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(973, 585);
            this.Controls.Add(this.ucBook);
            this.Controls.Add(this.ucHome);
            this.Controls.Add(this.ucLoans);
            this.Controls.Add(this.ucLoansSearch);
            this.Controls.Add(this.ucLoanBook);
            this.Controls.Add(this.ucReturnBook);
            this.Controls.Add(this.ucEdit);
            this.Controls.Add(this.ucAuthor);
            this.Controls.Add(this.ucMembers);
            this.Controls.Add(this.ucMember);
            this.Controls.Add(this.ucViewMember);
            this.Controls.Add(this.ucHelp);
            this.Controls.Add(this.pnlHeaderBg);
            this.Controls.Add(this.pnlTabBg);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            this.pnlTabBg.ResumeLayout(false);
            this.pnlHeaderBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTabBg;
        private System.Windows.Forms.Button btnHomeTab;
        private System.Windows.Forms.Panel pnlHeaderBg;
        private System.Windows.Forms.Panel pnlCurrentTab;
        private System.Windows.Forms.Button btnHelpTab;
        private System.Windows.Forms.Button btnMembersTab;
        private System.Windows.Forms.Button btnBooksTab;
        private System.Windows.Forms.Button btnLoansTab;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbIcon;
        public UserControls.UCHelp ucHelp;
        public UserControls.Members.UCViewMember ucViewMember;
        public UserControls.Members.UCMember ucMember;
        public UserControls.Members.UCMembers ucMembers;
        public UserControls.Books.UCBook ucBook;
        public UserControls.Books.UCAuthor ucAuthor;
        public UserControls.Books.UCEdit ucEdit;
        public UserControls.Loans.UCReturnBook ucReturnBook;
        public UserControls.Loans.UCLoanBook ucLoanBook;
        public UserControls.Loans.UCLoansSearch ucLoansSearch;
        public UserControls.Loans.UCLoans ucLoans;
        public UserControls.UCHome ucHome;
    }
}

