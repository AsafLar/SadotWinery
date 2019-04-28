namespace Sadot
{
    partial class PasswordRecovery
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.lblPermission = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPassToSetPassword = new System.Windows.Forms.Button();
            this.pnlEnterUserDetails = new System.Windows.Forms.Panel();
            this.pnlNewPass.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEnterUserDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboPermission
            // 
            this.cboPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Items.AddRange(new object[] {
            "משתמש",
            "מנהל"});
            this.cboPermission.Location = new System.Drawing.Point(65, 119);
            this.cboPermission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.Size = new System.Drawing.Size(230, 33);
            this.cboPermission.TabIndex = 37;
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblPermission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPermission.Location = new System.Drawing.Point(382, 126);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(104, 26);
            this.lblPermission.TabIndex = 36;
            this.lblPermission.Text = "הרשאות :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(40, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(615, 29);
            this.lblTitle.TabIndex = 35;
            this.lblTitle.Text = "לצורך שחזור הסיסמא הכנס את שם המשתמש וההרשאה שלו";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(65, 124);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(230, 32);
            this.txtConfirmPassword.TabIndex = 33;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblConfirmPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConfirmPassword.Location = new System.Drawing.Point(382, 130);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(155, 26);
            this.lblConfirmPassword.TabIndex = 32;
            this.lblConfirmPassword.Text = "אימות סיסמא :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPassword.Location = new System.Drawing.Point(65, 71);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 32);
            this.txtPassword.TabIndex = 31;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtUserName.Location = new System.Drawing.Point(65, 65);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(230, 32);
            this.txtUserName.TabIndex = 30;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(382, 77);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 26);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "סיסמא :";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(382, 71);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(137, 26);
            this.lblUserName.TabIndex = 28;
            this.lblUserName.Text = "שם משתמש :";
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Controls.Add(this.panel2);
            this.pnlNewPass.Controls.Add(this.btnUpdatePassword);
            this.pnlNewPass.Controls.Add(this.lblPassword);
            this.pnlNewPass.Controls.Add(this.txtPassword);
            this.pnlNewPass.Controls.Add(this.lblConfirmPassword);
            this.pnlNewPass.Controls.Add(this.txtConfirmPassword);
            this.pnlNewPass.Location = new System.Drawing.Point(12, 265);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(661, 252);
            this.pnlNewPass.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(418, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 36);
            this.panel2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(16, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "בחירת סיסמא חדשה";
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdatePassword.Location = new System.Drawing.Point(161, 179);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(306, 59);
            this.btnUpdatePassword.TabIndex = 42;
            this.btnUpdatePassword.Text = "עדכון סיסמא";
            this.btnUpdatePassword.UseVisualStyleBackColor = true;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 39);
            this.panel1.TabIndex = 40;
            // 
            // btnPassToSetPassword
            // 
            this.btnPassToSetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPassToSetPassword.Location = new System.Drawing.Point(161, 170);
            this.btnPassToSetPassword.Name = "btnPassToSetPassword";
            this.btnPassToSetPassword.Size = new System.Drawing.Size(306, 59);
            this.btnPassToSetPassword.TabIndex = 41;
            this.btnPassToSetPassword.Text = "עבור להגדרת סיסמא חדשה";
            this.btnPassToSetPassword.UseVisualStyleBackColor = true;
            this.btnPassToSetPassword.Click += new System.EventHandler(this.btnPassToSetPassword_Click);
            // 
            // pnlEnterUserDetails
            // 
            this.pnlEnterUserDetails.Controls.Add(this.lblPermission);
            this.pnlEnterUserDetails.Controls.Add(this.btnPassToSetPassword);
            this.pnlEnterUserDetails.Controls.Add(this.lblUserName);
            this.pnlEnterUserDetails.Controls.Add(this.panel1);
            this.pnlEnterUserDetails.Controls.Add(this.txtUserName);
            this.pnlEnterUserDetails.Controls.Add(this.cboPermission);
            this.pnlEnterUserDetails.Location = new System.Drawing.Point(12, 12);
            this.pnlEnterUserDetails.Name = "pnlEnterUserDetails";
            this.pnlEnterUserDetails.Size = new System.Drawing.Size(661, 247);
            this.pnlEnterUserDetails.TabIndex = 42;
            // 
            // PasswordRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 529);
            this.Controls.Add(this.pnlEnterUserDetails);
            this.Controls.Add(this.pnlNewPass);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PasswordRecovery";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "שחזור סיסמא";
            this.Load += new System.EventHandler(this.AdminPasswordRecovery_Load);
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlEnterUserDetails.ResumeLayout(false);
            this.pnlEnterUserDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnUpdateUserPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlNewPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdatePassword;
        private System.Windows.Forms.Button btnPassToSetPassword;
        private System.Windows.Forms.Panel pnlEnterUserDetails;
        private System.Windows.Forms.Panel panel2;
    }
}