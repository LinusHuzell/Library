namespace Library.UserControls.Books
{
    partial class UCBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBook));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlBookInfo = new System.Windows.Forms.Panel();
            this.lblRequired4 = new System.Windows.Forms.Label();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.lvBookAuthors = new System.Windows.Forms.ListView();
            this.chBookAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSelectAuthor = new System.Windows.Forms.Button();
            this.lvSelectAuthor = new System.Windows.Forms.ListView();
            this.column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnAddBookCopy = new System.Windows.Forms.Button();
            this.lvBookCopies = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.pbNew = new System.Windows.Forms.PictureBox();
            this.pnlBookInfo.SuspendLayout();
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
            this.lblTitle.Text = "Add New Book";
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
            this.pnlBookInfo.BackColor = System.Drawing.Color.LightBlue;
            this.pnlBookInfo.Controls.Add(this.lblRequired4);
            this.pnlBookInfo.Controls.Add(this.lblRequired3);
            this.pnlBookInfo.Controls.Add(this.lblRequired2);
            this.pnlBookInfo.Controls.Add(this.lblRequired1);
            this.pnlBookInfo.Controls.Add(this.lvBookAuthors);
            this.pnlBookInfo.Controls.Add(this.txtYear);
            this.pnlBookInfo.Controls.Add(this.lblYear);
            this.pnlBookInfo.Controls.Add(this.btnSave);
            this.pnlBookInfo.Controls.Add(this.btnRemove);
            this.pnlBookInfo.Controls.Add(this.lblDescription);
            this.pnlBookInfo.Controls.Add(this.lblAuthors);
            this.pnlBookInfo.Controls.Add(this.txtTitle);
            this.pnlBookInfo.Controls.Add(this.lblBookTitle);
            this.pnlBookInfo.Controls.Add(this.txtISBN);
            this.pnlBookInfo.Controls.Add(this.lblISBN);
            this.pnlBookInfo.Controls.Add(this.txtDescription);
            this.pnlBookInfo.Location = new System.Drawing.Point(346, 57);
            this.pnlBookInfo.Name = "pnlBookInfo";
            this.pnlBookInfo.Size = new System.Drawing.Size(460, 424);
            this.pnlBookInfo.TabIndex = 25;
            // 
            // lblRequired4
            // 
            this.lblRequired4.AutoSize = true;
            this.lblRequired4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired4.ForeColor = System.Drawing.Color.Red;
            this.lblRequired4.Location = new System.Drawing.Point(65, 227);
            this.lblRequired4.Name = "lblRequired4";
            this.lblRequired4.Size = new System.Drawing.Size(17, 21);
            this.lblRequired4.TabIndex = 39;
            this.lblRequired4.Text = "*";
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired3.ForeColor = System.Drawing.Color.Red;
            this.lblRequired3.Location = new System.Drawing.Point(65, 192);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(17, 21);
            this.lblRequired3.TabIndex = 38;
            this.lblRequired3.Text = "*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(68, 157);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(17, 21);
            this.lblRequired2.TabIndex = 37;
            this.lblRequired2.Text = "*";
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(91, 15);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(17, 21);
            this.lblRequired1.TabIndex = 36;
            this.lblRequired1.Text = "*";
            // 
            // lvBookAuthors
            // 
            this.lvBookAuthors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBookAuthors});
            this.lvBookAuthors.FullRowSelect = true;
            this.lvBookAuthors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvBookAuthors.Location = new System.Drawing.Point(135, 15);
            this.lvBookAuthors.MultiSelect = false;
            this.lvBookAuthors.Name = "lvBookAuthors";
            this.lvBookAuthors.Size = new System.Drawing.Size(184, 131);
            this.lvBookAuthors.TabIndex = 29;
            this.lvBookAuthors.UseCompatibleStateImageBehavior = false;
            this.lvBookAuthors.View = System.Windows.Forms.View.Details;
            // 
            // chBookAuthors
            // 
            this.chBookAuthors.Text = "Authors of book";
            this.chBookAuthors.Width = 175;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(135, 229);
            this.txtYear.Margin = new System.Windows.Forms.Padding(10);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(184, 23);
            this.txtYear.TabIndex = 32;
            this.txtYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYear_KeyDown);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.Black;
            this.lblYear.Location = new System.Drawing.Point(23, 227);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 21);
            this.lblYear.TabIndex = 34;
            this.lblYear.Text = "Year:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(106, 379);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 34);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "  Save Book";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Brown;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.Location = new System.Drawing.Point(324, 15);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 30);
            this.btnRemove.TabIndex = 35;
            this.btnRemove.Text = "Remove  ";
            this.btnRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(23, 261);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 21);
            this.lblDescription.TabIndex = 30;
            this.lblDescription.Text = "Description:";
            // 
            // lblAuthors
            // 
            this.lblAuthors.AutoSize = true;
            this.lblAuthors.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.ForeColor = System.Drawing.Color.Black;
            this.lblAuthors.Location = new System.Drawing.Point(23, 15);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(74, 21);
            this.lblAuthors.TabIndex = 26;
            this.lblAuthors.Text = "Authors:";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(135, 194);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(10);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(184, 23);
            this.txtTitle.TabIndex = 31;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTitle_KeyDown);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(23, 192);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(48, 21);
            this.lblBookTitle.TabIndex = 29;
            this.lblBookTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(135, 159);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(10);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(184, 23);
            this.txtISBN.TabIndex = 30;
            this.txtISBN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtISBN_KeyDown);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.ForeColor = System.Drawing.Color.Black;
            this.lblISBN.Location = new System.Drawing.Point(23, 157);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 21);
            this.lblISBN.TabIndex = 28;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(135, 263);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(10);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(184, 104);
            this.txtDescription.TabIndex = 33;
            // 
            // btnSelectAuthor
            // 
            this.btnSelectAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
            this.btnSelectAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSelectAuthor.FlatAppearance.BorderSize = 0;
            this.btnSelectAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAuthor.ForeColor = System.Drawing.Color.White;
            this.btnSelectAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectAuthor.Image")));
            this.btnSelectAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectAuthor.Location = new System.Drawing.Point(50, 251);
            this.btnSelectAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectAuthor.Name = "btnSelectAuthor";
            this.btnSelectAuthor.Size = new System.Drawing.Size(262, 30);
            this.btnSelectAuthor.TabIndex = 28;
            this.btnSelectAuthor.Text = "Select Author";
            this.btnSelectAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSelectAuthor.UseVisualStyleBackColor = false;
            this.btnSelectAuthor.Click += new System.EventHandler(this.btnSelectAuthor_Click);
            // 
            // lvSelectAuthor
            // 
            this.lvSelectAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSelectAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column});
            this.lvSelectAuthor.FullRowSelect = true;
            this.lvSelectAuthor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSelectAuthor.Location = new System.Drawing.Point(50, 88);
            this.lvSelectAuthor.MultiSelect = false;
            this.lvSelectAuthor.Name = "lvSelectAuthor";
            this.lvSelectAuthor.Size = new System.Drawing.Size(262, 157);
            this.lvSelectAuthor.TabIndex = 27;
            this.lvSelectAuthor.UseCompatibleStateImageBehavior = false;
            this.lvSelectAuthor.View = System.Windows.Forms.View.Details;
            this.lvSelectAuthor.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lvSelectAuthor_ColumnWidthChanging);
            this.lvSelectAuthor.DoubleClick += new System.EventHandler(this.btnSelectAuthor_Click);
            // 
            // column
            // 
            this.column.Text = "Authors";
            this.column.Width = 245;
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.ForeColor = System.Drawing.Color.Gray;
            this.txtFilter.Location = new System.Drawing.Point(50, 57);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(262, 25);
            this.txtFilter.TabIndex = 26;
            this.txtFilter.Text = "Filter on name...";
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(21, 288);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(309, 36);
            this.lblMessage.TabIndex = 34;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMessage.Visible = false;
            // 
            // btnAddBookCopy
            // 
            this.btnAddBookCopy.BackColor = System.Drawing.Color.Green;
            this.btnAddBookCopy.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddBookCopy.FlatAppearance.BorderSize = 0;
            this.btnAddBookCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBookCopy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookCopy.ForeColor = System.Drawing.Color.White;
            this.btnAddBookCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBookCopy.Image")));
            this.btnAddBookCopy.Location = new System.Drawing.Point(182, 324);
            this.btnAddBookCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBookCopy.Name = "btnAddBookCopy";
            this.btnAddBookCopy.Size = new System.Drawing.Size(130, 30);
            this.btnAddBookCopy.TabIndex = 43;
            this.btnAddBookCopy.Text = "  Add Book Copy";
            this.btnAddBookCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBookCopy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBookCopy.UseVisualStyleBackColor = false;
            this.btnAddBookCopy.Click += new System.EventHandler(this.btnAddBookCopy_Click);
            // 
            // lvBookCopies
            // 
            this.lvBookCopies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvBookCopies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvBookCopies.FullRowSelect = true;
            this.lvBookCopies.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvBookCopies.Location = new System.Drawing.Point(50, 357);
            this.lvBookCopies.MultiSelect = false;
            this.lvBookCopies.Name = "lvBookCopies";
            this.lvBookCopies.Size = new System.Drawing.Size(262, 124);
            this.lvBookCopies.TabIndex = 42;
            this.lvBookCopies.UseCompatibleStateImageBehavior = false;
            this.lvBookCopies.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Book Copies";
            this.columnHeader1.Width = 245;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 26);
            this.label2.TabIndex = 44;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbNew
            // 
            this.pbNew.Image = ((System.Drawing.Image)(resources.GetObject("pbNew.Image")));
            this.pbNew.Location = new System.Drawing.Point(287, 4);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(40, 42);
            this.pbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNew.TabIndex = 45;
            this.pbNew.TabStop = false;
            // 
            // UCBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pbNew);
            this.Controls.Add(this.btnAddBookCopy);
            this.Controls.Add(this.lvBookCopies);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lvSelectAuthor);
            this.Controls.Add(this.btnSelectAuthor);
            this.Controls.Add(this.pnlBookInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCBook";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCAddBook_VisibleChanged);
            this.pnlBookInfo.ResumeLayout(false);
            this.pnlBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlBookInfo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Button btnSelectAuthor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListView lvSelectAuthor;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ListView lvBookAuthors;
        private System.Windows.Forms.ColumnHeader column;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ColumnHeader chBookAuthors;
        private System.Windows.Forms.Label lblRequired4;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Button btnAddBookCopy;
        private System.Windows.Forms.ListView lvBookCopies;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbNew;
    }
}
