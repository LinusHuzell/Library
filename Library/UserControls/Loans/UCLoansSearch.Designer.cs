namespace Library.UserControls.Loans
{
    partial class UCLoansSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoansSearch));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtnMember = new System.Windows.Forms.RadioButton();
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lvNewLoan = new System.Windows.Forms.ListView();
            this.chBookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAvailability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvReturnLoan = new System.Windows.Forms.ListView();
            this.chBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chBookCopy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMember = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbNew = new System.Windows.Forms.PictureBox();
            this.lblTodaysDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).BeginInit();
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
            this.lblTitle.Text = "Loans Search";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(122, 372);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(470, 29);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(597, 372);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 29);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "   Search...";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rbtnMember
            // 
            this.rbtnMember.AutoSize = true;
            this.rbtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMember.Location = new System.Drawing.Point(202, 346);
            this.rbtnMember.Name = "rbtnMember";
            this.rbtnMember.Size = new System.Drawing.Size(69, 19);
            this.rbtnMember.TabIndex = 17;
            this.rbtnMember.TabStop = true;
            this.rbtnMember.Text = "Member";
            this.rbtnMember.UseVisualStyleBackColor = true;
            this.rbtnMember.CheckedChanged += new System.EventHandler(this.rbtnMember_CheckedChanged);
            // 
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBook.Location = new System.Drawing.Point(122, 346);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(74, 19);
            this.rbtnBook.TabIndex = 16;
            this.rbtnBook.TabStop = true;
            this.rbtnBook.Text = "Book title";
            this.rbtnBook.UseVisualStyleBackColor = true;
            this.rbtnBook.CheckedChanged += new System.EventHandler(this.rbtnBook_CheckedChanged);
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
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 32);
            this.btnBack.TabIndex = 22;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Green;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNext.Location = new System.Drawing.Point(572, 419);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 47);
            this.btnNext.TabIndex = 23;
            this.btnNext.Text = "Next";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lvNewLoan
            // 
            this.lvNewLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvNewLoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookTitle,
            this.chAuthors,
            this.chAvailability});
            this.lvNewLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvNewLoan.FullRowSelect = true;
            this.lvNewLoan.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvNewLoan.Location = new System.Drawing.Point(122, 93);
            this.lvNewLoan.MultiSelect = false;
            this.lvNewLoan.Name = "lvNewLoan";
            this.lvNewLoan.Size = new System.Drawing.Size(600, 247);
            this.lvNewLoan.TabIndex = 24;
            this.lvNewLoan.UseCompatibleStateImageBehavior = false;
            this.lvNewLoan.View = System.Windows.Forms.View.Details;
            this.lvNewLoan.Visible = false;
            this.lvNewLoan.DoubleClick += new System.EventHandler(this.btnNext_Click);
            // 
            // chBookTitle
            // 
            this.chBookTitle.Text = "Book title";
            this.chBookTitle.Width = 270;
            // 
            // chAuthors
            // 
            this.chAuthors.Text = "Authors";
            this.chAuthors.Width = 198;
            // 
            // chAvailability
            // 
            this.chAvailability.Text = "Availability";
            this.chAvailability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chAvailability.Width = 115;
            // 
            // lvReturnLoan
            // 
            this.lvReturnLoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvReturnLoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBook,
            this.chBookCopy,
            this.chMember,
            this.chDueDate});
            this.lvReturnLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvReturnLoan.FullRowSelect = true;
            this.lvReturnLoan.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvReturnLoan.Location = new System.Drawing.Point(122, 93);
            this.lvReturnLoan.MultiSelect = false;
            this.lvReturnLoan.Name = "lvReturnLoan";
            this.lvReturnLoan.Size = new System.Drawing.Size(600, 247);
            this.lvReturnLoan.TabIndex = 25;
            this.lvReturnLoan.UseCompatibleStateImageBehavior = false;
            this.lvReturnLoan.View = System.Windows.Forms.View.Details;
            this.lvReturnLoan.Visible = false;
            this.lvReturnLoan.DoubleClick += new System.EventHandler(this.btnNext_Click);
            // 
            // chBook
            // 
            this.chBook.Text = "Book title";
            this.chBook.Width = 258;
            // 
            // chBookCopy
            // 
            this.chBookCopy.Text = "Copy";
            this.chBookCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chMember
            // 
            this.chMember.Text = "Member";
            this.chMember.Width = 150;
            // 
            // chDueDate
            // 
            this.chDueDate.Text = "Due Date";
            this.chDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDueDate.Width = 115;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(119, 419);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(436, 47);
            this.lblMessage.TabIndex = 32;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 26);
            this.label2.TabIndex = 33;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbNew
            // 
            this.pbNew.Image = ((System.Drawing.Image)(resources.GetObject("pbNew.Image")));
            this.pbNew.Location = new System.Drawing.Point(289, 4);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(43, 47);
            this.pbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNew.TabIndex = 40;
            this.pbNew.TabStop = false;
            // 
            // lblTodaysDate
            // 
            this.lblTodaysDate.AutoSize = true;
            this.lblTodaysDate.Location = new System.Drawing.Point(657, 66);
            this.lblTodaysDate.Name = "lblTodaysDate";
            this.lblTodaysDate.Size = new System.Drawing.Size(65, 13);
            this.lblTodaysDate.TabIndex = 41;
            this.lblTodaysDate.Text = "2018-XX-XX";
            // 
            // UCLoansSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblTodaysDate);
            this.Controls.Add(this.pbNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lvReturnLoan);
            this.Controls.Add(this.lvNewLoan);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rbtnMember);
            this.Controls.Add(this.rbtnBook);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLoansSearch";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCLoansSearch_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnMember;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView lvNewLoan;
        private System.Windows.Forms.ColumnHeader chBookTitle;
        private System.Windows.Forms.ColumnHeader chAuthors;
        private System.Windows.Forms.ColumnHeader chAvailability;
        private System.Windows.Forms.ListView lvReturnLoan;
        private System.Windows.Forms.ColumnHeader chBook;
        private System.Windows.Forms.ColumnHeader chBookCopy;
        private System.Windows.Forms.ColumnHeader chMember;
        private System.Windows.Forms.ColumnHeader chDueDate;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbNew;
        private System.Windows.Forms.Label lblTodaysDate;
    }
}
