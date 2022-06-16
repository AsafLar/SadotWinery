namespace Sadot
{
    partial class SelectCustomer
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
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 46);
            this.label4.TabIndex = 104;
            this.label4.Text = "חפש לפי :";
            // 
            // cboParameterToSearch
            // 
            this.cboParameterToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboParameterToSearch.FormattingEnabled = true;
            this.cboParameterToSearch.Items.AddRange(new object[] {
            "מספר נייד",
            "שם פרטי",
            "שם משפחה"});
            this.cboParameterToSearch.Location = new System.Drawing.Point(14, 156);
            this.cboParameterToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParameterToSearch.Name = "cboParameterToSearch";
            this.cboParameterToSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cboParameterToSearch.Size = new System.Drawing.Size(275, 45);
            this.cboParameterToSearch.TabIndex = 103;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(296, 156);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(545, 44);
            this.txtSearchCustomer.TabIndex = 102;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 37;
            this.lstCustomers.Location = new System.Drawing.Point(14, 219);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstCustomers.Size = new System.Drawing.Size(828, 485);
            this.lstCustomers.TabIndex = 101;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(270, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 52);
            this.label1.TabIndex = 105;
            this.label1.Text = "שיוך לקוח להזמנה";
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 759);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboParameterToSearch);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.lstCustomers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SelectCustomer";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCustomer";
            this.Load += new System.EventHandler(this.SelectCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboParameterToSearch;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label1;
    }
}