namespace Library.UserControls.Loans
{
    partial class UCLoans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLoans));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewLoan = new System.Windows.Forms.Button();
            this.btnReturnLoan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.lblTitle.Text = "Loans";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnNewLoan.Location = new System.Drawing.Point(232, 300);
            this.btnNewLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewLoan.Name = "btnNewLoan";
            this.btnNewLoan.Size = new System.Drawing.Size(150, 60);
            this.btnNewLoan.TabIndex = 11;
            this.btnNewLoan.Text = "  New Loan";
            this.btnNewLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewLoan.UseVisualStyleBackColor = false;
            this.btnNewLoan.Click += new System.EventHandler(this.btnNewLoan_Click);
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
            this.btnReturnLoan.Location = new System.Drawing.Point(415, 300);
            this.btnReturnLoan.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturnLoan.Name = "btnReturnLoan";
            this.btnReturnLoan.Size = new System.Drawing.Size(150, 60);
            this.btnReturnLoan.TabIndex = 12;
            this.btnReturnLoan.Text = "  Return Loan";
            this.btnReturnLoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnLoan.UseVisualStyleBackColor = false;
            this.btnReturnLoan.Click += new System.EventHandler(this.btnReturnLoan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(0, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(820, 26);
            this.label2.TabIndex = 14;
            this.label2.Text = "Created by Linus Huzell and Philip Öhlund ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UCLoans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturnLoan);
            this.Controls.Add(this.btnNewLoan);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLoans";
            this.Size = new System.Drawing.Size(820, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewLoan;
        private System.Windows.Forms.Button btnReturnLoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}
