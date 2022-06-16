namespace Sadot
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.tcOrder = new System.Windows.Forms.TabControl();
            this.tpWine = new System.Windows.Forms.TabPage();
            this.tpDish = new System.Windows.Forms.TabPage();
            this.tpSoftDrinksAndAlcohol = new System.Windows.Forms.TabPage();
            this.tpHotDrinksAndCoffee = new System.Windows.Forms.TabPage();
            this.tpDessert = new System.Windows.Forms.TabPage();
            this.tpGeneralProduct = new System.Windows.Forms.TabPage();
            this.btnDessert = new System.Windows.Forms.Button();
            this.btnHotDrinksAndCoffee = new System.Windows.Forms.Button();
            this.btnDish = new System.Windows.Forms.Button();
            this.btnSoftDrinksAndAlcohol = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnGeneralProduct = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.cbDiscount = new System.Windows.Forms.ComboBox();
            this.TotalPricePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddAmount = new System.Windows.Forms.Button();
            this.btnSubAmount = new System.Windows.Forms.Button();
            this.btnCancelProductFromOrder = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOTH = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblOrderTime = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblTableOrder = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbTablesList = new System.Windows.Forms.ComboBox();
            this.btnDiscount = new Sadot.MyBtn();
            this.nudSumToPay = new System.Windows.Forms.NumericUpDown();
            this.btnPayPartOfBill = new Sadot.MyBtn();
            this.tcOrder.SuspendLayout();
            this.TotalPricePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSumToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSelectCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSelectCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnSelectCustomer.Location = new System.Drawing.Point(167, 837);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(139, 83);
            this.btnSelectCustomer.TabIndex = 20;
            this.btnSelectCustomer.Text = "בחירת לקוח";
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.Black;
            this.btnSwitchTable.Location = new System.Drawing.Point(474, 748);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(139, 85);
            this.btnSwitchTable.TabIndex = 19;
            this.btnSwitchTable.Text = "החלפת שולחן";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // tcOrder
            // 
            this.tcOrder.CausesValidation = false;
            this.tcOrder.Controls.Add(this.tpWine);
            this.tcOrder.Controls.Add(this.tpDish);
            this.tcOrder.Controls.Add(this.tpSoftDrinksAndAlcohol);
            this.tcOrder.Controls.Add(this.tpHotDrinksAndCoffee);
            this.tcOrder.Controls.Add(this.tpDessert);
            this.tcOrder.Controls.Add(this.tpGeneralProduct);
            this.tcOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.tcOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tcOrder.ItemSize = new System.Drawing.Size(0, 1);
            this.tcOrder.Location = new System.Drawing.Point(0, 0);
            this.tcOrder.Name = "tcOrder";
            this.tcOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcOrder.RightToLeftLayout = true;
            this.tcOrder.SelectedIndex = 0;
            this.tcOrder.Size = new System.Drawing.Size(411, 786);
            this.tcOrder.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcOrder.TabIndex = 5;
            this.tcOrder.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tcOrder_Selecting);
            // 
            // tpWine
            // 
            this.tpWine.AutoScroll = true;
            this.tpWine.BackColor = System.Drawing.Color.White;
            this.tpWine.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpWine.Location = new System.Drawing.Point(4, 5);
            this.tpWine.Name = "tpWine";
            this.tpWine.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpWine.Size = new System.Drawing.Size(403, 777);
            this.tpWine.TabIndex = 0;
            // 
            // tpDish
            // 
            this.tpDish.AutoScroll = true;
            this.tpDish.BackColor = System.Drawing.Color.White;
            this.tpDish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpDish.Location = new System.Drawing.Point(4, 5);
            this.tpDish.Name = "tpDish";
            this.tpDish.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpDish.Size = new System.Drawing.Size(403, 777);
            this.tpDish.TabIndex = 1;
            // 
            // tpSoftDrinksAndAlcohol
            // 
            this.tpSoftDrinksAndAlcohol.AutoScroll = true;
            this.tpSoftDrinksAndAlcohol.BackColor = System.Drawing.Color.White;
            this.tpSoftDrinksAndAlcohol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpSoftDrinksAndAlcohol.Location = new System.Drawing.Point(4, 5);
            this.tpSoftDrinksAndAlcohol.Name = "tpSoftDrinksAndAlcohol";
            this.tpSoftDrinksAndAlcohol.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpSoftDrinksAndAlcohol.Size = new System.Drawing.Size(403, 777);
            this.tpSoftDrinksAndAlcohol.TabIndex = 2;
            // 
            // tpHotDrinksAndCoffee
            // 
            this.tpHotDrinksAndCoffee.AutoScroll = true;
            this.tpHotDrinksAndCoffee.BackColor = System.Drawing.Color.White;
            this.tpHotDrinksAndCoffee.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpHotDrinksAndCoffee.Location = new System.Drawing.Point(4, 5);
            this.tpHotDrinksAndCoffee.Name = "tpHotDrinksAndCoffee";
            this.tpHotDrinksAndCoffee.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpHotDrinksAndCoffee.Size = new System.Drawing.Size(403, 777);
            this.tpHotDrinksAndCoffee.TabIndex = 3;
            // 
            // tpDessert
            // 
            this.tpDessert.AutoScroll = true;
            this.tpDessert.BackColor = System.Drawing.Color.White;
            this.tpDessert.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpDessert.Location = new System.Drawing.Point(4, 5);
            this.tpDessert.Name = "tpDessert";
            this.tpDessert.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpDessert.Size = new System.Drawing.Size(403, 777);
            this.tpDessert.TabIndex = 4;
            // 
            // tpGeneralProduct
            // 
            this.tpGeneralProduct.AutoScroll = true;
            this.tpGeneralProduct.BackColor = System.Drawing.Color.White;
            this.tpGeneralProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpGeneralProduct.Location = new System.Drawing.Point(4, 5);
            this.tpGeneralProduct.Name = "tpGeneralProduct";
            this.tpGeneralProduct.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpGeneralProduct.Size = new System.Drawing.Size(403, 777);
            this.tpGeneralProduct.TabIndex = 5;
            // 
            // btnDessert
            // 
            this.btnDessert.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDessert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDessert.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDessert.ForeColor = System.Drawing.Color.Black;
            this.btnDessert.Location = new System.Drawing.Point(413, 507);
            this.btnDessert.Name = "btnDessert";
            this.btnDessert.Size = new System.Drawing.Size(168, 82);
            this.btnDessert.TabIndex = 6;
            this.btnDessert.Text = "קינוחים";
            this.btnDessert.UseVisualStyleBackColor = false;
            this.btnDessert.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnHotDrinksAndCoffee
            // 
            this.btnHotDrinksAndCoffee.BackColor = System.Drawing.Color.SkyBlue;
            this.btnHotDrinksAndCoffee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHotDrinksAndCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnHotDrinksAndCoffee.ForeColor = System.Drawing.Color.Black;
            this.btnHotDrinksAndCoffee.Location = new System.Drawing.Point(413, 401);
            this.btnHotDrinksAndCoffee.Name = "btnHotDrinksAndCoffee";
            this.btnHotDrinksAndCoffee.Size = new System.Drawing.Size(168, 82);
            this.btnHotDrinksAndCoffee.TabIndex = 14;
            this.btnHotDrinksAndCoffee.Text = "שתייה חמה / קפה";
            this.btnHotDrinksAndCoffee.UseVisualStyleBackColor = false;
            this.btnHotDrinksAndCoffee.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDish
            // 
            this.btnDish.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDish.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDish.ForeColor = System.Drawing.Color.Black;
            this.btnDish.Location = new System.Drawing.Point(413, 177);
            this.btnDish.Name = "btnDish";
            this.btnDish.Size = new System.Drawing.Size(168, 82);
            this.btnDish.TabIndex = 16;
            this.btnDish.Text = "אוכל";
            this.btnDish.UseVisualStyleBackColor = false;
            this.btnDish.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSoftDrinksAndAlcohol
            // 
            this.btnSoftDrinksAndAlcohol.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSoftDrinksAndAlcohol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoftDrinksAndAlcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSoftDrinksAndAlcohol.ForeColor = System.Drawing.Color.Black;
            this.btnSoftDrinksAndAlcohol.Location = new System.Drawing.Point(413, 291);
            this.btnSoftDrinksAndAlcohol.Name = "btnSoftDrinksAndAlcohol";
            this.btnSoftDrinksAndAlcohol.Size = new System.Drawing.Size(168, 82);
            this.btnSoftDrinksAndAlcohol.TabIndex = 15;
            this.btnSoftDrinksAndAlcohol.Text = "שתייה קלה / אלכוהול";
            this.btnSoftDrinksAndAlcohol.UseVisualStyleBackColor = false;
            this.btnSoftDrinksAndAlcohol.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.SkyBlue;
            this.btnWine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnWine.ForeColor = System.Drawing.Color.Black;
            this.btnWine.Location = new System.Drawing.Point(413, 74);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(168, 82);
            this.btnWine.TabIndex = 17;
            this.btnWine.Text = "יין";
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenu.Location = new System.Drawing.Point(444, 24);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(108, 38);
            this.lblMenu.TabIndex = 20;
            this.lblMenu.Text = "תפריט";
            // 
            // btnGeneralProduct
            // 
            this.btnGeneralProduct.BackColor = System.Drawing.Color.SkyBlue;
            this.btnGeneralProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGeneralProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnGeneralProduct.ForeColor = System.Drawing.Color.Black;
            this.btnGeneralProduct.Location = new System.Drawing.Point(413, 615);
            this.btnGeneralProduct.Name = "btnGeneralProduct";
            this.btnGeneralProduct.Size = new System.Drawing.Size(168, 82);
            this.btnGeneralProduct.TabIndex = 19;
            this.btnGeneralProduct.Text = "מוצר כללי";
            this.btnGeneralProduct.UseVisualStyleBackColor = false;
            this.btnGeneralProduct.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPay.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(13, 836);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(139, 83);
            this.btnPay.TabIndex = 21;
            this.btnPay.Text = "שולם / סגירת שולחן";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.SkyBlue;
            this.btnBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBill.ForeColor = System.Drawing.Color.Black;
            this.btnBill.Location = new System.Drawing.Point(166, 748);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(139, 83);
            this.btnBill.TabIndex = 19;
            this.btnBill.Text = "הדפסת חשבון";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SkyBlue;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(13, 748);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 83);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "יציאה";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 301);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.UseAntiAlias = true;
            this.printPreviewDialog1.Visible = false;
            // 
            // cbDiscount
            // 
            this.cbDiscount.BackColor = System.Drawing.Color.SkyBlue;
            this.cbDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbDiscount.ForeColor = System.Drawing.Color.Black;
            this.cbDiscount.FormattingEnabled = true;
            this.cbDiscount.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "40",
            "50"});
            this.cbDiscount.Location = new System.Drawing.Point(319, 836);
            this.cbDiscount.Name = "cbDiscount";
            this.cbDiscount.Size = new System.Drawing.Size(139, 33);
            this.cbDiscount.TabIndex = 22;
            this.cbDiscount.Text = "5";
            // 
            // TotalPricePanel
            // 
            this.TotalPricePanel.BackColor = System.Drawing.Color.White;
            this.TotalPricePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPricePanel.Controls.Add(this.label2);
            this.TotalPricePanel.Controls.Add(this.lblTotalProduct);
            this.TotalPricePanel.Controls.Add(this.picDown);
            this.TotalPricePanel.Controls.Add(this.lblPrice);
            this.TotalPricePanel.Controls.Add(this.lblTotalPrice);
            this.TotalPricePanel.Controls.Add(this.picUp);
            this.TotalPricePanel.Location = new System.Drawing.Point(12, 619);
            this.TotalPricePanel.Name = "TotalPricePanel";
            this.TotalPricePanel.Size = new System.Drawing.Size(601, 107);
            this.TotalPricePanel.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(321, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "שורות בהזמנה:";
            // 
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotalProduct.Location = new System.Drawing.Point(205, 69);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(26, 29);
            this.lblTotalProduct.TabIndex = 2;
            this.lblTotalProduct.Text = "0";
            this.lblTotalProduct.TextChanged += new System.EventHandler(this.lblTotalProduct_TextChanged);
            // 
            // picDown
            // 
            this.picDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.picDown.Image = ((System.Drawing.Image)(resources.GetObject("picDown.Image")));
            this.picDown.Location = new System.Drawing.Point(0, 0);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(100, 105);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDown.TabIndex = 37;
            this.picDown.TabStop = false;
            this.picDown.Click += new System.EventHandler(this.picDown_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(187, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 31);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "0.00";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTotalPrice.Location = new System.Drawing.Point(388, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(85, 31);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "סה\"כ :";
            // 
            // picUp
            // 
            this.picUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUp.Dock = System.Windows.Forms.DockStyle.Right;
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.Location = new System.Drawing.Point(499, 0);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(100, 105);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUp.TabIndex = 36;
            this.picUp.TabStop = false;
            this.picUp.Click += new System.EventHandler(this.picUp_Click);
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AllowUserToResizeColumns = false;
            this.dgvOrderList.AllowUserToResizeRows = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvOrderList.Location = new System.Drawing.Point(12, 78);
            this.dgvOrderList.MultiSelect = false;
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            this.dgvOrderList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvOrderList.RowTemplate.Height = 24;
            this.dgvOrderList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderList.Size = new System.Drawing.Size(600, 544);
            this.dgvOrderList.TabIndex = 29;
            this.dgvOrderList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvOrderList_RowsAdded);
            this.dgvOrderList.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvOrderList_RowsRemoved);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "שם המוצר";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "כמות";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 83;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "מחיר";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 82;
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnAddAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddAmount.ForeColor = System.Drawing.Color.Black;
            this.btnAddAmount.Location = new System.Drawing.Point(633, 192);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(144, 99);
            this.btnAddAmount.TabIndex = 35;
            this.btnAddAmount.Text = "הוספת כמות";
            this.btnAddAmount.UseVisualStyleBackColor = false;
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // btnSubAmount
            // 
            this.btnSubAmount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSubAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSubAmount.ForeColor = System.Drawing.Color.Black;
            this.btnSubAmount.Location = new System.Drawing.Point(633, 86);
            this.btnSubAmount.Name = "btnSubAmount";
            this.btnSubAmount.Size = new System.Drawing.Size(144, 99);
            this.btnSubAmount.TabIndex = 34;
            this.btnSubAmount.Text = "הורדת כמות ";
            this.btnSubAmount.UseVisualStyleBackColor = false;
            this.btnSubAmount.Click += new System.EventHandler(this.btnSubAmount_Click);
            // 
            // btnCancelProductFromOrder
            // 
            this.btnCancelProductFromOrder.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCancelProductFromOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnCancelProductFromOrder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelProductFromOrder.Location = new System.Drawing.Point(633, 403);
            this.btnCancelProductFromOrder.Name = "btnCancelProductFromOrder";
            this.btnCancelProductFromOrder.Size = new System.Drawing.Size(144, 99);
            this.btnCancelProductFromOrder.TabIndex = 33;
            this.btnCancelProductFromOrder.Text = "ביטול מוצר בהזמנה";
            this.btnCancelProductFromOrder.UseVisualStyleBackColor = false;
            this.btnCancelProductFromOrder.Click += new System.EventHandler(this.btnCancelProductFromOrder_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDeleteLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteLine.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteLine.Location = new System.Drawing.Point(632, 298);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(144, 99);
            this.btnDeleteLine.TabIndex = 30;
            this.btnDeleteLine.Text = "מחיקת שורה מהזמנה";
            this.btnDeleteLine.UseVisualStyleBackColor = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddOrder.Enabled = false;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.Black;
            this.btnAddOrder.Location = new System.Drawing.Point(632, 614);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(144, 99);
            this.btnAddOrder.TabIndex = 31;
            this.btnAddOrder.Text = "ביצוע הזמנה";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcOrder);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.btnGeneralProduct);
            this.panel1.Controls.Add(this.btnWine);
            this.panel1.Controls.Add(this.btnHotDrinksAndCoffee);
            this.panel1.Controls.Add(this.btnDish);
            this.panel1.Controls.Add(this.btnSoftDrinksAndAlcohol);
            this.panel1.Controls.Add(this.btnDessert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(796, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 786);
            this.panel1.TabIndex = 38;
            // 
            // btnOTH
            // 
            this.btnOTH.BackColor = System.Drawing.Color.SkyBlue;
            this.btnOTH.Enabled = false;
            this.btnOTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnOTH.ForeColor = System.Drawing.Color.Black;
            this.btnOTH.Location = new System.Drawing.Point(633, 509);
            this.btnOTH.Name = "btnOTH";
            this.btnOTH.Size = new System.Drawing.Size(144, 99);
            this.btnOTH.TabIndex = 40;
            this.btnOTH.Text = "OTH";
            this.btnOTH.UseVisualStyleBackColor = false;
            this.btnOTH.Click += new System.EventHandler(this.btnOTH_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Silver;
            this.TopPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopPanel.BackgroundImage")));
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopPanel.Controls.Add(this.tableLayoutPanel1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1380, 54);
            this.TopPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.35595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.64405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel1.Controls.Add(this.lblOrderTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTableOrder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTime, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1378, 53);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblOrderTime
            // 
            this.lblOrderTime.AutoSize = true;
            this.lblOrderTime.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOrderTime.ForeColor = System.Drawing.Color.White;
            this.lblOrderTime.Location = new System.Drawing.Point(399, 0);
            this.lblOrderTime.Name = "lblOrderTime";
            this.lblOrderTime.Size = new System.Drawing.Size(183, 32);
            this.lblOrderTime.TabIndex = 2;
            this.lblOrderTime.Text = "תאריך ושעה :";
            this.lblOrderTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmployee.Location = new System.Drawing.Point(860, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblEmployee.Size = new System.Drawing.Size(20, 29);
            this.lblEmployee.TabIndex = 5;
            this.lblEmployee.Text = "!";
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTableOrder
            // 
            this.lblTableOrder.AutoSize = true;
            this.lblTableOrder.BackColor = System.Drawing.Color.Transparent;
            this.lblTableOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTableOrder.ForeColor = System.Drawing.Color.White;
            this.lblTableOrder.Location = new System.Drawing.Point(1002, 0);
            this.lblTableOrder.Name = "lblTableOrder";
            this.lblTableOrder.Size = new System.Drawing.Size(373, 38);
            this.lblTableOrder.TabIndex = 0;
            this.lblTableOrder.Text = "הזמנה עבור שולחן מספר";
            this.lblTableOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(102, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTime.Size = new System.Drawing.Size(263, 32);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "01.09.18 10:04:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbTablesList
            // 
            this.cbTablesList.BackColor = System.Drawing.Color.SkyBlue;
            this.cbTablesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbTablesList.ForeColor = System.Drawing.Color.Black;
            this.cbTablesList.FormattingEnabled = true;
            this.cbTablesList.Items.AddRange(new object[] {
            "בחר שולחן"});
            this.cbTablesList.Location = new System.Drawing.Point(475, 836);
            this.cbTablesList.Name = "cbTablesList";
            this.cbTablesList.Size = new System.Drawing.Size(139, 33);
            this.cbTablesList.TabIndex = 41;
            this.cbTablesList.Text = "בחר שולחן";
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDiscount.ID = 66;
            this.btnDiscount.Location = new System.Drawing.Point(319, 748);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(139, 85);
            this.btnDiscount.TabIndex = 39;
            this.btnDiscount.Text = "הנחה";
            this.btnDiscount.UseVisualStyleBackColor = false;
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // nudSumToPay
            // 
            this.nudSumToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.nudSumToPay.Location = new System.Drawing.Point(632, 834);
            this.nudSumToPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSumToPay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSumToPay.Name = "nudSumToPay";
            this.nudSumToPay.Size = new System.Drawing.Size(139, 34);
            this.nudSumToPay.TabIndex = 43;
            // 
            // btnPayPartOfBill
            // 
            this.btnPayPartOfBill.BackColor = System.Drawing.Color.SkyBlue;
            this.btnPayPartOfBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayPartOfBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnPayPartOfBill.ForeColor = System.Drawing.Color.Black;
            this.btnPayPartOfBill.ID = 117;
            this.btnPayPartOfBill.Location = new System.Drawing.Point(633, 720);
            this.btnPayPartOfBill.Name = "btnPayPartOfBill";
            this.btnPayPartOfBill.Size = new System.Drawing.Size(139, 113);
            this.btnPayPartOfBill.TabIndex = 44;
            this.btnPayPartOfBill.Text = "תשלום חשבון חלקי";
            this.btnPayPartOfBill.UseVisualStyleBackColor = false;
            this.btnPayPartOfBill.Click += new System.EventHandler(this.btnPayPartOfBill_Click_1);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1380, 840);
            this.Controls.Add(this.btnPayPartOfBill);
            this.Controls.Add(this.nudSumToPay);
            this.Controls.Add(this.cbTablesList);
            this.Controls.Add(this.btnOTH);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnSelectCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSwitchTable);
            this.Controls.Add(this.TotalPricePanel);
            this.Controls.Add(this.btnAddAmount);
            this.Controls.Add(this.btnSubAmount);
            this.Controls.Add(this.btnCancelProductFromOrder);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.cbDiscount);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBill);
            this.Name = "OrderForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.OrderFormTest_Load);
            this.tcOrder.ResumeLayout(false);
            this.TotalPricePanel.ResumeLayout(false);
            this.TotalPricePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSumToPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblOrderTime;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label lblTableOrder;
        private System.Windows.Forms.TabControl tcOrder;
        private System.Windows.Forms.TabPage tpDish;
        private System.Windows.Forms.TabPage tpSoftDrinksAndAlcohol;
        private System.Windows.Forms.TabPage tpHotDrinksAndCoffee;
        private System.Windows.Forms.TabPage tpDessert;
        private System.Windows.Forms.TabPage tpGeneralProduct;
        private System.Windows.Forms.Button btnDessert;
        private System.Windows.Forms.Button btnHotDrinksAndCoffee;
        private System.Windows.Forms.Button btnDish;
        private System.Windows.Forms.Button btnSoftDrinksAndAlcohol;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGeneralProduct;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.Button btnPay;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox cbDiscount;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.Panel TotalPricePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.DataGridView dgvOrderList;
        private System.Windows.Forms.Button btnAddAmount;
        private System.Windows.Forms.Button btnSubAmount;
        private System.Windows.Forms.Button btnCancelProductFromOrder;
        private System.Windows.Forms.Button btnDeleteLine;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MyBtn btnDiscount;
        private System.Windows.Forms.Button btnOTH;
        private System.Windows.Forms.TabPage tpWine;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbTablesList;
        private System.Windows.Forms.NumericUpDown nudSumToPay;
        private MyBtn btnPayPartOfBill;
    }
}