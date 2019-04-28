namespace Sadot
{
    partial class ManageWine
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
            this.lblWinePage = new System.Windows.Forms.Label();
            this.lblWinePriceBottle = new System.Windows.Forms.Label();
            this.lblWinePriceGlass = new System.Windows.Forms.Label();
            this.lblWineName = new System.Windows.Forms.Label();
            this.cbWineStatus = new System.Windows.Forms.CheckBox();
            this.txtSearchWine = new System.Windows.Forms.TextBox();
            this.txtWineName = new System.Windows.Forms.TextBox();
            this.lblWineYear = new System.Windows.Forms.Label();
            this.lstWineList = new System.Windows.Forms.ListBox();
            this.btnAddWine = new System.Windows.Forms.Button();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.btnUpdateWine = new System.Windows.Forms.Button();
            this.btnShowAllWine = new System.Windows.Forms.Button();
            this.btnReturnToHomePage = new System.Windows.Forms.Button();
            this.nudWinePriceBottle = new System.Windows.Forms.NumericUpDown();
            this.nudWinePriceGlass = new System.Windows.Forms.NumericUpDown();
            this.dtpWineYear = new System.Windows.Forms.DateTimePicker();
            this.cboParameterToSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWinePriceBottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWinePriceGlass)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWinePage
            // 
            this.lblWinePage.AutoSize = true;
            this.lblWinePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWinePage.ForeColor = System.Drawing.Color.Black;
            this.lblWinePage.Location = new System.Drawing.Point(712, 9);
            this.lblWinePage.Name = "lblWinePage";
            this.lblWinePage.Size = new System.Drawing.Size(338, 40);
            this.lblWinePage.TabIndex = 49;
            this.lblWinePage.Text = "הוספה / עריכת יינות";
            // 
            // lblWinePriceBottle
            // 
            this.lblWinePriceBottle.AutoSize = true;
            this.lblWinePriceBottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWinePriceBottle.ForeColor = System.Drawing.Color.Black;
            this.lblWinePriceBottle.Location = new System.Drawing.Point(895, 226);
            this.lblWinePriceBottle.Name = "lblWinePriceBottle";
            this.lblWinePriceBottle.Size = new System.Drawing.Size(149, 29);
            this.lblWinePriceBottle.TabIndex = 51;
            this.lblWinePriceBottle.Text = "מחיר לבקבוק :";
            // 
            // lblWinePriceGlass
            // 
            this.lblWinePriceGlass.AutoSize = true;
            this.lblWinePriceGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWinePriceGlass.ForeColor = System.Drawing.Color.Black;
            this.lblWinePriceGlass.Location = new System.Drawing.Point(921, 279);
            this.lblWinePriceGlass.Name = "lblWinePriceGlass";
            this.lblWinePriceGlass.Size = new System.Drawing.Size(123, 29);
            this.lblWinePriceGlass.TabIndex = 52;
            this.lblWinePriceGlass.Text = "מחיר לכוס :";
            // 
            // lblWineName
            // 
            this.lblWineName.AutoSize = true;
            this.lblWineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWineName.ForeColor = System.Drawing.Color.Black;
            this.lblWineName.Location = new System.Drawing.Point(944, 118);
            this.lblWineName.Name = "lblWineName";
            this.lblWineName.Size = new System.Drawing.Size(96, 29);
            this.lblWineName.TabIndex = 53;
            this.lblWineName.Text = "שם היין :";
            // 
            // cbWineStatus
            // 
            this.cbWineStatus.AutoSize = true;
            this.cbWineStatus.Checked = true;
            this.cbWineStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWineStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbWineStatus.Location = new System.Drawing.Point(803, 350);
            this.cbWineStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbWineStatus.Name = "cbWineStatus";
            this.cbWineStatus.Size = new System.Drawing.Size(236, 33);
            this.cbWineStatus.TabIndex = 54;
            this.cbWineStatus.Text = "בתפריט / לא בתפריט";
            this.cbWineStatus.UseVisualStyleBackColor = true;
            // 
            // txtSearchWine
            // 
            this.txtSearchWine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearchWine.Location = new System.Drawing.Point(12, 73);
            this.txtSearchWine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchWine.Name = "txtSearchWine";
            this.txtSearchWine.Size = new System.Drawing.Size(327, 35);
            this.txtSearchWine.TabIndex = 56;
            this.txtSearchWine.TextChanged += new System.EventHandler(this.txtSearchWine_TextChanged);
            // 
            // txtWineName
            // 
            this.txtWineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtWineName.Location = new System.Drawing.Point(570, 118);
            this.txtWineName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWineName.Name = "txtWineName";
            this.txtWineName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWineName.Size = new System.Drawing.Size(263, 35);
            this.txtWineName.TabIndex = 57;
            // 
            // lblWineYear
            // 
            this.lblWineYear.AutoSize = true;
            this.lblWineYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWineYear.ForeColor = System.Drawing.Color.Black;
            this.lblWineYear.Location = new System.Drawing.Point(936, 178);
            this.lblWineYear.Name = "lblWineYear";
            this.lblWineYear.Size = new System.Drawing.Size(105, 29);
            this.lblWineYear.TabIndex = 62;
            this.lblWineYear.Text = "שנת היין :";
            // 
            // lstWineList
            // 
            this.lstWineList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstWineList.FormattingEnabled = true;
            this.lstWineList.ItemHeight = 29;
            this.lstWineList.Location = new System.Drawing.Point(12, 115);
            this.lstWineList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstWineList.Name = "lstWineList";
            this.lstWineList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstWineList.Size = new System.Drawing.Size(514, 497);
            this.lstWineList.TabIndex = 64;
            this.lstWineList.SelectedIndexChanged += new System.EventHandler(this.lstWineList_SelectedIndexChanged);
            // 
            // btnAddWine
            // 
            this.btnAddWine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddWine.Location = new System.Drawing.Point(564, 447);
            this.btnAddWine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddWine.Name = "btnAddWine";
            this.btnAddWine.Size = new System.Drawing.Size(163, 50);
            this.btnAddWine.TabIndex = 65;
            this.btnAddWine.Text = "הוספת יין";
            this.btnAddWine.UseVisualStyleBackColor = true;
            this.btnAddWine.Click += new System.EventHandler(this.btnAddWine_Click);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCleanFields.Location = new System.Drawing.Point(564, 562);
            this.btnCleanFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(163, 50);
            this.btnCleanFields.TabIndex = 70;
            this.btnCleanFields.Text = "ניקוי שדות";
            this.btnCleanFields.UseVisualStyleBackColor = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // btnUpdateWine
            // 
            this.btnUpdateWine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateWine.Location = new System.Drawing.Point(564, 504);
            this.btnUpdateWine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateWine.Name = "btnUpdateWine";
            this.btnUpdateWine.Size = new System.Drawing.Size(163, 50);
            this.btnUpdateWine.TabIndex = 71;
            this.btnUpdateWine.Text = "עדכון יין";
            this.btnUpdateWine.UseVisualStyleBackColor = true;
            this.btnUpdateWine.Click += new System.EventHandler(this.btnUpdateWine_Click);
            // 
            // btnShowAllWine
            // 
            this.btnShowAllWine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowAllWine.Location = new System.Drawing.Point(780, 504);
            this.btnShowAllWine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllWine.Name = "btnShowAllWine";
            this.btnShowAllWine.Size = new System.Drawing.Size(255, 50);
            this.btnShowAllWine.TabIndex = 72;
            this.btnShowAllWine.Text = "הצג את כל היינות";
            this.btnShowAllWine.UseVisualStyleBackColor = true;
            this.btnShowAllWine.Click += new System.EventHandler(this.btnShowAllWine_Click);
            // 
            // btnReturnToHomePage
            // 
            this.btnReturnToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturnToHomePage.Location = new System.Drawing.Point(780, 562);
            this.btnReturnToHomePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnToHomePage.Name = "btnReturnToHomePage";
            this.btnReturnToHomePage.Size = new System.Drawing.Size(255, 50);
            this.btnReturnToHomePage.TabIndex = 73;
            this.btnReturnToHomePage.Text = "חזרה למסך הראשי";
            this.btnReturnToHomePage.UseVisualStyleBackColor = true;
            this.btnReturnToHomePage.Click += new System.EventHandler(this.btnReturnToHomePage_Click);
            // 
            // nudWinePriceBottle
            // 
            this.nudWinePriceBottle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nudWinePriceBottle.Location = new System.Drawing.Point(570, 226);
            this.nudWinePriceBottle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudWinePriceBottle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWinePriceBottle.Name = "nudWinePriceBottle";
            this.nudWinePriceBottle.Size = new System.Drawing.Size(263, 35);
            this.nudWinePriceBottle.TabIndex = 74;
            // 
            // nudWinePriceGlass
            // 
            this.nudWinePriceGlass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nudWinePriceGlass.Location = new System.Drawing.Point(570, 279);
            this.nudWinePriceGlass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudWinePriceGlass.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudWinePriceGlass.Name = "nudWinePriceGlass";
            this.nudWinePriceGlass.Size = new System.Drawing.Size(263, 35);
            this.nudWinePriceGlass.TabIndex = 75;
            // 
            // dtpWineYear
            // 
            this.dtpWineYear.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpWineYear.CustomFormat = "yyyy";
            this.dtpWineYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpWineYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWineYear.Location = new System.Drawing.Point(570, 172);
            this.dtpWineYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpWineYear.Name = "dtpWineYear";
            this.dtpWineYear.RightToLeftLayout = true;
            this.dtpWineYear.ShowUpDown = true;
            this.dtpWineYear.Size = new System.Drawing.Size(263, 35);
            this.dtpWineYear.TabIndex = 76;
            // 
            // cboParameterToSearch
            // 
            this.cboParameterToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboParameterToSearch.FormattingEnabled = true;
            this.cboParameterToSearch.Items.AddRange(new object[] {
            "שם היין",
            "שנה"});
            this.cboParameterToSearch.Location = new System.Drawing.Point(346, 73);
            this.cboParameterToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParameterToSearch.Name = "cboParameterToSearch";
            this.cboParameterToSearch.Size = new System.Drawing.Size(180, 34);
            this.cboParameterToSearch.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 78;
            this.label1.Text = "חפש לפי :";
            // 
            // ManageWine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboParameterToSearch);
            this.Controls.Add(this.dtpWineYear);
            this.Controls.Add(this.nudWinePriceGlass);
            this.Controls.Add(this.nudWinePriceBottle);
            this.Controls.Add(this.btnReturnToHomePage);
            this.Controls.Add(this.btnShowAllWine);
            this.Controls.Add(this.btnUpdateWine);
            this.Controls.Add(this.btnCleanFields);
            this.Controls.Add(this.btnAddWine);
            this.Controls.Add(this.lstWineList);
            this.Controls.Add(this.lblWineYear);
            this.Controls.Add(this.txtWineName);
            this.Controls.Add(this.txtSearchWine);
            this.Controls.Add(this.cbWineStatus);
            this.Controls.Add(this.lblWineName);
            this.Controls.Add(this.lblWinePriceGlass);
            this.Controls.Add(this.lblWinePriceBottle);
            this.Controls.Add(this.lblWinePage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageWine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ניהול יינות";
            this.Load += new System.EventHandler(this.AdminManageWine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudWinePriceBottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWinePriceGlass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinePage;
        private System.Windows.Forms.Label lblWinePriceBottle;
        private System.Windows.Forms.Label lblWinePriceGlass;
        private System.Windows.Forms.Label lblWineName;
        private System.Windows.Forms.CheckBox cbWineStatus;
        private System.Windows.Forms.TextBox txtSearchWine;
        private System.Windows.Forms.TextBox txtWineName;
        private System.Windows.Forms.Label lblWineYear;
        private System.Windows.Forms.ListBox lstWineList;
        private System.Windows.Forms.Button btnAddWine;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.Button btnUpdateWine;
        private System.Windows.Forms.Button btnShowAllWine;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.NumericUpDown nudWinePriceBottle;
        private System.Windows.Forms.NumericUpDown nudWinePriceGlass;
        private System.Windows.Forms.DateTimePicker dtpWineYear;
        private System.Windows.Forms.ComboBox cboParameterToSearch;
        private System.Windows.Forms.Label label1;
    }
}