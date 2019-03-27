namespace Library.UserControls.Members
{
    partial class UCMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMember));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMemberInfo = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPersonalID = new System.Windows.Forms.Label();
            this.txtPersonalID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pbNew = new System.Windows.Forms.PictureBox();
            this.pbEdit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).BeginInit();
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
            this.lblTitle.Text = "Add New Member";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMemberInfo
            // 
            this.pnlMemberInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.pnlMemberInfo.Controls.Add(this.lblUsername);
            this.pnlMemberInfo.Controls.Add(this.txtUsername);
            this.pnlMemberInfo.Controls.Add(this.txtLastName);
            this.pnlMemberInfo.Controls.Add(this.txtFirstName);
            this.pnlMemberInfo.Controls.Add(this.lblMessage);
            this.pnlMemberInfo.Controls.Add(this.label1);
            this.pnlMemberInfo.Controls.Add(this.btnSave);
            this.pnlMemberInfo.Controls.Add(this.lblPersonalID);
            this.pnlMemberInfo.Controls.Add(this.txtPersonalID);
            this.pnlMemberInfo.Location = new System.Drawing.Point(184, 144);
            this.pnlMemberInfo.Name = "pnlMemberInfo";
            this.pnlMemberInfo.Size = new System.Drawing.Size(441, 207);
            this.pnlMemberInfo.TabIndex = 27;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(27, 62);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(91, 21);
            this.lblUsername.TabIndex = 33;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(128, 63);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(10);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(261, 23);
            this.txtUsername.TabIndex = 11;
            this.txtUsername.Text = "Username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Gray;
            this.txtLastName.Location = new System.Drawing.Point(262, 97);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(10);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(127, 23);
            this.txtLastName.TabIndex = 13;
            this.txtLastName.Text = "Last Name";
            this.txtLastName.Enter += new System.EventHandler(this.txtLastName_Enter);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLastName_KeyDown);
            this.txtLastName.Leave += new System.EventHandler(this.txtLastName_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Gray;
            this.txtFirstName.Location = new System.Drawing.Point(128, 97);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(10);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(127, 23);
            this.txtFirstName.TabIndex = 12;
            this.txtFirstName.Text = "First Name";
            this.txtFirstName.Enter += new System.EventHandler(this.txtFirstName_Enter);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstName_KeyDown);
            this.txtFirstName.Leave += new System.EventHandler(this.txtFirstName_Leave);
            // 
            // lblMessage
            // 
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(74, 181);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(363, 17);
            this.lblMessage.TabIndex = 30;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Name:";
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
            this.btnSave.Location = new System.Drawing.Point(137, 137);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(239, 34);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "  Save Member";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonalID
            // 
            this.lblPersonalID.AutoSize = true;
            this.lblPersonalID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalID.ForeColor = System.Drawing.Color.White;
            this.lblPersonalID.Location = new System.Drawing.Point(17, 28);
            this.lblPersonalID.Name = "lblPersonalID";
            this.lblPersonalID.Size = new System.Drawing.Size(101, 21);
            this.lblPersonalID.TabIndex = 26;
            this.lblPersonalID.Text = "Personal ID:";
            // 
            // txtPersonalID
            // 
            this.txtPersonalID.BackColor = System.Drawing.SystemColors.Window;
            this.txtPersonalID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPersonalID.ForeColor = System.Drawing.Color.Gray;
            this.txtPersonalID.Location = new System.Drawing.Point(128, 29);
            this.txtPersonalID.Margin = new System.Windows.Forms.Padding(10);
            this.txtPersonalID.Name = "txtPersonalID";
            this.txtPersonalID.Size = new System.Drawing.Size(261, 23);
            this.txtPersonalID.TabIndex = 10;
            this.txtPersonalID.Text = "YYMMDD-XXXX";
            this.txtPersonalID.Enter += new System.EventHandler(this.txtPersonalID_Enter);
            this.txtPersonalID.Leave += new System.EventHandler(this.txtPersonalID_Leave);
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
            this.btnBack.TabIndex = 28;
            this.btnBack.TabStop = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pbNew
            // 
            this.pbNew.Image = ((System.Drawing.Image)(resources.GetObject("pbNew.Image")));
            this.pbNew.Location = new System.Drawing.Point(263, 4);
            this.pbNew.Name = "pbNew";
            this.pbNew.Size = new System.Drawing.Size(43, 47);
            this.pbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNew.TabIndex = 38;
            this.pbNew.TabStop = false;
            // 
            // pbEdit
            // 
            this.pbEdit.Image = ((System.Drawing.Image)(resources.GetObject("pbEdit.Image")));
            this.pbEdit.Location = new System.Drawing.Point(293, 4);
            this.pbEdit.Name = "pbEdit";
            this.pbEdit.Size = new System.Drawing.Size(43, 47);
            this.pbEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEdit.TabIndex = 39;
            this.pbEdit.TabStop = false;
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
            // UCMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbEdit);
            this.Controls.Add(this.pbNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlMemberInfo);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCMember";
            this.Size = new System.Drawing.Size(820, 504);
            this.VisibleChanged += new System.EventHandler(this.UCAddMember_VisibleChanged);
            this.pnlMemberInfo.ResumeLayout(false);
            this.pnlMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMemberInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPersonalID;
        private System.Windows.Forms.TextBox txtPersonalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pbNew;
        private System.Windows.Forms.PictureBox pbEdit;
        private System.Windows.Forms.Label label2;
    }
}
