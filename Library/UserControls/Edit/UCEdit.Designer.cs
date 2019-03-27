namespace Library.UserControls.Books
{
    partial class UCEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCEdit));
            this.lblTitle = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.rbtnAuthor = new System.Windows.Forms.RadioButton();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.lvSearchAuthor = new System.Windows.Forms.ListView();
            this.chAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNext = new System.Windows.Forms.Button();
            this.lvSearchBook = new System.Windows.Forms.ListView();
            this.chBook = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAuthors = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearchInit = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pbEditBook = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.drdwnBookSearchBy = new System.Windows.Forms.ComboBox();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditBook)).BeginInit();
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
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // headerLabel
            // 
            this.headerLabel.BackColor = System.Drawing.Color.Transparent;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Black;
            this.headerLabel.Location = new System.Drawing.Point(0, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(820, 54);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Edit book or author";
            this.headerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Enabled = false;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(113, 369);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(460, 29);
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
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(578, 369);
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
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBook.Location = new System.Drawing.Point(180, 343);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(51, 19);
            this.rbtnBook.TabIndex = 17;
            this.rbtnBook.TabStop = true;
            this.rbtnBook.Text = "Book";
            this.rbtnBook.UseVisualStyleBackColor = true;
            this.rbtnBook.CheckedChanged += new System.EventHandler(this.rbtnBook_CheckedChanged);
            // 
            // rbtnAuthor
            // 
            this.rbtnAuthor.AutoSize = true;
            this.rbtnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAuthor.Location = new System.Drawing.Point(113, 343);
            this.rbtnAuthor.Name = "rbtnAuthor";
            this.rbtnAuthor.Size = new System.Drawing.Size(61, 19);
            this.rbtnAuthor.TabIndex = 16;
            this.rbtnAuthor.TabStop = true;
            this.rbtnAuthor.Text = "Author";
            this.rbtnAuthor.UseVisualStyleBackColor = true;
            this.rbtnAuthor.CheckedChanged += new System.EventHandler(this.rbtnAuthor_CheckedChanged);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(162)))), ((int)(((byte)(212)))));
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.Location = new System.Drawing.Point(580, 72);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(124, 36);
            this.btnAddBook.TabIndex = 19;
            this.btnAddBook.Text = "  Add Book";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(162)))), ((int)(((byte)(212)))));
            this.btnAddAuthor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddAuthor.FlatAppearance.BorderSize = 0;
            this.btnAddAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.White;
            this.btnAddAuthor.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAuthor.Image")));
            this.btnAddAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddAuthor.Location = new System.Drawing.Point(452, 72);
            this.btnAddAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(124, 36);
            this.btnAddAuthor.TabIndex = 20;
            this.btnAddAuthor.Text = "  Add Author";
            this.btnAddAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAuthor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // lvSearchAuthor
            // 
            this.lvSearchAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSearchAuthor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAuthor});
            this.lvSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearchAuthor.FullRowSelect = true;
            this.lvSearchAuthor.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSearchAuthor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvSearchAuthor.Location = new System.Drawing.Point(113, 121);
            this.lvSearchAuthor.MultiSelect = false;
            this.lvSearchAuthor.Name = "lvSearchAuthor";
            this.lvSearchAuthor.Size = new System.Drawing.Size(592, 216);
            this.lvSearchAuthor.TabIndex = 27;
            this.lvSearchAuthor.UseCompatibleStateImageBehavior = false;
            this.lvSearchAuthor.View = System.Windows.Forms.View.Details;
            this.lvSearchAuthor.Visible = false;
            this.lvSearchAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSearchAuthor_KeyDown);
            this.lvSearchAuthor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnNext_Click);
            // 
            // chAuthor
            // 
            this.chAuthor.Text = "Author";
            this.chAuthor.Width = 575;
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
            this.btnNext.Location = new System.Drawing.Point(555, 417);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 47);
            this.btnNext.TabIndex = 28;
            this.btnNext.Text = "Edit";
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lvSearchBook
            // 
            this.lvSearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSearchBook.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chBook,
            this.chAuthors,
            this.chYear,
            this.chISBN});
            this.lvSearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSearchBook.FullRowSelect = true;
            this.lvSearchBook.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSearchBook.Location = new System.Drawing.Point(113, 121);
            this.lvSearchBook.MultiSelect = false;
            this.lvSearchBook.Name = "lvSearchBook";
            this.lvSearchBook.Size = new System.Drawing.Size(592, 216);
            this.lvSearchBook.TabIndex = 29;
            this.lvSearchBook.UseCompatibleStateImageBehavior = false;
            this.lvSearchBook.View = System.Windows.Forms.View.Details;
            this.lvSearchBook.Visible = false;
            this.lvSearchBook.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvSearchBook_KeyDown);
            this.lvSearchBook.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.btnNext_Click);
            // 
            // chBook
            // 
            this.chBook.Text = "Title";
            this.chBook.Width = 290;
            // 
            // chAuthors
            // 
            this.chAuthors.Text = "Authors";
            this.chAuthors.Width = 150;
            // 
            // chYear
            // 
            this.chYear.Text = "Year";
            this.chYear.Width = 40;
            // 
            // chISBN
            // 
            this.chISBN.Text = "ISBN";
            this.chISBN.Width = 95;
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.lblSearchInit);
            this.pnlSearch.Location = new System.Drawing.Point(113, 121);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(590, 216);
            this.pnlSearch.TabIndex = 30;
            // 
            // lblSearchInit
            // 
            this.lblSearchInit.AutoSize = true;
            this.lblSearchInit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInit.Location = new System.Drawing.Point(179, 103);
            this.lblSearchInit.Name = "lblSearchInit";
            this.lblSearchInit.Size = new System.Drawing.Size(184, 20);
            this.lblSearchInit.TabIndex = 0;
            this.lblSearchInit.Text = "Choose type to edit below";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(110, 417);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(424, 47);
            this.lblMessage.TabIndex = 31;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // pbEditBook
            // 
            this.pbEditBook.Image = ((System.Drawing.Image)(resources.GetObject("pbEditBook.Image")));
            this.pbEditBook.Location = new System.Drawing.Point(256, 4);
            this.pbEditBook.Name = "pbEditBook";
            this.pbEditBook.Size = new System.Drawing.Size(43, 47);
            this.pbEditBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEditBook.TabIndex = 39;
            this.pbEditBook.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 26);
            this.label2.TabIndex = 40;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // drdwnBookSearchBy
            // 
            this.drdwnBookSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drdwnBookSearchBy.FormattingEnabled = true;
            this.drdwnBookSearchBy.Items.AddRange(new object[] {
            "Search by title",
            "Search by author"});
            this.drdwnBookSearchBy.Location = new System.Drawing.Point(237, 342);
            this.drdwnBookSearchBy.Name = "drdwnBookSearchBy";
            this.drdwnBookSearchBy.Size = new System.Drawing.Size(121, 23);
            this.drdwnBookSearchBy.TabIndex = 41;
            this.drdwnBookSearchBy.Visible = false;
            this.drdwnBookSearchBy.SelectedValueChanged += new System.EventHandler(this.drdwnBookSearchBy_SelectedValueChanged);
            // 
            // UCEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.drdwnBookSearchBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbEditBook);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.lvSearchAuthor);
            this.Controls.Add(this.lvSearchBook);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.rbtnBook);
            this.Controls.Add(this.rbtnAuthor);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCEdit";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCBooks_VisibleChanged);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.RadioButton rbtnAuthor;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.ListView lvSearchAuthor;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView lvSearchBook;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.ColumnHeader chAuthor;
        private System.Windows.Forms.ColumnHeader chBook;
        private System.Windows.Forms.ColumnHeader chAuthors;
        private System.Windows.Forms.ColumnHeader chYear;
        private System.Windows.Forms.ColumnHeader chISBN;
        private System.Windows.Forms.Label lblSearchInit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbEditBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox drdwnBookSearchBy;
    }
}
