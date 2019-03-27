namespace Library.User_Controls
{
    partial class TEMPLATE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TEMPLATE));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbtnMember = new System.Windows.Forms.RadioButton();
            this.rbtnBook = new System.Windows.Forms.RadioButton();
            this.rbtnAuthor = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.pb = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.lblTextBox = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.lblRequired1 = new System.Windows.Forms.Label();
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
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInput.Location = new System.Drawing.Point(248, 57);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(181, 25);
            this.txtSearchInput.TabIndex = 8;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
            this.btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn.FlatAppearance.BorderSize = 0;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn.Location = new System.Drawing.Point(1053, 494);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(110, 30);
            this.btn.TabIndex = 7;
            this.btn.Text = "Button";
            this.btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(585, 181);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 25);
            this.comboBox1.TabIndex = 17;
            // 
            // rbtnMember
            // 
            this.rbtnMember.AutoSize = true;
            this.rbtnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnMember.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMember.Location = new System.Drawing.Point(331, 415);
            this.rbtnMember.Name = "rbtnMember";
            this.rbtnMember.Size = new System.Drawing.Size(76, 21);
            this.rbtnMember.TabIndex = 16;
            this.rbtnMember.TabStop = true;
            this.rbtnMember.Text = "Member";
            this.rbtnMember.UseVisualStyleBackColor = true;
            // 
            // rbtnBook
            // 
            this.rbtnBook.AutoSize = true;
            this.rbtnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBook.Location = new System.Drawing.Point(274, 415);
            this.rbtnBook.Name = "rbtnBook";
            this.rbtnBook.Size = new System.Drawing.Size(56, 21);
            this.rbtnBook.TabIndex = 15;
            this.rbtnBook.TabStop = true;
            this.rbtnBook.Text = "Book";
            this.rbtnBook.UseVisualStyleBackColor = true;
            // 
            // rbtnAuthor
            // 
            this.rbtnAuthor.AutoSize = true;
            this.rbtnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnAuthor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAuthor.Location = new System.Drawing.Point(207, 415);
            this.rbtnAuthor.Name = "rbtnAuthor";
            this.rbtnAuthor.Size = new System.Drawing.Size(68, 21);
            this.rbtnAuthor.TabIndex = 14;
            this.rbtnAuthor.TabStop = true;
            this.rbtnAuthor.Text = "Author";
            this.rbtnAuthor.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 334);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(600, 29);
            this.textBox1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(136)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(207, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(600, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "   Search...";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Brown;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRed.FlatAppearance.BorderSize = 0;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.ForeColor = System.Drawing.Color.White;
            this.btnRed.Image = ((System.Drawing.Image)(resources.GetObject("btnRed.Image")));
            this.btnRed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRed.Location = new System.Drawing.Point(1013, 415);
            this.btnRed.Margin = new System.Windows.Forms.Padding(2);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(150, 60);
            this.btnRed.TabIndex = 19;
            this.btnRed.Text = "  Return Loan";
            this.btnRed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnGreen.FlatAppearance.BorderSize = 0;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.ForeColor = System.Drawing.Color.White;
            this.btnGreen.Image = ((System.Drawing.Image)(resources.GetObject("btnGreen.Image")));
            this.btnGreen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreen.Location = new System.Drawing.Point(859, 415);
            this.btnGreen.Margin = new System.Windows.Forms.Padding(2);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(150, 60);
            this.btnGreen.TabIndex = 18;
            this.btnGreen.Text = "  New Loan";
            this.btnGreen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // pb
            // 
            this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
            this.pb.Location = new System.Drawing.Point(870, 41);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(293, 151);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb.TabIndex = 20;
            this.pb.TabStop = false;
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
            this.btnBack.Location = new System.Drawing.Point(974, 494);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(35, 32);
            this.btnBack.TabIndex = 21;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.DarkGray;
            this.pnl.Location = new System.Drawing.Point(107, 521);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(300, 140);
            this.pnl.TabIndex = 22;
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextBox.Location = new System.Drawing.Point(394, 245);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(120, 21);
            this.lblTextBox.TabIndex = 24;
            this.lblTextBox.Text = "Text Box Label";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(451, 294);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 25;
            this.lblMessage.Text = "Message";
            this.lblMessage.Visible = false;
            // 
            // lv
            // 
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv.Location = new System.Drawing.Point(521, 480);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(299, 210);
            this.lv.TabIndex = 26;
            this.lv.UseCompatibleStateImageBehavior = false;
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(450, 181);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(17, 21);
            this.lblRequired1.TabIndex = 37;
            this.lblRequired1.Text = "*";
            // 
            // TEMPLATE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRequired1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblTextBox);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbtnMember);
            this.Controls.Add(this.rbtnBook);
            this.Controls.Add(this.rbtnAuthor);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearchInput);
            this.Controls.Add(this.btn);
            this.Name = "TEMPLATE";
            this.Size = new System.Drawing.Size(1250, 722);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbtnMember;
        private System.Windows.Forms.RadioButton rbtnBook;
        private System.Windows.Forms.RadioButton rbtnAuthor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.Label lblRequired1;
    }
}
