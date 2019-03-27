namespace Library.UserControls.Loans
{
    partial class UCReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCReturnBook));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.lblBookCopy = new System.Windows.Forms.Label();
            this.txtBookCopy = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.pnlLoanInfo = new System.Windows.Forms.Panel();
            this.txtOnTime = new System.Windows.Forms.TextBox();
            this.lblOnTime = new System.Windows.Forms.Label();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.txtReturned = new System.Windows.Forms.TextBox();
            this.lblReturned = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblDebt = new System.Windows.Forms.Label();
            this.txtMember = new System.Windows.Forms.TextBox();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.lblDaysLeft = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.txtLoanDate = new System.Windows.Forms.TextBox();
            this.txtDaysLeft = new System.Windows.Forms.TextBox();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBookInfo.SuspendLayout();
            this.pnlLoanInfo.SuspendLayout();
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
            this.lblTitle.Text = "Return Book";
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
            this.btnBack.TabIndex = 23;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(0, 54);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(820, 47);
            this.lblBookTitle.TabIndex = 10;
            this.lblBookTitle.Text = "Book Title";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBookInfo
            // 
            this.pnlBookInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlBookInfo.Controls.Add(this.lblBookCopy);
            this.pnlBookInfo.Controls.Add(this.txtBookCopy);
            this.pnlBookInfo.Controls.Add(this.lblISBN);
            this.pnlBookInfo.Controls.Add(this.lblYear);
            this.pnlBookInfo.Controls.Add(this.lblDescription);
            this.pnlBookInfo.Controls.Add(this.lblAuthor);
            this.pnlBookInfo.Controls.Add(this.txtISBN);
            this.pnlBookInfo.Controls.Add(this.txtYear);
            this.pnlBookInfo.Controls.Add(this.txtDescription);
            this.pnlBookInfo.Controls.Add(this.txtAuthor);
            this.pnlBookInfo.Location = new System.Drawing.Point(93, 115);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(648, 178);
            this.pnlBookInfo.TabIndex = 26;
            // 
            // lblBookCopy
            // 
            this.lblBookCopy.AutoSize = true;
            this.lblBookCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCopy.Location = new System.Drawing.Point(498, 19);
            this.lblBookCopy.Name = "lblBookCopy";
            this.lblBookCopy.Size = new System.Drawing.Size(87, 19);
            this.lblBookCopy.TabIndex = 33;
            this.lblBookCopy.Text = "Book Copy:";
            // 
            // txtBookCopy
            // 
            this.txtBookCopy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtBookCopy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookCopy.Location = new System.Drawing.Point(587, 20);
            this.txtBookCopy.Name = "txtBookCopy";
            this.txtBookCopy.ReadOnly = true;
            this.txtBookCopy.Size = new System.Drawing.Size(35, 18);
            this.txtBookCopy.TabIndex = 12;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(41, 19);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(45, 19);
            this.lblISBN.TabIndex = 28;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(41, 80);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(112, 19);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year Published:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(41, 109);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 19);
            this.lblDescription.TabIndex = 26;
            this.lblDescription.Text = "Description:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(41, 50);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(75, 19);
            this.lblAuthor.TabIndex = 25;
            this.lblAuthor.Text = "Author(s):";
            // 
            // txtISBN
            // 
            this.txtISBN.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtISBN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(92, 18);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(181, 20);
            this.txtISBN.TabIndex = 11;
            // 
            // txtYear
            // 
            this.txtYear.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(159, 79);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(35, 20);
            this.txtYear.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(136, 112);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(488, 51);
            this.txtDescription.TabIndex = 15;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(122, 49);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(499, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // pnlLoanInfo
            // 
            this.pnlLoanInfo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlLoanInfo.Controls.Add(this.txtOnTime);
            this.pnlLoanInfo.Controls.Add(this.lblOnTime);
            this.pnlLoanInfo.Controls.Add(this.txtDebt);
            this.pnlLoanInfo.Controls.Add(this.txtReturned);
            this.pnlLoanInfo.Controls.Add(this.lblReturned);
            this.pnlLoanInfo.Controls.Add(this.lblMember);
            this.pnlLoanInfo.Controls.Add(this.lblDebt);
            this.pnlLoanInfo.Controls.Add(this.txtMember);
            this.pnlLoanInfo.Controls.Add(this.txtDueDate);
            this.pnlLoanInfo.Controls.Add(this.lblLoanDate);
            this.pnlLoanInfo.Controls.Add(this.lblDaysLeft);
            this.pnlLoanInfo.Controls.Add(this.lblDueDate);
            this.pnlLoanInfo.Controls.Add(this.txtLoanDate);
            this.pnlLoanInfo.Controls.Add(this.txtDaysLeft);
            this.pnlLoanInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlLoanInfo.Location = new System.Drawing.Point(93, 314);
            this.pnlLoanInfo.Name = "pnlLoanInfo";
            this.pnlLoanInfo.Size = new System.Drawing.Size(346, 150);
            this.pnlLoanInfo.TabIndex = 30;
            // 
            // txtOnTime
            // 
            this.txtOnTime.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtOnTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOnTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnTime.Location = new System.Drawing.Point(249, 87);
            this.txtOnTime.Name = "txtOnTime";
            this.txtOnTime.ReadOnly = true;
            this.txtOnTime.Size = new System.Drawing.Size(73, 16);
            this.txtOnTime.TabIndex = 49;
            // 
            // lblOnTime
            // 
            this.lblOnTime.AutoSize = true;
            this.lblOnTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnTime.Location = new System.Drawing.Point(179, 85);
            this.lblOnTime.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblOnTime.Name = "lblOnTime";
            this.lblOnTime.Size = new System.Drawing.Size(65, 17);
            this.lblOnTime.TabIndex = 50;
            this.lblOnTime.Text = "On Time:";
            // 
            // txtDebt
            // 
            this.txtDebt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDebt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDebt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebt.ForeColor = System.Drawing.Color.Red;
            this.txtDebt.Location = new System.Drawing.Point(227, 118);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(73, 16);
            this.txtDebt.TabIndex = 52;
            // 
            // txtReturned
            // 
            this.txtReturned.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtReturned.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReturned.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturned.Location = new System.Drawing.Point(84, 117);
            this.txtReturned.Name = "txtReturned";
            this.txtReturned.ReadOnly = true;
            this.txtReturned.Size = new System.Drawing.Size(88, 18);
            this.txtReturned.TabIndex = 32;
            // 
            // lblReturned
            // 
            this.lblReturned.AutoSize = true;
            this.lblReturned.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturned.Location = new System.Drawing.Point(10, 116);
            this.lblReturned.Name = "lblReturned";
            this.lblReturned.Size = new System.Drawing.Size(74, 19);
            this.lblReturned.TabIndex = 33;
            this.lblReturned.Text = "Returned:";
            this.lblReturned.Visible = false;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(10, 18);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(71, 19);
            this.lblMember.TabIndex = 31;
            this.lblMember.Text = "Member:";
            // 
            // lblDebt
            // 
            this.lblDebt.AutoSize = true;
            this.lblDebt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebt.Location = new System.Drawing.Point(179, 116);
            this.lblDebt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 60);
            this.lblDebt.Name = "lblDebt";
            this.lblDebt.Size = new System.Drawing.Size(42, 17);
            this.lblDebt.TabIndex = 51;
            this.lblDebt.Text = "Debt:";
            // 
            // txtMember
            // 
            this.txtMember.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMember.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMember.Location = new System.Drawing.Point(84, 19);
            this.txtMember.Name = "txtMember";
            this.txtMember.ReadOnly = true;
            this.txtMember.Size = new System.Drawing.Size(217, 18);
            this.txtMember.TabIndex = 16;
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueDate.Location = new System.Drawing.Point(84, 85);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(88, 18);
            this.txtDueDate.TabIndex = 18;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanDate.Location = new System.Drawing.Point(10, 51);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(80, 19);
            this.lblLoanDate.TabIndex = 28;
            this.lblLoanDate.Text = "Loan Date:";
            // 
            // lblDaysLeft
            // 
            this.lblDaysLeft.AutoSize = true;
            this.lblDaysLeft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysLeft.Location = new System.Drawing.Point(178, 51);
            this.lblDaysLeft.Name = "lblDaysLeft";
            this.lblDaysLeft.Size = new System.Drawing.Size(71, 19);
            this.lblDaysLeft.TabIndex = 27;
            this.lblDaysLeft.Text = "Days left:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(10, 84);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(74, 19);
            this.lblDueDate.TabIndex = 25;
            this.lblDueDate.Text = "Due Date:";
            // 
            // txtLoanDate
            // 
            this.txtLoanDate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtLoanDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoanDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoanDate.Location = new System.Drawing.Point(92, 52);
            this.txtLoanDate.Name = "txtLoanDate";
            this.txtLoanDate.ReadOnly = true;
            this.txtLoanDate.Size = new System.Drawing.Size(106, 18);
            this.txtLoanDate.TabIndex = 17;
            // 
            // txtDaysLeft
            // 
            this.txtDaysLeft.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txtDaysLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDaysLeft.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaysLeft.Location = new System.Drawing.Point(256, 52);
            this.txtDaysLeft.Name = "txtDaysLeft";
            this.txtDaysLeft.ReadOnly = true;
            this.txtDaysLeft.Size = new System.Drawing.Size(84, 18);
            this.txtDaysLeft.TabIndex = 19;
            // 
            // btnReturnLoan
            // 
            this.btnReturnLoan.BackColor = System.Drawing.Color.MediumBlue;
            this.btnReturnLoan.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReturnLoan.FlatAppearance.BorderSize = 0;
            this.btnReturnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnLoan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnLoan.ForeColor = System.Drawing.Color.White;
            this.btnReturnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnLoan.Image")));
            this.btnReturnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnLoan.Location = new System.Drawing.Point(458, 425);
            this.btnReturnLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(283, 39);
            this.btnReturnLoan.TabIndex = 31;
            this.btnReturnLoan.Text = "  Return Loan";
            this.btnReturnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnLoan.UseVisualStyleBackColor = false;
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(445, 382);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(306, 36);
            this.lblMessage.TabIndex = 47;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label2.TabIndex = 48;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnReturnLoan);
            this.Controls.Add(this.pnlLoanInfo);
            this.Controls.Add(this.pnlBookInfo);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCReturnBook";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCReturnBook_VisibleChanged);
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            this.pnlLoanInfo.ResumeLayout(false);
            this.pnlLoanInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Panel pnlLoanInfo;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.TextBox txtLoanDate;
        private System.Windows.Forms.TextBox txtDaysLeft;
        private System.Windows.Forms.Button btnReturnLoan;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.TextBox txtMember;
        private System.Windows.Forms.Label lblBookCopy;
        private System.Windows.Forms.TextBox txtBookCopy;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturned;
        private System.Windows.Forms.Label lblReturned;
        private System.Windows.Forms.Label lblDaysLeft;
        private System.Windows.Forms.TextBox txtOnTime;
        private System.Windows.Forms.Label lblOnTime;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label lblDebt;
    }
}
