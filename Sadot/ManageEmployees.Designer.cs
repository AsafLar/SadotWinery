namespace Sadot
{
    partial class ManageEmployees
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
            this.label4 = new System.Windows.Forms.Label();
            this.cboParameterToSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.cbEmployeeStatus = new System.Windows.Forms.CheckBox();
            this.btnReturnToHomePage = new System.Windows.Forms.Button();
            this.lstEmployees = new System.Windows.Forms.ListBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.btnShowAllEmployees = new System.Windows.Forms.Button();
            this.txtEmployeeLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblEmpName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(376, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 124;
            this.label4.Text = "חפש לפי :";
            // 
            // cboParameterToSearch
            // 
            this.cboParameterToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboParameterToSearch.FormattingEnabled = true;
            this.cboParameterToSearch.Items.AddRange(new object[] {
            "שם פרטי",
            "שם משפחה"});
            this.cboParameterToSearch.Location = new System.Drawing.Point(289, 70);
            this.cboParameterToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParameterToSearch.Name = "cboParameterToSearch";
            this.cboParameterToSearch.Size = new System.Drawing.Size(180, 34);
            this.cboParameterToSearch.TabIndex = 123;
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearchEmployee.Location = new System.Drawing.Point(13, 70);
            this.txtSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(270, 35);
            this.txtSearchEmployee.TabIndex = 122;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // cbEmployeeStatus
            // 
            this.cbEmployeeStatus.AutoSize = true;
            this.cbEmployeeStatus.Checked = true;
            this.cbEmployeeStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEmployeeStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbEmployeeStatus.Location = new System.Drawing.Point(810, 263);
            this.cbEmployeeStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmployeeStatus.Name = "cbEmployeeStatus";
            this.cbEmployeeStatus.Size = new System.Drawing.Size(178, 33);
            this.cbEmployeeStatus.TabIndex = 119;
            this.cbEmployeeStatus.Text = "פעיל / לא פעיל";
            this.cbEmployeeStatus.UseVisualStyleBackColor = true;
            // 
            // btnReturnToHomePage
            // 
            this.btnReturnToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturnToHomePage.Location = new System.Drawing.Point(792, 566);
            this.btnReturnToHomePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnToHomePage.Name = "btnReturnToHomePage";
            this.btnReturnToHomePage.Size = new System.Drawing.Size(256, 44);
            this.btnReturnToHomePage.TabIndex = 118;
            this.btnReturnToHomePage.Text = "חזרה למסך הראשי";
            this.btnReturnToHomePage.UseVisualStyleBackColor = true;
            this.btnReturnToHomePage.Click += new System.EventHandler(this.btnReturnToHomePage_Click);
            // 
            // lstEmployees
            // 
            this.lstEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstEmployees.FormattingEnabled = true;
            this.lstEmployees.ItemHeight = 29;
            this.lstEmployees.Location = new System.Drawing.Point(11, 113);
            this.lstEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstEmployees.Name = "lstEmployees";
            this.lstEmployees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstEmployees.Size = new System.Drawing.Size(457, 497);
            this.lstEmployees.TabIndex = 117;
            this.lstEmployees.SelectedIndexChanged += new System.EventHandler(this.lstEmployees_SelectedIndexChanged);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddEmployee.Location = new System.Drawing.Point(526, 447);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(213, 44);
            this.btnAddEmployee.TabIndex = 116;
            this.btnAddEmployee.Text = "הוספת עובד";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateEmployee.Location = new System.Drawing.Point(526, 506);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(213, 44);
            this.btnUpdateEmployee.TabIndex = 115;
            this.btnUpdateEmployee.Text = "עדכון עובד";
            this.btnUpdateEmployee.UseVisualStyleBackColor = true;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCleanFields.Location = new System.Drawing.Point(526, 566);
            this.btnCleanFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(213, 44);
            this.btnCleanFields.TabIndex = 114;
            this.btnCleanFields.Text = "נקה שדות";
            this.btnCleanFields.UseVisualStyleBackColor = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // btnShowAllEmployees
            // 
            this.btnShowAllEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowAllEmployees.Location = new System.Drawing.Point(792, 506);
            this.btnShowAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowAllEmployees.Name = "btnShowAllEmployees";
            this.btnShowAllEmployees.Size = new System.Drawing.Size(256, 44);
            this.btnShowAllEmployees.TabIndex = 113;
            this.btnShowAllEmployees.Text = "הצג את כל העובדים";
            this.btnShowAllEmployees.UseVisualStyleBackColor = true;
            this.btnShowAllEmployees.Click += new System.EventHandler(this.btnShowAllEmployees_Click);
            // 
            // txtEmployeeLname
            // 
            this.txtEmployeeLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmployeeLname.Location = new System.Drawing.Point(535, 181);
            this.txtEmployeeLname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeLname.Name = "txtEmployeeLname";
            this.txtEmployeeLname.Size = new System.Drawing.Size(285, 35);
            this.txtEmployeeLname.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(869, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 29);
            this.label1.TabIndex = 104;
            this.label1.Text = "שם משפחה:";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtEmployeeName.Location = new System.Drawing.Point(535, 113);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(285, 35);
            this.txtEmployeeName.TabIndex = 103;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmpName.ForeColor = System.Drawing.Color.Black;
            this.lblEmpName.Location = new System.Drawing.Point(893, 120);
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(100, 29);
            this.lblEmpName.TabIndex = 102;
            this.lblEmpName.Text = "שם פרטי:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(680, 11);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(368, 40);
            this.label13.TabIndex = 101;
            this.label13.Text = "הוספה / עדכון עובדים";
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboParameterToSearch);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.cbEmployeeStatus);
            this.Controls.Add(this.btnReturnToHomePage);
            this.Controls.Add(this.lstEmployees);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnCleanFields);
            this.Controls.Add(this.btnShowAllEmployees);
            this.Controls.Add(this.txtEmployeeLname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.label13);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageEmployees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ניהול עובדים";
            this.Load += new System.EventHandler(this.ManageEmployees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboParameterToSearch;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.CheckBox cbEmployeeStatus;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.ListBox lstEmployees;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.Button btnShowAllEmployees;
        private System.Windows.Forms.TextBox txtEmployeeLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblEmpName;
        private System.Windows.Forms.Label label13;
    }
}