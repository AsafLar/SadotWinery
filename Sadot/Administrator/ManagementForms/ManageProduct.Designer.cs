namespace Sadot
{
    partial class ManageProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboParameterToSearch = new System.Windows.Forms.ComboBox();
            this.nudProductPrice = new System.Windows.Forms.NumericUpDown();
            this.btnReturnToHomePage = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnCleanFields = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lstProductList = new System.Windows.Forms.ListBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.cbProductStatus = new System.Windows.Forms.CheckBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductPage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(465, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 97;
            this.label1.Text = "חפש לפי :";
            // 
            // cboParameterToSearch
            // 
            this.cboParameterToSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboParameterToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboParameterToSearch.FormattingEnabled = true;
            this.cboParameterToSearch.Items.AddRange(new object[] {
            "שם המוצר",
            "מחיר",
            "מחלקה"});
            this.cboParameterToSearch.Location = new System.Drawing.Point(367, 76);
            this.cboParameterToSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboParameterToSearch.Name = "cboParameterToSearch";
            this.cboParameterToSearch.Size = new System.Drawing.Size(197, 34);
            this.cboParameterToSearch.TabIndex = 96;
            // 
            // nudProductPrice
            // 
            this.nudProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nudProductPrice.Location = new System.Drawing.Point(607, 172);
            this.nudProductPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudProductPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudProductPrice.Name = "nudProductPrice";
            this.nudProductPrice.Size = new System.Drawing.Size(263, 35);
            this.nudProductPrice.TabIndex = 93;
            // 
            // btnReturnToHomePage
            // 
            this.btnReturnToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReturnToHomePage.Location = new System.Drawing.Point(844, 562);
            this.btnReturnToHomePage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnToHomePage.Name = "btnReturnToHomePage";
            this.btnReturnToHomePage.Size = new System.Drawing.Size(236, 50);
            this.btnReturnToHomePage.TabIndex = 92;
            this.btnReturnToHomePage.Text = "חזרה למסך הראשי";
            this.btnReturnToHomePage.UseVisualStyleBackColor = true;
            this.btnReturnToHomePage.Click += new System.EventHandler(this.btnReturnToHomePage_Click);
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowAllProduct.Location = new System.Drawing.Point(844, 504);
            this.btnShowAllProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(236, 50);
            this.btnShowAllProduct.TabIndex = 91;
            this.btnShowAllProduct.Text = "הצג את כל המוצרים";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateProduct.Location = new System.Drawing.Point(616, 504);
            this.btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(163, 50);
            this.btnUpdateProduct.TabIndex = 90;
            this.btnUpdateProduct.Text = "עדכון מוצר";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnCleanFields
            // 
            this.btnCleanFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCleanFields.Location = new System.Drawing.Point(616, 562);
            this.btnCleanFields.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCleanFields.Name = "btnCleanFields";
            this.btnCleanFields.Size = new System.Drawing.Size(163, 50);
            this.btnCleanFields.TabIndex = 89;
            this.btnCleanFields.Text = "ניקוי שדות";
            this.btnCleanFields.UseVisualStyleBackColor = true;
            this.btnCleanFields.Click += new System.EventHandler(this.btnCleanFields_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddProduct.Location = new System.Drawing.Point(616, 446);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(163, 50);
            this.btnAddProduct.TabIndex = 88;
            this.btnAddProduct.Text = "הוספת מוצר";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lstProductList
            // 
            this.lstProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstProductList.FormattingEnabled = true;
            this.lstProductList.ItemHeight = 29;
            this.lstProductList.Location = new System.Drawing.Point(12, 116);
            this.lstProductList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstProductList.Name = "lstProductList";
            this.lstProductList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstProductList.Size = new System.Drawing.Size(552, 497);
            this.lstProductList.TabIndex = 87;
            this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtProductName.Location = new System.Drawing.Point(607, 115);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtProductName.Size = new System.Drawing.Size(263, 35);
            this.txtProductName.TabIndex = 85;
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtSearchProduct.Location = new System.Drawing.Point(12, 74);
            this.txtSearchProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(349, 35);
            this.txtSearchProduct.TabIndex = 84;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // cbProductStatus
            // 
            this.cbProductStatus.AutoSize = true;
            this.cbProductStatus.Checked = true;
            this.cbProductStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbProductStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbProductStatus.Location = new System.Drawing.Point(838, 364);
            this.cbProductStatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbProductStatus.Name = "cbProductStatus";
            this.cbProductStatus.Size = new System.Drawing.Size(236, 33);
            this.cbProductStatus.TabIndex = 83;
            this.cbProductStatus.Text = "בתפריט / לא בתפריט";
            this.cbProductStatus.UseVisualStyleBackColor = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProductName.ForeColor = System.Drawing.Color.Black;
            this.lblProductName.Location = new System.Drawing.Point(959, 121);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(120, 29);
            this.lblProductName.TabIndex = 82;
            this.lblProductName.Text = "שם המוצר :";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProductPrice.ForeColor = System.Drawing.Color.Black;
            this.lblProductPrice.Location = new System.Drawing.Point(942, 178);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(137, 29);
            this.lblProductPrice.TabIndex = 80;
            this.lblProductPrice.Text = "מחיר המוצר :";
            // 
            // lblProductPage
            // 
            this.lblProductPage.AutoSize = true;
            this.lblProductPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblProductPage.ForeColor = System.Drawing.Color.Black;
            this.lblProductPage.Location = new System.Drawing.Point(713, 9);
            this.lblProductPage.Name = "lblProductPage";
            this.lblProductPage.Size = new System.Drawing.Size(374, 40);
            this.lblProductPage.TabIndex = 79;
            this.lblProductPage.Text = "הוספה / עריכת מוצרים";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(921, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 29);
            this.label2.TabIndex = 98;
            this.label2.Text = "מחלקת המוצר :";
            // 
            // cboDepartment
            // 
            this.cboDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Items.AddRange(new object[] {
            "Bar",
            "Waiters",
            "General"});
            this.cboDepartment.Location = new System.Drawing.Point(607, 226);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(263, 34);
            this.cboDepartment.TabIndex = 100;
            this.cboDepartment.Text = "Bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(959, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 101;
            this.label3.Text = "סוג המוצר :";
            // 
            // cboType
            // 
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "שתיה קלה / אלכוהול",
            "שתיה חמה / קפה",
            "קינוחים",
            "מוצר כללי"});
            this.cboType.Location = new System.Drawing.Point(607, 286);
            this.cboType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(263, 34);
            this.cboType.TabIndex = 102;
            this.cboType.Text = "שתיה קלה / אלכוהול";
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 625);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboParameterToSearch);
            this.Controls.Add(this.nudProductPrice);
            this.Controls.Add(this.btnReturnToHomePage);
            this.Controls.Add(this.btnShowAllProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnCleanFields);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lstProductList);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.cbProductStatus);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ניהול מוצרים";
            this.Load += new System.EventHandler(this.AdminManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudProductPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboParameterToSearch;
        private System.Windows.Forms.NumericUpDown nudProductPrice;
        private System.Windows.Forms.Button btnReturnToHomePage;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnCleanFields;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.ListBox lstProductList;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.CheckBox cbProductStatus;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductPage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboType;
    }
}