namespace Sadot
{
    partial class ManageUsers
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
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPermission = new System.Windows.Forms.Label();
            this.cboPermission = new System.Windows.Forms.ComboBox();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpNewUser = new System.Windows.Forms.TabPage();
            this.btnRegNewUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tpUpdate = new System.Windows.Forms.TabPage();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.cboUsersNames = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cboPermissionUpdate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConfirmPasswordUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpNewUser.SuspendLayout();
            this.tpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtPassword.Location = new System.Drawing.Point(60, 177);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPassword.Size = new System.Drawing.Size(256, 32);
            this.txtPassword.TabIndex = 19;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtUserName.Location = new System.Drawing.Point(60, 114);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUserName.Size = new System.Drawing.Size(256, 32);
            this.txtUserName.TabIndex = 18;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(395, 179);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPassword.Size = new System.Drawing.Size(83, 26);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "סיסמא:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUserName.Location = new System.Drawing.Point(395, 116);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUserName.Size = new System.Drawing.Size(130, 26);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "שם משתמש:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.txtConfirmPassword.Location = new System.Drawing.Point(60, 242);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtConfirmPassword.Size = new System.Drawing.Size(256, 32);
            this.txtConfirmPassword.TabIndex = 22;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblConfirmPassword.Location = new System.Drawing.Point(395, 244);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblConfirmPassword.Size = new System.Drawing.Size(148, 26);
            this.lblConfirmPassword.TabIndex = 21;
            this.lblConfirmPassword.Text = "אימות סיסמא:";
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPermission.Location = new System.Drawing.Point(393, 310);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblPermission.Size = new System.Drawing.Size(97, 26);
            this.lblPermission.TabIndex = 26;
            this.lblPermission.Text = "הרשאות:";
            // 
            // cboPermission
            // 
            this.cboPermission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboPermission.FormattingEnabled = true;
            this.cboPermission.Items.AddRange(new object[] {
            "משתמש",
            "מנהל"});
            this.cboPermission.Location = new System.Drawing.Point(60, 308);
            this.cboPermission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPermission.Name = "cboPermission";
            this.cboPermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboPermission.Size = new System.Drawing.Size(256, 33);
            this.cboPermission.TabIndex = 27;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.tpNewUser);
            this.tcMain.Controls.Add(this.tpUpdate);
            this.tcMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tcMain.Location = new System.Drawing.Point(12, 88);
            this.tcMain.Name = "tcMain";
            this.tcMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcMain.RightToLeftLayout = true;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(607, 555);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 29;
            // 
            // tpNewUser
            // 
            this.tpNewUser.BackColor = System.Drawing.SystemColors.Control;
            this.tpNewUser.Controls.Add(this.btnRegNewUser);
            this.tpNewUser.Controls.Add(this.label5);
            this.tpNewUser.Controls.Add(this.lblUserName);
            this.tpNewUser.Controls.Add(this.lblPassword);
            this.tpNewUser.Controls.Add(this.txtUserName);
            this.tpNewUser.Controls.Add(this.txtPassword);
            this.tpNewUser.Controls.Add(this.cboPermission);
            this.tpNewUser.Controls.Add(this.lblConfirmPassword);
            this.tpNewUser.Controls.Add(this.lblPermission);
            this.tpNewUser.Controls.Add(this.txtConfirmPassword);
            this.tpNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tpNewUser.Location = new System.Drawing.Point(4, 5);
            this.tpNewUser.Name = "tpNewUser";
            this.tpNewUser.Padding = new System.Windows.Forms.Padding(3);
            this.tpNewUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpNewUser.Size = new System.Drawing.Size(599, 546);
            this.tpNewUser.TabIndex = 0;
            // 
            // btnRegNewUser
            // 
            this.btnRegNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRegNewUser.Location = new System.Drawing.Point(128, 420);
            this.btnRegNewUser.Name = "btnRegNewUser";
            this.btnRegNewUser.Size = new System.Drawing.Size(320, 80);
            this.btnRegNewUser.TabIndex = 51;
            this.btnRegNewUser.Text = "רישום משתמש";
            this.btnRegNewUser.UseVisualStyleBackColor = true;
            this.btnRegNewUser.Click += new System.EventHandler(this.btnRegNewUser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(154, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 37);
            this.label5.TabIndex = 50;
            this.label5.Text = "רישום משתמש חדש:";
            // 
            // tpUpdate
            // 
            this.tpUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.tpUpdate.Controls.Add(this.btnUpdateUser);
            this.tpUpdate.Controls.Add(this.cboUsersNames);
            this.tpUpdate.Controls.Add(this.lblTitle);
            this.tpUpdate.Controls.Add(this.cboPermissionUpdate);
            this.tpUpdate.Controls.Add(this.label1);
            this.tpUpdate.Controls.Add(this.txtConfirmPasswordUpdate);
            this.tpUpdate.Controls.Add(this.label2);
            this.tpUpdate.Controls.Add(this.txtPasswordUpdate);
            this.tpUpdate.Controls.Add(this.label3);
            this.tpUpdate.Controls.Add(this.label4);
            this.tpUpdate.Location = new System.Drawing.Point(4, 5);
            this.tpUpdate.Name = "tpUpdate";
            this.tpUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tpUpdate.Size = new System.Drawing.Size(599, 546);
            this.tpUpdate.TabIndex = 1;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateUser.Location = new System.Drawing.Point(140, 413);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(316, 90);
            this.btnUpdateUser.TabIndex = 51;
            this.btnUpdateUser.Text = "עדכון משתמש";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // cboUsersNames
            // 
            this.cboUsersNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsersNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsersNames.FormattingEnabled = true;
            this.cboUsersNames.Location = new System.Drawing.Point(75, 116);
            this.cboUsersNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUsersNames.Name = "cboUsersNames";
            this.cboUsersNames.Size = new System.Drawing.Size(256, 34);
            this.cboUsersNames.TabIndex = 50;
            this.cboUsersNames.SelectedIndexChanged += new System.EventHandler(this.cboUsersNames_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(195, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(207, 37);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "עדכון משתמש :";
            // 
            // cboPermissionUpdate
            // 
            this.cboPermissionUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermissionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPermissionUpdate.FormattingEnabled = true;
            this.cboPermissionUpdate.Items.AddRange(new object[] {
            "בחר הרשאה",
            "משתמש",
            "מנהל"});
            this.cboPermissionUpdate.Location = new System.Drawing.Point(74, 187);
            this.cboPermissionUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPermissionUpdate.Name = "cboPermissionUpdate";
            this.cboPermissionUpdate.Size = new System.Drawing.Size(256, 34);
            this.cboPermissionUpdate.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(410, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 46;
            this.label1.Text = "הרשאות:";
            // 
            // txtConfirmPasswordUpdate
            // 
            this.txtConfirmPasswordUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPasswordUpdate.Location = new System.Drawing.Point(75, 319);
            this.txtConfirmPasswordUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPasswordUpdate.Name = "txtConfirmPasswordUpdate";
            this.txtConfirmPasswordUpdate.Size = new System.Drawing.Size(256, 32);
            this.txtConfirmPasswordUpdate.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(410, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 26);
            this.label2.TabIndex = 43;
            this.label2.Text = "אימות סיסמא :";
            // 
            // txtPasswordUpdate
            // 
            this.txtPasswordUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordUpdate.Location = new System.Drawing.Point(75, 254);
            this.txtPasswordUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.Size = new System.Drawing.Size(256, 32);
            this.txtPasswordUpdate.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(410, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 26);
            this.label3.TabIndex = 40;
            this.label3.Text = "סיסמא :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(410, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 39;
            this.label4.Text = "שם משתמש:";
            // 
            // btnNewUser
            // 
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNewUser.Location = new System.Drawing.Point(6, 12);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(305, 70);
            this.btnNewUser.TabIndex = 30;
            this.btnNewUser.Text = "רישום משתמש חדש";
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdate.Location = new System.Drawing.Point(317, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(305, 70);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "עדכון סיסמא / הרשאות";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 648);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ManageUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ניהול משתמשים";
            this.Load += new System.EventHandler(this.NewUser_Load);
            this.tcMain.ResumeLayout(false);
            this.tpNewUser.ResumeLayout(false);
            this.tpNewUser.PerformLayout();
            this.tpUpdate.ResumeLayout(false);
            this.tpUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblPermission;
        private System.Windows.Forms.ComboBox cboPermission;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpNewUser;
        private System.Windows.Forms.TabPage tpUpdate;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboPermissionUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConfirmPasswordUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPasswordUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cboUsersNames;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegNewUser;
    }
}