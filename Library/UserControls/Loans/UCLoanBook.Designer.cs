namespace Library.UserControls.Loans
{
    partial class UCLoanBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoanBook));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtAuthors = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblChooseMember = new System.Windows.Forms.Label();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.lvMembers = new System.Windows.Forms.ListView();
            this.chMember = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvBookCopies = new System.Windows.Forms.ListView();
            this.chBookCopy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblChooseBookCopy = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBookInfo.SuspendLayout();
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
            this.lblTitle.Text = "Loan Book";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnlBookInfo
            // 
            this.pnlBookInfo.BackColor = System.Drawing.Color.LightGreen;
            this.pnlBookInfo.Controls.Add(this.txtISBN);
            this.pnlBookInfo.Controls.Add(this.txtAuthors);
            this.pnlBookInfo.Controls.Add(this.lblISBN);
            this.pnlBookInfo.Controls.Add(this.lblYear);
            this.pnlBookInfo.Controls.Add(this.lblDescription);
            this.pnlBookInfo.Controls.Add(this.lblAuthor);
            this.pnlBookInfo.Controls.Add(this.txtYear);
            this.pnlBookInfo.Controls.Add(this.txtDescription);
            this.pnlBookInfo.Location = new System.Drawing.Point(386, 128);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(398, 200);
            this.pnlBookInfo.TabIndex = 23;
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.LightGreen;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(70, 21);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(2);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(152, 19);
            this.txtISBN.TabIndex = 13;
            // 
            // txtAuthors
            // 
            this.txtAuthors.BackColor = System.Drawing.Color.LightGreen;
            this.txtAuthors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthors.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthors.Location = new System.Drawing.Point(100, 58);
            this.txtAuthors.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthors.Name = "txtAuthors";
            this.txtAuthors.ReadOnly = true;
            this.txtAuthors.Size = new System.Drawing.Size(282, 18);
            this.txtAuthors.TabIndex = 14;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(22, 21);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(45, 19);
            this.lblISBN.TabIndex = 28;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(22, 92);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 19);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year Published:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(22, 129);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 19);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(22, 57);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(75, 19);
            this.lblAuthor.TabIndex = 25;
            this.lblAuthor.Text = "Author(s):";
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightGreen;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(137, 92);
            this.txtYear.Margin = new System.Windows.Forms.Padding(2);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(35, 19);
            this.txtYear.TabIndex = 15;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightGreen;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(116, 132);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(268, 50);
            this.txtDescription.TabIndex = 16;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(0, 47);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(820, 54);
            this.lblBookTitle.TabIndex = 24;
            this.lblBookTitle.Text = "Book Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChooseMember
            // 
            this.lblChooseMember.AutoSize = true;
            this.lblChooseMember.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseMember.Location = new System.Drawing.Point(63, 104);
            this.lblChooseMember.Name = "lblChooseMember";
            this.lblChooseMember.Size = new System.Drawing.Size(134, 21);
            this.lblChooseMember.TabIndex = 27;
            this.lblChooseMember.Text = "Choose member";
            // 
            // btnNewLoan
            // 
            this.btnNewLoan.BackColor = System.Drawing.Color.Green;
            this.btnNewLoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnNewLoan.FlatAppearance.BorderSize = 0;
            this.btnNewLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLoan.ForeColor = System.Drawing.Color.White;
            this.btnNewLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLoan.Image")));
            this.btnNewLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewLoan.Location = new System.Drawing.Point(456, 426);
            this.btnNewLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(262, 38);
            this.btnNewLoan.TabIndex = 17;
            this.btnNewLoan.Text = "  New Loan";
            this.btnNewLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewLoan.UseVisualStyleBackColor = false;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
            // 
            // lvMembers
            // 
            this.lvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMembers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMember});
            this.lvMembers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMembers.FullRowSelect = true;
            this.lvMembers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvMembers.HideSelection = false;
            this.lvMembers.Location = new System.Drawing.Point(67, 161);
            this.lvMembers.MultiSelect = false;
            this.lvMembers.Name = "lvMembers";
            this.lvMembers.Size = new System.Drawing.Size(280, 167);
            this.lvMembers.TabIndex = 11;
            this.lvMembers.UseCompatibleStateImageBehavior = false;
            this.lvMembers.View = System.Windows.Forms.View.Details;
            // 
            // chMember
            // 
            this.chMember.Text = "Name";
            this.chMember.Width = 260;
            // 
            // lvBookCopies
            // 
            this.lvBookCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvBookCopies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookCopy});
            this.lvBookCopies.FullRowSelect = true;
            this.lvBookCopies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvBookCopies.HideSelection = false;
            this.lvBookCopies.Location = new System.Drawing.Point(67, 358);
            this.lvBookCopies.MultiSelect = false;
            this.lvBookCopies.Name = "lvBookCopies";
            this.lvBookCopies.Size = new System.Drawing.Size(280, 106);
            this.lvBookCopies.TabIndex = 12;
            this.lvBookCopies.UseCompatibleStateImageBehavior = false;
            this.lvBookCopies.View = System.Windows.Forms.View.Details;
            // 
            // chBookCopy
            // 
            this.chBookCopy.Text = "Book Copy";
            this.chBookCopy.Width = 260;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Gray;
            this.txtFilter.Location = new System.Drawing.Point(67, 128);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(280, 25);
            this.txtFilter.TabIndex = 10;
            this.txtFilter.Text = "Filter on name...";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // lblChooseBookCopy
            // 
            this.lblChooseBookCopy.AutoSize = true;
            this.lblChooseBookCopy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseBookCopy.Location = new System.Drawing.Point(63, 334);
            this.lblChooseBookCopy.Name = "lblChooseBookCopy";
            this.lblChooseBookCopy.Size = new System.Drawing.Size(150, 21);
            this.lblChooseBookCopy.TabIndex = 45;
            this.lblChooseBookCopy.Text = "Choose book copy";
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(384, 377);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(398, 36);
            this.lblMessage.TabIndex = 46;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.label2.TabIndex = 47;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCLoanBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblChooseBookCopy);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvBookCopies);
            this.Controls.Add(this.lvMembers);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.lblChooseMember);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.pnlBookInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLoanBook";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCLoanBook_VisibleChanged);
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblChooseMember;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.ListView lvMembers;
        private System.Windows.Forms.ListView lvBookCopies;
        private System.Windows.Forms.ColumnHeader chBookCopy;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtAuthors;
        private System.Windows.Forms.ColumnHeader chMember;
        private System.Windows.Forms.Label lblChooseBookCopy;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
    }
}
