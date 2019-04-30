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
        private LoginPage login;
        DBSQL db = new DBSQL();
        Table[] tables;

        /// <summary>
        /// UserHomePage form constractor
        /// </summary>
        public UserHomePage(LoginPage loginPage)
        {
            InitializeComponent();
            login = loginPage;
        }

        /// <summary>
        /// Set the form size and fill a list of tables
        /// </summary>
        private void UserHomePage_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            FillTableList();
        }

        /// <summary>
        /// The function fill the tables list with table id and table status
        /// </summary>
        private void FillTableList()
        {
            dgvTableList.Rows.Clear();
            tables = db.GetTablesData();
            for (int i = 0; i < tables.Length; i++)
            {
                dgvTableList.Rows.Add(tables[i].TableID, tables[i].TableStatus);
                dgvTableList.Rows[i].Selected = false;
                if (tables[i].TableStatus == "פנוי")
                    FiilRowColor(Color.White, i);
                else if (tables[i].TableStatus == "תפוס")
                    FiilRowColor(Color.Green, i);
                else if (tables[i].TableStatus == "בחשבון")
                    FiilRowColor(Color.SkyBlue, i);
                else
                    FiilRowColor(Color.Yellow, i);
            }
        }

        /// <summary>
        /// method wich fill row color
        /// </summary>
        /// <param name="color">the color to fill</param>
        /// <param name="index">the index of the row to fill it color</param>
        private void FiilRowColor(Color color, int index)
        {
            dgvTableList.Rows[index].DefaultCellStyle.BackColor = color;
        }

        /// <summary>
        /// method wich works when the user press on "Exit" button
        /// the method will close the user home page form and go to login form
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
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
        private void btnTable_Click_1(object sender, EventArgs e)
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
            Table tmpTable = GetTableById(int.Parse(dgvTableList.CurrentRow.Cells[0].Value.ToString()));
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

            if (orderForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                db.UpdateTableStatus(tmpTable.TableID, "תפוס");
            }
            if (orderForm.DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                db.UpdateTableStatus(tmpTable.TableID, "פנוי");
            }
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
                if (tables[i].TableStatus == "בחשבון")
                {
                    tableInBillCounter++;
                    UpdateStockAndOrderStatus(tables[i].TableID);
                    if (tables[i].TableID >= 200)
                        db.DeleteTable(tables[i].TableID);
                    else
                        db.UpdateTableStatus(tables[i].TableID, "פנוי");
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
    }
}
