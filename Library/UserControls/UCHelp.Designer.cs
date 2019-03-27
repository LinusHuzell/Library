namespace Library.UserControls
{
    partial class UCHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHelp));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblRandomHelpText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPig = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.lblTitle.Text = "Help";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRandomHelpText
            // 
            this.lblRandomHelpText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomHelpText.Location = new System.Drawing.Point(100, 117);
            this.lblRandomHelpText.Name = "lblRandomHelpText";
            this.lblRandomHelpText.Size = new System.Drawing.Size(640, 138);
            this.lblRandomHelpText.TabIndex = 11;
            this.lblRandomHelpText.Text = resources.GetString("lblRandomHelpText.Text");
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
            // pbPig
            // 
            this.pbPig.Image = ((System.Drawing.Image)(resources.GetObject("pbPig.Image")));
            this.pbPig.Location = new System.Drawing.Point(340, 285);
            this.pbPig.Name = "pbPig";
            this.pbPig.Size = new System.Drawing.Size(160, 151);
            this.pbPig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPig.TabIndex = 15;
            this.pbPig.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(590, 272);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // UCHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pbPig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRandomHelpText);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCHelp";
            this.Size = new System.Drawing.Size(820, 504);
            ((System.ComponentModel.ISupportInitialize)(this.pbPig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblRandomHelpText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbPig;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
