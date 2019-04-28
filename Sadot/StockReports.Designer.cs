namespace Sadot
{
    partial class StockReports
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLessSell = new System.Windows.Forms.RadioButton();
            this.rbMostSell = new System.Windows.Forms.RadioButton();
            this.radioButtonGB = new System.Windows.Forms.GroupBox();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbDish = new System.Windows.Forms.RadioButton();
            this.rbDessert = new System.Windows.Forms.RadioButton();
            this.rbWines = new System.Windows.Forms.RadioButton();
            this.rbHotDrink = new System.Windows.Forms.RadioButton();
            this.rbSoftDrink = new System.Windows.Forms.RadioButton();
            this.rbAllProducts = new System.Windows.Forms.RadioButton();
            this.dgvStockUntilToday = new System.Windows.Forms.DataGridView();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuyProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnShowStock = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.radioButtonGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockUntilToday)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLessSell);
            this.groupBox1.Controls.Add(this.rbMostSell);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(10, 370);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(536, 115);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מיין לפי";
            // 
            // rbLessSell
            // 
            this.rbLessSell.AutoSize = true;
            this.rbLessSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbLessSell.Location = new System.Drawing.Point(139, 61);
            this.rbLessSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbLessSell.Name = "rbLessSell";
            this.rbLessSell.Size = new System.Drawing.Size(161, 36);
            this.rbLessSell.TabIndex = 8;
            this.rbLessSell.Text = "פחות נמכר";
            this.rbLessSell.UseVisualStyleBackColor = true;
            this.rbLessSell.Click += new System.EventHandler(this.rbSort_Click);
            // 
            // rbMostSell
            // 
            this.rbMostSell.AutoSize = true;
            this.rbMostSell.Checked = true;
            this.rbMostSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbMostSell.Location = new System.Drawing.Point(327, 61);
            this.rbMostSell.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMostSell.Name = "rbMostSell";
            this.rbMostSell.Size = new System.Drawing.Size(185, 36);
            this.rbMostSell.TabIndex = 7;
            this.rbMostSell.TabStop = true;
            this.rbMostSell.Text = "הנמכר ביותר";
            this.rbMostSell.UseVisualStyleBackColor = true;
            this.rbMostSell.Click += new System.EventHandler(this.rbSort_Click);
            // 
            // radioButtonGB
            // 
            this.radioButtonGB.Controls.Add(this.rbGeneral);
            this.radioButtonGB.Controls.Add(this.rbDish);
            this.radioButtonGB.Controls.Add(this.rbDessert);
            this.radioButtonGB.Controls.Add(this.rbWines);
            this.radioButtonGB.Controls.Add(this.rbHotDrink);
            this.radioButtonGB.Controls.Add(this.rbSoftDrink);
            this.radioButtonGB.Controls.Add(this.rbAllProducts);
            this.radioButtonGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButtonGB.Location = new System.Drawing.Point(10, 138);
            this.radioButtonGB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonGB.Name = "radioButtonGB";
            this.radioButtonGB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonGB.Size = new System.Drawing.Size(536, 228);
            this.radioButtonGB.TabIndex = 99;
            this.radioButtonGB.TabStop = false;
            this.radioButtonGB.Text = "בחר תצוגה";
            // 
            // rbGeneral
            // 
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbGeneral.Location = new System.Drawing.Point(206, 51);
            this.rbGeneral.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(94, 36);
            this.rbGeneral.TabIndex = 6;
            this.rbGeneral.Text = "כללי";
            this.rbGeneral.UseVisualStyleBackColor = true;
            this.rbGeneral.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbDish
            // 
            this.rbDish.AutoSize = true;
            this.rbDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbDish.Location = new System.Drawing.Point(416, 135);
            this.rbDish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDish.Name = "rbDish";
            this.rbDish.Size = new System.Drawing.Size(96, 36);
            this.rbDish.TabIndex = 5;
            this.rbDish.Text = "אוכל";
            this.rbDish.UseVisualStyleBackColor = true;
            this.rbDish.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbDessert
            // 
            this.rbDessert.AutoSize = true;
            this.rbDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbDessert.Location = new System.Drawing.Point(385, 175);
            this.rbDessert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbDessert.Name = "rbDessert";
            this.rbDessert.Size = new System.Drawing.Size(127, 36);
            this.rbDessert.TabIndex = 4;
            this.rbDessert.Text = "קינוחים";
            this.rbDessert.UseVisualStyleBackColor = true;
            this.rbDessert.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbWines
            // 
            this.rbWines.AutoSize = true;
            this.rbWines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbWines.Location = new System.Drawing.Point(418, 95);
            this.rbWines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbWines.Name = "rbWines";
            this.rbWines.Size = new System.Drawing.Size(94, 36);
            this.rbWines.TabIndex = 3;
            this.rbWines.Text = "יינות";
            this.rbWines.UseVisualStyleBackColor = true;
            this.rbWines.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbHotDrink
            // 
            this.rbHotDrink.AutoSize = true;
            this.rbHotDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbHotDrink.Location = new System.Drawing.Point(131, 95);
            this.rbHotDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbHotDrink.Name = "rbHotDrink";
            this.rbHotDrink.Size = new System.Drawing.Size(169, 36);
            this.rbHotDrink.TabIndex = 2;
            this.rbHotDrink.Text = "שתייה חמה";
            this.rbHotDrink.UseVisualStyleBackColor = true;
            this.rbHotDrink.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbSoftDrink
            // 
            this.rbSoftDrink.AutoSize = true;
            this.rbSoftDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbSoftDrink.Location = new System.Drawing.Point(15, 135);
            this.rbSoftDrink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbSoftDrink.Name = "rbSoftDrink";
            this.rbSoftDrink.Size = new System.Drawing.Size(285, 36);
            this.rbSoftDrink.TabIndex = 1;
            this.rbSoftDrink.Text = "שתייה קלה / אלכוהול";
            this.rbSoftDrink.UseVisualStyleBackColor = true;
            this.rbSoftDrink.Click += new System.EventHandler(this.rbType_Click);
            // 
            // rbAllProducts
            // 
            this.rbAllProducts.AutoSize = true;
            this.rbAllProducts.Checked = true;
            this.rbAllProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rbAllProducts.Location = new System.Drawing.Point(337, 51);
            this.rbAllProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAllProducts.Name = "rbAllProducts";
            this.rbAllProducts.Size = new System.Drawing.Size(175, 36);
            this.rbAllProducts.TabIndex = 0;
            this.rbAllProducts.TabStop = true;
            this.rbAllProducts.Tag = "";
            this.rbAllProducts.Text = "כל המוצרים";
            this.rbAllProducts.UseVisualStyleBackColor = true;
            this.rbAllProducts.Click += new System.EventHandler(this.rbType_Click);
            // 
            // dgvStockUntilToday
            // 
            this.dgvStockUntilToday.AllowUserToAddRows = false;
            this.dgvStockUntilToday.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvStockUntilToday.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStockUntilToday.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStockUntilToday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStockUntilToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockUntilToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.ProductAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStockUntilToday.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStockUntilToday.Location = new System.Drawing.Point(17, 56);
            this.dgvStockUntilToday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvStockUntilToday.MultiSelect = false;
            this.dgvStockUntilToday.Name = "dgvStockUntilToday";
            this.dgvStockUntilToday.ReadOnly = true;
            this.dgvStockUntilToday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStockUntilToday.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvStockUntilToday.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStockUntilToday.RowTemplate.Height = 24;
            this.dgvStockUntilToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStockUntilToday.Size = new System.Drawing.Size(761, 609);
            this.dgvStockUntilToday.TabIndex = 95;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.HeaderText = "שם המוצר";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductAmount
            // 
            this.ProductAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductAmount.HeaderText = "כמות רכישות";
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.ReadOnly = true;
            this.ProductAmount.Width = 210;
            // 
            // lblBuyProduct
            // 
            this.lblBuyProduct.AutoSize = true;
            this.lblBuyProduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBuyProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBuyProduct.Location = new System.Drawing.Point(51, 0);
            this.lblBuyProduct.Name = "lblBuyProduct";
            this.lblBuyProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBuyProduct.Size = new System.Drawing.Size(377, 37);
            this.lblBuyProduct.TabIndex = 94;
            this.lblBuyProduct.Text = "בחר פרמטרים לצהגת כמויות:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblTitle.Location = new System.Drawing.Point(195, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTitle.Size = new System.Drawing.Size(295, 72);
            this.lblTitle.TabIndex = 91;
            this.lblTitle.Text = "מלאי לחודש - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(169, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 88;
            this.label2.Text = "עד תאריך:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(458, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 29);
            this.label1.TabIndex = 87;
            this.label1.Text = "מתאריך:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(10, 75);
            this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(153, 35);
            this.dtpEndDate.TabIndex = 86;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(299, 76);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(153, 35);
            this.dtpStartDate.TabIndex = 85;
            // 
            // btnShowStock
            // 
            this.btnShowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnShowStock.Location = new System.Drawing.Point(10, 489);
            this.btnShowStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowStock.Name = "btnShowStock";
            this.btnShowStock.Size = new System.Drawing.Size(536, 86);
            this.btnShowStock.TabIndex = 98;
            this.btnShowStock.Text = "הצג כמויות";
            this.btnShowStock.UseVisualStyleBackColor = true;
            this.btnShowStock.Click += new System.EventHandler(this.btnShowStock_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnReport.Location = new System.Drawing.Point(98, 579);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(364, 86);
            this.btnReport.TabIndex = 101;
            this.btnReport.Text = "יצא ל - PDF";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1001, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(493, 72);
            this.tableLayoutPanel1.TabIndex = 102;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Gray;
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(885, 92);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(597, 715);
            this.panel10.TabIndex = 103;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.btnReport);
            this.panel11.Controls.Add(this.dtpStartDate);
            this.panel11.Controls.Add(this.btnShowStock);
            this.panel11.Controls.Add(this.groupBox1);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.radioButtonGB);
            this.panel11.Controls.Add(this.dtpEndDate);
            this.panel11.Location = new System.Drawing.Point(18, 19);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(559, 680);
            this.panel11.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblBuyProduct);
            this.panel1.Location = new System.Drawing.Point(51, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 46);
            this.panel1.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(13, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 715);
            this.panel2.TabIndex = 104;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgvStockUntilToday);
            this.panel3.Location = new System.Drawing.Point(18, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(799, 680);
            this.panel3.TabIndex = 78;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(266, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 46);
            this.panel4.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(96, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(187, 37);
            this.label3.TabIndex = 94;
            this.label3.Text = "רשימת כמויות";
            // 
            // StockReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StockReports";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1500, 819);
            this.Load += new System.EventHandler(this.StockReports_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.radioButtonGB.ResumeLayout(false);
            this.radioButtonGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockUntilToday)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLessSell;
        private System.Windows.Forms.RadioButton rbMostSell;
        private System.Windows.Forms.GroupBox radioButtonGB;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.RadioButton rbDish;
        private System.Windows.Forms.RadioButton rbDessert;
        private System.Windows.Forms.RadioButton rbWines;
        private System.Windows.Forms.RadioButton rbHotDrink;
        private System.Windows.Forms.RadioButton rbSoftDrink;
        private System.Windows.Forms.RadioButton rbAllProducts;
        private System.Windows.Forms.DataGridView dgvStockUntilToday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductAmount;
        private System.Windows.Forms.Label lblBuyProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnShowStock;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
    }
}
