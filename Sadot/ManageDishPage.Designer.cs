namespace Sadot
{
    partial class ManageDishPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpManageDish = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdateDish = new System.Windows.Forms.Button();
            this.cbDishInMenu = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblHeaderIngredients = new System.Windows.Forms.Label();
            this.dgvIngredientsList = new System.Windows.Forms.DataGridView();
            this.ingredientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnAddIngredientsToDish = new System.Windows.Forms.Button();
            this.btnRemoveIngredientFromDish = new System.Windows.Forms.Button();
            this.cbAmount = new System.Windows.Forms.ComboBox();
            this.cbIngredientName = new System.Windows.Forms.ComboBox();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.nudDishPrice = new System.Windows.Forms.NumericUpDown();
            this.lblingredientAmount = new System.Windows.Forms.Label();
            this.lblDishName = new System.Windows.Forms.Label();
            this.lblIngredient = new System.Windows.Forms.Label();
            this.lblDishPrice = new System.Windows.Forms.Label();
            this.tpIngredeints = new System.Windows.Forms.TabPage();
            this.btnUpdateIngredient = new System.Windows.Forms.Button();
            this.btnRemoveIngredient = new System.Windows.Forms.Button();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvDishList = new System.Windows.Forms.DataGridView();
            this.dishName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DishStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddDishForm = new System.Windows.Forms.Button();
            this.btnUpdateForm = new System.Windows.Forms.Button();
            this.btnBackToMainPage = new System.Windows.Forms.Button();
            this.btnManageIngredients = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpManageDish.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishPrice)).BeginInit();
            this.tpIngredeints.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishList)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.tableLayoutPanel2);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 64);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(1309, 678);
            this.panelLeft.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 887F));
            this.tableLayoutPanel2.Controls.Add(this.tcMain, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1309, 678);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tcMain
            // 
            this.tcMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tcMain.Controls.Add(this.tpManageDish);
            this.tcMain.Controls.Add(this.tpIngredeints);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.ItemSize = new System.Drawing.Size(0, 1);
            this.tcMain.Location = new System.Drawing.Point(425, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.Padding = new System.Drawing.Point(0, 20);
            this.tcMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tcMain.RightToLeftLayout = true;
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(881, 672);
            this.tcMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tpMain_SelectedIndexChanged);
            // 
            // tpManageDish
            // 
            this.tpManageDish.Controls.Add(this.tableLayoutPanel1);
            this.tpManageDish.Controls.Add(this.btnUpdateDish);
            this.tpManageDish.Controls.Add(this.cbDishInMenu);
            this.tpManageDish.Controls.Add(this.lblMenu);
            this.tpManageDish.Controls.Add(this.lblHeaderIngredients);
            this.tpManageDish.Controls.Add(this.dgvIngredientsList);
            this.tpManageDish.Controls.Add(this.btnAddDish);
            this.tpManageDish.Controls.Add(this.btnAddIngredientsToDish);
            this.tpManageDish.Controls.Add(this.btnRemoveIngredientFromDish);
            this.tpManageDish.Controls.Add(this.cbAmount);
            this.tpManageDish.Controls.Add(this.cbIngredientName);
            this.tpManageDish.Controls.Add(this.txtDishName);
            this.tpManageDish.Controls.Add(this.nudDishPrice);
            this.tpManageDish.Controls.Add(this.lblingredientAmount);
            this.tpManageDish.Controls.Add(this.lblDishName);
            this.tpManageDish.Controls.Add(this.lblIngredient);
            this.tpManageDish.Controls.Add(this.lblDishPrice);
            this.tpManageDish.Location = new System.Drawing.Point(4, 5);
            this.tpManageDish.Name = "tpManageDish";
            this.tpManageDish.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tpManageDish.Size = new System.Drawing.Size(873, 663);
            this.tpManageDish.TabIndex = 0;
            this.tpManageDish.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblHeader, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(516, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(342, 50);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeader.Location = new System.Drawing.Point(33, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(306, 44);
            this.lblHeader.TabIndex = 41;
            this.lblHeader.Text = "הוספת מנה חדשה";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnUpdateDish
            // 
            this.btnUpdateDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateDish.Location = new System.Drawing.Point(170, 588);
            this.btnUpdateDish.Name = "btnUpdateDish";
            this.btnUpdateDish.Size = new System.Drawing.Size(524, 69);
            this.btnUpdateDish.TabIndex = 53;
            this.btnUpdateDish.Text = "עדכון מנה";
            this.btnUpdateDish.UseVisualStyleBackColor = true;
            this.btnUpdateDish.Click += new System.EventHandler(this.btnUpdateDish_Click);
            // 
            // cbDishInMenu
            // 
            this.cbDishInMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbDishInMenu.FormattingEnabled = true;
            this.cbDishInMenu.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.cbDishInMenu.Location = new System.Drawing.Point(471, 150);
            this.cbDishInMenu.Name = "cbDishInMenu";
            this.cbDishInMenu.Size = new System.Drawing.Size(184, 37);
            this.cbDishInMenu.TabIndex = 52;
            this.cbDishInMenu.Text = "כן";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblMenu.Location = new System.Drawing.Point(673, 150);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(151, 29);
            this.lblMenu.TabIndex = 51;
            this.lblMenu.Text = "מנה בתפריט :";
            // 
            // lblHeaderIngredients
            // 
            this.lblHeaderIngredients.AutoSize = true;
            this.lblHeaderIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHeaderIngredients.Location = new System.Drawing.Point(430, 220);
            this.lblHeaderIngredients.Name = "lblHeaderIngredients";
            this.lblHeaderIngredients.Size = new System.Drawing.Size(368, 36);
            this.lblHeaderIngredients.TabIndex = 48;
            this.lblHeaderIngredients.Text = "הוספה / הסרת מרכיבים למנה";
            // 
            // dgvIngredientsList
            // 
            this.dgvIngredientsList.AllowUserToAddRows = false;
            this.dgvIngredientsList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngredientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIngredientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIngredientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientID,
            this.ingredientName,
            this.ingredientAmount});
            this.dgvIngredientsList.Location = new System.Drawing.Point(16, 259);
            this.dgvIngredientsList.Name = "dgvIngredientsList";
            this.dgvIngredientsList.ReadOnly = true;
            this.dgvIngredientsList.RowHeadersVisible = false;
            this.dgvIngredientsList.RowTemplate.Height = 20;
            this.dgvIngredientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngredientsList.Size = new System.Drawing.Size(404, 298);
            this.dgvIngredientsList.TabIndex = 35;
            // 
            // ingredientID
            // 
            this.ingredientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientID.HeaderText = "מספר מרכיב";
            this.ingredientID.Name = "ingredientID";
            this.ingredientID.ReadOnly = true;
            // 
            // ingredientName
            // 
            this.ingredientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientName.HeaderText = "שם המרכיב";
            this.ingredientName.Name = "ingredientName";
            this.ingredientName.ReadOnly = true;
            // 
            // ingredientAmount
            // 
            this.ingredientAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ingredientAmount.HeaderText = "כמות";
            this.ingredientAmount.Name = "ingredientAmount";
            this.ingredientAmount.ReadOnly = true;
            // 
            // btnAddDish
            // 
            this.btnAddDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddDish.Location = new System.Drawing.Point(170, 588);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(524, 69);
            this.btnAddDish.TabIndex = 34;
            this.btnAddDish.Text = "הוספת מנה חדשה";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnAddIngredientsToDish
            // 
            this.btnAddIngredientsToDish.BackColor = System.Drawing.Color.Lime;
            this.btnAddIngredientsToDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddIngredientsToDish.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddIngredientsToDish.Location = new System.Drawing.Point(654, 467);
            this.btnAddIngredientsToDish.Name = "btnAddIngredientsToDish";
            this.btnAddIngredientsToDish.Size = new System.Drawing.Size(172, 90);
            this.btnAddIngredientsToDish.TabIndex = 32;
            this.btnAddIngredientsToDish.Text = "הוסף מרכיב";
            this.btnAddIngredientsToDish.UseVisualStyleBackColor = false;
            this.btnAddIngredientsToDish.Click += new System.EventHandler(this.btnAddIngredientsToDish_Click);
            // 
            // btnRemoveIngredientFromDish
            // 
            this.btnRemoveIngredientFromDish.BackColor = System.Drawing.Color.Red;
            this.btnRemoveIngredientFromDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemoveIngredientFromDish.Location = new System.Drawing.Point(468, 467);
            this.btnRemoveIngredientFromDish.Name = "btnRemoveIngredientFromDish";
            this.btnRemoveIngredientFromDish.Size = new System.Drawing.Size(172, 90);
            this.btnRemoveIngredientFromDish.TabIndex = 33;
            this.btnRemoveIngredientFromDish.Text = "הסר מרכיב";
            this.btnRemoveIngredientFromDish.UseVisualStyleBackColor = false;
            this.btnRemoveIngredientFromDish.Click += new System.EventHandler(this.btnRemoveIngredientFromDish_Click);
            // 
            // cbAmount
            // 
            this.cbAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbAmount.FormattingEnabled = true;
            this.cbAmount.Items.AddRange(new object[] {
            "0.25",
            "0.5",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbAmount.Location = new System.Drawing.Point(469, 386);
            this.cbAmount.Name = "cbAmount";
            this.cbAmount.Size = new System.Drawing.Size(184, 37);
            this.cbAmount.TabIndex = 30;
            this.cbAmount.Text = "1";
            // 
            // cbIngredientName
            // 
            this.cbIngredientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbIngredientName.BackColor = System.Drawing.SystemColors.Info;
            this.cbIngredientName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cbIngredientName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbIngredientName.FormattingEnabled = true;
            this.cbIngredientName.Location = new System.Drawing.Point(470, 301);
            this.cbIngredientName.Name = "cbIngredientName";
            this.cbIngredientName.Size = new System.Drawing.Size(184, 37);
            this.cbIngredientName.TabIndex = 29;
            // 
            // txtDishName
            // 
            this.txtDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDishName.Location = new System.Drawing.Point(471, 86);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(184, 34);
            this.txtDishName.TabIndex = 38;
            this.txtDishName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDishPrice
            // 
            this.nudDishPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nudDishPrice.Location = new System.Drawing.Point(73, 85);
            this.nudDishPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudDishPrice.Name = "nudDishPrice";
            this.nudDishPrice.Size = new System.Drawing.Size(184, 34);
            this.nudDishPrice.TabIndex = 42;
            // 
            // lblingredientAmount
            // 
            this.lblingredientAmount.AutoSize = true;
            this.lblingredientAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblingredientAmount.Location = new System.Drawing.Point(660, 386);
            this.lblingredientAmount.Name = "lblingredientAmount";
            this.lblingredientAmount.Size = new System.Drawing.Size(163, 29);
            this.lblingredientAmount.TabIndex = 31;
            this.lblingredientAmount.Text = "כמות המרכיב :";
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDishName.Location = new System.Drawing.Point(707, 86);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(118, 29);
            this.lblDishName.TabIndex = 39;
            this.lblDishName.Text = "שם המנה :";
            // 
            // lblIngredient
            // 
            this.lblIngredient.AutoSize = true;
            this.lblIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIngredient.Location = new System.Drawing.Point(681, 301);
            this.lblIngredient.Name = "lblIngredient";
            this.lblIngredient.Size = new System.Drawing.Size(143, 29);
            this.lblIngredient.TabIndex = 27;
            this.lblIngredient.Text = "שם המרכיב :";
            // 
            // lblDishPrice
            // 
            this.lblDishPrice.AutoSize = true;
            this.lblDishPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDishPrice.Location = new System.Drawing.Point(268, 90);
            this.lblDishPrice.Name = "lblDishPrice";
            this.lblDishPrice.Size = new System.Drawing.Size(137, 29);
            this.lblDishPrice.TabIndex = 40;
            this.lblDishPrice.Text = "מחיר המנה :";
            // 
            // tpIngredeints
            // 
            this.tpIngredeints.AutoScroll = true;
            this.tpIngredeints.Controls.Add(this.btnUpdateIngredient);
            this.tpIngredeints.Controls.Add(this.btnRemoveIngredient);
            this.tpIngredeints.Controls.Add(this.btnAddIngredient);
            this.tpIngredeints.Controls.Add(this.txtIngredientName);
            this.tpIngredeints.Controls.Add(this.lblIngredientName);
            this.tpIngredeints.Controls.Add(this.label13);
            this.tpIngredeints.Controls.Add(this.lstIngredients);
            this.tpIngredeints.Location = new System.Drawing.Point(4, 5);
            this.tpIngredeints.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIngredeints.Name = "tpIngredeints";
            this.tpIngredeints.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpIngredeints.Size = new System.Drawing.Size(874, 662);
            this.tpIngredeints.TabIndex = 1;
            this.tpIngredeints.UseVisualStyleBackColor = true;
            // 
            // btnUpdateIngredient
            // 
            this.btnUpdateIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateIngredient.Location = new System.Drawing.Point(498, 486);
            this.btnUpdateIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateIngredient.Name = "btnUpdateIngredient";
            this.btnUpdateIngredient.Size = new System.Drawing.Size(238, 51);
            this.btnUpdateIngredient.TabIndex = 65;
            this.btnUpdateIngredient.Text = "עדכן מרכיב";
            this.btnUpdateIngredient.UseVisualStyleBackColor = true;
            this.btnUpdateIngredient.Click += new System.EventHandler(this.btnUpdateIngredient_Click);
            // 
            // btnRemoveIngredient
            // 
            this.btnRemoveIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnRemoveIngredient.Location = new System.Drawing.Point(498, 371);
            this.btnRemoveIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveIngredient.Name = "btnRemoveIngredient";
            this.btnRemoveIngredient.Size = new System.Drawing.Size(238, 51);
            this.btnRemoveIngredient.TabIndex = 64;
            this.btnRemoveIngredient.Text = "מחק מרכיב";
            this.btnRemoveIngredient.UseVisualStyleBackColor = true;
            this.btnRemoveIngredient.Click += new System.EventHandler(this.btnRemoveIngredient_Click);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddIngredient.Location = new System.Drawing.Point(498, 262);
            this.btnAddIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(238, 51);
            this.btnAddIngredient.TabIndex = 63;
            this.btnAddIngredient.Text = "הוסף מרכיב";
            this.btnAddIngredient.UseVisualStyleBackColor = true;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIngredientName.Location = new System.Drawing.Point(442, 100);
            this.txtIngredientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(235, 30);
            this.txtIngredientName.TabIndex = 62;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblIngredientName.ForeColor = System.Drawing.Color.Black;
            this.lblIngredientName.Location = new System.Drawing.Point(682, 100);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(153, 25);
            this.lblIngredientName.TabIndex = 61;
            this.lblIngredientName.Text = "שם מרכיב להוספה:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(374, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(406, 36);
            this.label13.TabIndex = 60;
            this.label13.Text = "הוספה / עדכון / מחיקת מרכיבים";
            // 
            // lstIngredients
            // 
            this.lstIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.ItemHeight = 29;
            this.lstIngredients.Location = new System.Drawing.Point(20, 91);
            this.lstIngredients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lstIngredients.Size = new System.Drawing.Size(364, 555);
            this.lstIngredients.TabIndex = 59;
            this.lstIngredients.SelectedIndexChanged += new System.EventHandler(this.lstIngredients_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 674);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 682F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(416, 674);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 1);
            this.panel2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, -6);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(410, 678);
            this.panel4.TabIndex = 33;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvDishList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 59);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(410, 619);
            this.panel5.TabIndex = 70;
            // 
            // dgvDishList
            // 
            this.dgvDishList.AllowUserToAddRows = false;
            this.dgvDishList.AllowUserToDeleteRows = false;
            this.dgvDishList.AllowUserToResizeColumns = false;
            this.dgvDishList.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDishList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDishList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDishList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dishName,
            this.dishPrice,
            this.DishStatus});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDishList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDishList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDishList.Location = new System.Drawing.Point(0, 0);
            this.dgvDishList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDishList.Name = "dgvDishList";
            this.dgvDishList.ReadOnly = true;
            this.dgvDishList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvDishList.RowHeadersVisible = false;
            this.dgvDishList.RowTemplate.Height = 20;
            this.dgvDishList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDishList.Size = new System.Drawing.Size(410, 619);
            this.dgvDishList.TabIndex = 66;
            this.dgvDishList.Click += new System.EventHandler(this.dgvDishList_Click);
            // 
            // dishName
            // 
            this.dishName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dishName.HeaderText = "שם המנה";
            this.dishName.Name = "dishName";
            this.dishName.ReadOnly = true;
            this.dishName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dishPrice
            // 
            this.dishPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dishPrice.HeaderText = "מחיר המנה";
            this.dishPrice.Name = "dishPrice";
            this.dishPrice.ReadOnly = true;
            this.dishPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DishStatus
            // 
            this.DishStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DishStatus.HeaderText = "מנה בתפריט";
            this.DishStatus.Name = "DishStatus";
            this.DishStatus.ReadOnly = true;
            this.DishStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(410, 59);
            this.panel6.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(94, 17);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(191, 29);
            this.label2.TabIndex = 67;
            this.label2.Text = "רשימת כל המנות:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1309, 64);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.9354F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnAddDishForm, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdateForm, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackToMainPage, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnManageIngredients, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1309, 64);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnAddDishForm
            // 
            this.btnAddDishForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddDishForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddDishForm.Location = new System.Drawing.Point(983, 3);
            this.btnAddDishForm.Name = "btnAddDishForm";
            this.btnAddDishForm.Size = new System.Drawing.Size(323, 58);
            this.btnAddDishForm.TabIndex = 6;
            this.btnAddDishForm.Text = "הוספת מנה חדשה";
            this.btnAddDishForm.UseVisualStyleBackColor = true;
            this.btnAddDishForm.Click += new System.EventHandler(this.btnAddDishForm_Click);
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUpdateForm.Location = new System.Drawing.Point(656, 3);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(321, 58);
            this.btnUpdateForm.TabIndex = 7;
            this.btnUpdateForm.Text = "עדכון מנה";
            this.btnUpdateForm.UseVisualStyleBackColor = true;
            this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
            // 
            // btnBackToMainPage
            // 
            this.btnBackToMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackToMainPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBackToMainPage.Location = new System.Drawing.Point(3, 3);
            this.btnBackToMainPage.Name = "btnBackToMainPage";
            this.btnBackToMainPage.Size = new System.Drawing.Size(320, 58);
            this.btnBackToMainPage.TabIndex = 3;
            this.btnBackToMainPage.Text = "חזרה למסך הבית";
            this.btnBackToMainPage.UseVisualStyleBackColor = true;
            this.btnBackToMainPage.Click += new System.EventHandler(this.btnBackToMainPage_Click);
            // 
            // btnManageIngredients
            // 
            this.btnManageIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManageIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnManageIngredients.Location = new System.Drawing.Point(329, 3);
            this.btnManageIngredients.Name = "btnManageIngredients";
            this.btnManageIngredients.Size = new System.Drawing.Size(321, 58);
            this.btnManageIngredients.TabIndex = 5;
            this.btnManageIngredients.Text = "ניהול מרכיבים";
            this.btnManageIngredients.UseVisualStyleBackColor = true;
            this.btnManageIngredients.Click += new System.EventHandler(this.btnManageIngredients_Click);
            // 
            // ManageDishPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1309, 742);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageDishPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ניהול מנות ומרכיבים";
            this.Load += new System.EventHandler(this.AdminManageDishPageTest_Load);
            this.panelLeft.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tpManageDish.ResumeLayout(false);
            this.tpManageDish.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngredientsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDishPrice)).EndInit();
            this.tpIngredeints.ResumeLayout(false);
            this.tpIngredeints.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDishList)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateForm;
        private System.Windows.Forms.Button btnAddDishForm;
        private System.Windows.Forms.Button btnManageIngredients;
        private System.Windows.Forms.Button btnBackToMainPage;
        private System.Windows.Forms.TabPage tpManageDish;
        private System.Windows.Forms.Label lblHeaderIngredients;
        private System.Windows.Forms.DataGridView dgvIngredientsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientAmount;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnAddIngredientsToDish;
        private System.Windows.Forms.Button btnRemoveIngredientFromDish;
        private System.Windows.Forms.ComboBox cbAmount;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ComboBox cbIngredientName;
        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.NumericUpDown nudDishPrice;
        private System.Windows.Forms.Label lblingredientAmount;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Label lblIngredient;
        private System.Windows.Forms.Label lblDishPrice;
        private System.Windows.Forms.ComboBox cbDishInMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnUpdateDish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabPage tpIngredeints;
        private System.Windows.Forms.Button btnUpdateIngredient;
        private System.Windows.Forms.Button btnRemoveIngredient;
        private System.Windows.Forms.Button btnAddIngredient;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstIngredients;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvDishList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dishPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DishStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}