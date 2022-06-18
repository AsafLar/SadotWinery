/*
 * UserHomePage form code
 * class with the code of the form of tables in the resturent that user have to chose to place order
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{ 
    public partial class UserHomePage : Form
    {
        const UInt16 TABLE_ID_0 = 0;
        const UInt16 MAX_TABLES = 26;
        private LoginPage login;
        DBSQL db = new DBSQL();
        Table[] tables;
        Timer updateTableListTimer = new Timer();
        MyBtn[] tableButtons = new MyBtn[MAX_TABLES];
        const Int16 ONE_SEC_TIMER_VALUE = 1000; //in mili seconds

        /// <summary>
        /// UserHomePage form constractor
        /// </summary>
        public UserHomePage(LoginPage loginPage)
        {
            InitializeComponent();
            login = loginPage;
            CreateTableButtons();
        }

        /// <summary>
        /// Set the form size and fill a list of tables
        /// </summary>
        private void UserHomePage_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            FillTableList();

            updateTableListTimer.Interval = ONE_SEC_TIMER_VALUE;
            updateTableListTimer.Tick += new EventHandler(updateTableListTimer_Tick);
            updateTableListTimer.Start();
        }

        /// <summary>
        /// The function fill the tables list with table id and table status
        /// </summary>
        private void FillTableList()
        {
            tables = db.GetTablesData();
            if(tables != null)
            {
                TablesDataGridView.Rows.Clear();
                for (int i = 0; i < tables.Length; i++)
                {
                    Color rowAndTableButtonColor = Color.White;

                    //At order in process case we calculate the time of waiting inside GetTimeOfOrderCalculation()
                    TablesDataGridView.Rows.Add(tables[i].TableID, tables[i].TableStatus, tables[i].OrderState, tables[i].GetTimeOfOrderCalculation().ToString("mm:ss"));
                    TablesDataGridView.Rows[i].Selected = false;

                    switch (tables[i].TableStatus)
                    {
                        case "פנוי":
                            rowAndTableButtonColor = (tables[i].OrderStateNotExists()) ? Color.White : Color.Yellow;
                            break;

                        case "תפוס":
                            rowAndTableButtonColor = (tables[i].OrderInProcess()) ? Color.Red : Color.Green;
                            break;

                        case "בחשבון":
                            rowAndTableButtonColor = Color.SkyBlue;
                            break;

                        default:
                            break;
                    }

                    FiilRowColor(rowAndTableButtonColor, i);
                    tableButtons[tables[i].TableID].BackColor = rowAndTableButtonColor;
                }
            }
        }

        /// <summary>
        /// method wich fill row color
        /// </summary>
        /// <param name="color">the color to fill</param>
        /// <param name="index">the index of the row to fill it color</param>
        private void FiilRowColor(Color color, int index)
        {
            TablesDataGridView.Rows[index].DefaultCellStyle.BackColor = color;
        }

        /// <summary>
        /// method wich works when the user press on "Exit" button
        /// the method will close the user home page form and go to login form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            updateTableListTimer.Stop();
            this.Close();
        }

        /// <summary>
        /// method wich works when the UserHomePage form closed
        /// the method will show the login form
        /// </summary>
        private void UserHomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Show();
        }

        /// <summary>
        /// method wich works when the user press on one of the tables buttons
        /// the method will get the table details from data base and open the order form 
        /// of the chosen table
        /// </summary>
        private void btnTableClickEvent(object sender, EventArgs e)
        {
            Table tmpTable = GetTableById(((MyBtn)sender).ID);
            OpenOrderForm(tmpTable);
        }

        /// <summary>
        /// method wich works when the user press on table from the list
        /// the method will get the chosen table details from data base and open the order form 
        /// of the chosen table
        /// </summary>
        private void dgvTableList_Click(object sender, EventArgs e)
        {
            Table tmpTable = GetTableById(int.Parse(TablesDataGridView.CurrentRow.Cells[0].Value.ToString()));
            OpenOrderForm(tmpTable);
        }

        /// <summary>
        /// method to open the chosen table order form
        /// </summary>
        /// <param name="tmpTable">the table to open it order form</param>
        private void OpenOrderForm(Table tmpTable)
        {
            OrderForm orderForm = new OrderForm(tmpTable);
            orderForm.ShowDialog();
            bool updateTable = true;

            switch (orderForm.DialogResult)
            {
                //User pressd on "ביצוע הזמנה" button
                case DialogResult.OK: 
                    tmpTable.TableStatus = "תפוס";
                    tmpTable.OrderState = "הזמנה בהכנה";
                    tmpTable.TimeOfOrder = DateTime.Now;
                    break;

                //User pressd on "שולם" button
                case DialogResult.Yes:
                    tmpTable.TableStatus = "פנוי";
                    tmpTable.OrderState = "לא קיימת הזמנה";
                    tmpTable.TimeOfOrder = DateTime.MinValue;
                    break;

                //User pressd on "יציאה" button
                case DialogResult.Abort:
                    tmpTable.OrderState = (tmpTable.IsTableAvailable()) ? "לא קיימת הזמנה" : tmpTable.OrderState;
                    break;

                //User pressd on "החלף שולחן" button
                case DialogResult.Ignore:
                default:
                    updateTable = false;
                    break;
            }

            if(updateTable)
                db.UpdateTableParams(ref tmpTable);

            FillTableList();
        }

        /// <summary>
        /// method wich get table details by it id
        /// </summary>
        /// <param name="id">the if of the table to get his object</param>
        /// <returns></returns>
        public Table GetTableById(int id)
        {
            Table res = null;
            for (int i = 0; i < tables.Length; i++)
            {
                if (id == tables[i].TableID)
                    res = tables[i];
            }
            return res;
        }

        /// <summary>
        /// method wich works when the user press on "CloseAllTablesInBill" button
        /// the method will close all the tables in status "bill" and it orders and send to update stock
        /// </summary>
        private void btnCloseTablesInBill_Click(object sender, EventArgs e)
        {
            int tableInBillCounter = 0;
            for (int i = 0; i < tables.Length; i++)
            {
                if (tables[i].IsTableInBill())
                {
                    tableInBillCounter++;
                    UpdateStockAndOrderStatus(tables[i].TableID);
                    tables[i].TableStatus = "פנוי";
                    tables[i].OrderState = "לא קיימת הזמנה";
                    tables[i].TimeOfOrder = DateTime.MinValue;
                    db.UpdateTableParams(ref tables[i]);
                }
            }
            if(tableInBillCounter > 0)
            {
                if (tableInBillCounter == 1)
                    MessageBox.Show("השולחן נסגר בהצלחה");
                else
                    MessageBox.Show(tableInBillCounter + " שולחנות נסגרו בהצלחה");
            }
            else
                MessageBox.Show("אין שולחנות שהסטטוס שלהם בחשבון!");
            FillTableList();
        }


        /// <summary>
        /// method wich update stock and order status
        /// the method get spcific table order and lines in order and update the stock and order status
        /// </summary>
        /// <param name="tableId">the table to get it order from data base</param>
        private void UpdateStockAndOrderStatus(int tableId)
        {
            Order tableOrder = db.GetOrderByTableId(tableId);
            LinesInOrder[] linesOfTheTableOrder = db.GetLinesOfOrder(tableOrder.OrderID);
            Stock tmpStock = new Stock();
            for (int i = 0; i < linesOfTheTableOrder.Length; i++)
            {
                tmpStock.ProductID = linesOfTheTableOrder[i].ProductID;
                if (linesOfTheTableOrder[i].Notes == "כוס")
                {
                    tmpStock.TotalAmount = linesOfTheTableOrder[i].Amount / 4;
                }
                tmpStock.TotalAmount = linesOfTheTableOrder[i].Amount;
                tmpStock.Date = DateTime.Now.Day.ToString();
                db.UpdateProductInStockByDate(tmpStock.Date, tmpStock.TotalAmount, tmpStock.ProductID);
            }
            tableOrder.IsPaid = true;
            db.UpdateOrder(tableOrder);
        }

        /// <summary>
        /// Timr event wich updates the table list every timer tick
        /// </summary>
        private void updateTableListTimer_Tick(object sender, EventArgs e)
        {
            FillTableList();
        }

        /// <summary>
        /// method wich Create table buttons objects, initilaze and assigned them to main panel controls
        /// </summary>
        public void CreateTableButtons()
        {
            for (int i = TABLE_ID_0; i < MAX_TABLES; i++)
            {
                tableButtons[i] = new MyBtn(i, new System.EventHandler(this.btnTableClickEvent));
            }
                
            InitilazeTableButtonsDefaultsAttributes();

            for (int i = TABLE_ID_0; i < MAX_TABLES; i++)
            {
                MainPanel.Controls.Add(tableButtons[i]);
            }
        }

        /// <summary>
        /// method wich initilaze table buttons objects with default hard coded values
        /// </summary>
        public void InitilazeTableButtonsDefaultsAttributes()
        {
            tableButtons[0].Location = new System.Drawing.Point(357, 657);
            tableButtons[0].Size = new System.Drawing.Size(103, 90);
            tableButtons[0].TabIndex = 63;

            tableButtons[1].Location = new System.Drawing.Point(623, 651);
            tableButtons[1].Size = new System.Drawing.Size(74, 96);
            tableButtons[1].TabIndex = 64;

            tableButtons[2].Location = new System.Drawing.Point(828, 703);
            tableButtons[2].Size = new System.Drawing.Size(74, 96);
            tableButtons[2].TabIndex = 61;
  
            tableButtons[3].Location = new System.Drawing.Point(782, 408);
            tableButtons[3].Size = new System.Drawing.Size(99, 252);
            tableButtons[3].TabIndex = 32;
 
            tableButtons[4].Location = new System.Drawing.Point(704, 290);
            tableButtons[4].Size = new System.Drawing.Size(109, 88);
            tableButtons[4].TabIndex = 60;

            tableButtons[5].Location = new System.Drawing.Point(623, 200);
            tableButtons[5].Size = new System.Drawing.Size(204, 55);
            tableButtons[5].TabIndex = 35;

            tableButtons[6].Location = new System.Drawing.Point(623, 113);
            tableButtons[6].Size = new System.Drawing.Size(204, 55);
            tableButtons[6].TabIndex = 36;

            tableButtons[7].Location = new System.Drawing.Point(482, 134);
            tableButtons[7].Size = new System.Drawing.Size(90, 90);
            tableButtons[7].TabIndex = 38;

            tableButtons[8].Location = new System.Drawing.Point(482, 258);
            tableButtons[8].Size = new System.Drawing.Size(90, 90);
            tableButtons[8].TabIndex = 40;

            tableButtons[9].Location = new System.Drawing.Point(529, 417);
            tableButtons[9].Size = new System.Drawing.Size(103, 90);
            tableButtons[9].TabIndex = 34;

            tableButtons[10].Location = new System.Drawing.Point(529, 531);
            tableButtons[10].Size = new System.Drawing.Size(103, 90);
            tableButtons[10].TabIndex = 62;
            
            tableButtons[11].Location = new System.Drawing.Point(263, 497);
            tableButtons[11].Size = new System.Drawing.Size(90, 75);
            tableButtons[11].TabIndex = 47;

            tableButtons[12].Location = new System.Drawing.Point(266, 377);
            tableButtons[12].Size = new System.Drawing.Size(90, 76);
            tableButtons[12].TabIndex = 46;

            tableButtons[13].Location = new System.Drawing.Point(263, 258);
            tableButtons[13].Size = new System.Drawing.Size(87, 65);
            tableButtons[13].TabIndex = 41;

            tableButtons[14].Location = new System.Drawing.Point(266, 147);
            tableButtons[14].Size = new System.Drawing.Size(87, 65);
            tableButtons[14].TabIndex = 42;

            tableButtons[15].Location = new System.Drawing.Point(111, 185);
            tableButtons[15].Size = new System.Drawing.Size(51, 84);
            tableButtons[15].TabIndex = 56;
            tableButtons[15].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            tableButtons[16].Location = new System.Drawing.Point(111, 89);
            tableButtons[16].Size = new System.Drawing.Size(51, 84);
            tableButtons[16].TabIndex = 57;
            tableButtons[16].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            tableButtons[17].Location = new System.Drawing.Point(168, 16);
            tableButtons[17].Size = new System.Drawing.Size(142, 42);
            tableButtons[17].TabIndex = 51;
            
            tableButtons[18].Location = new System.Drawing.Point(357, 16);
            tableButtons[18].Size = new System.Drawing.Size(142, 42);
            tableButtons[18].TabIndex = 50;
            
            tableButtons[19].Location = new System.Drawing.Point(601, 16);
            tableButtons[19].Size = new System.Drawing.Size(142, 42);
            tableButtons[19].TabIndex = 49;

            tableButtons[20].Location = new System.Drawing.Point(787, 20);
            tableButtons[20].Size = new System.Drawing.Size(142, 42);
            tableButtons[20].TabIndex = 48;
            
            tableButtons[21].Location = new System.Drawing.Point(876, 96);
            tableButtons[21].Size = new System.Drawing.Size(53, 89);
            tableButtons[21].TabIndex = 58;
            tableButtons[21].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            tableButtons[22].Location = new System.Drawing.Point(876, 200);
            tableButtons[22].Size = new System.Drawing.Size(53, 84);
            tableButtons[22].TabIndex = 59;
            tableButtons[22].TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            tableButtons[23].ForeColor = System.Drawing.SystemColors.ControlText;
            tableButtons[23].Location = new System.Drawing.Point(3, 447);
            tableButtons[23].Size = new System.Drawing.Size(73, 164);
            tableButtons[23].TabIndex = 33;

            tableButtons[24].Location = new System.Drawing.Point(-2, 617);
            tableButtons[24].Size = new System.Drawing.Size(78, 75);
            tableButtons[24].TabIndex = 43;

            tableButtons[25].Location = new System.Drawing.Point(-2, 706);
            tableButtons[25].Size = new System.Drawing.Size(78, 68);
            tableButtons[25].TabIndex = 44;
        }
    }
}
