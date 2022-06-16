/*
 * ResturentStatus user control code
 * class with the code of the resturent status when admin enter to the panel
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public partial class RestaurantStatus : UserControl
    {
        DBSQL db = new DBSQL();
        Table[] tables;
        Order currentOrder;
        private List<CancellationsInOrder> cancelsInOrder; // List with all the canceles of cur order

        /// <summary>
        /// RestaurantStatus user control constractor
        /// </summary>
        public RestaurantStatus()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Method wich works when the user control "Restaurant status" loads
        ///  the method will get tables data from DB and fill the tables data grid
        /// </summary>
        private void RestaurantStatus_Load(object sender, EventArgs e)
        {
            tables = db.GetTablesData();
            FillTableList();
        }

        /// <summary>
        ///  Method wich fill table data grid with tables data and current status
        /// </summary>
        private void FillTableList()
        {
            dgvTableList.Rows.Clear();
            tables = db.GetTablesData();
            //loop to pass on all the tables in the array
            for (int i = 0; i < tables.Length; i++)
            {
                dgvTableList.Rows.Add(tables[i].TableID, tables[i].TableStatus);
                dgvTableList.Rows[i].Selected = false;
                if (tables[i].TableStatus == "פנוי")
                    FiilRowColor(Color.White, i);
                if (tables[i].TableStatus == "בחשבון")
                    FiilRowColor(Color.Orange, i);
                if (tables[i].TableStatus == "תפוס")
                    FiilRowColor(Color.Green, i);
            }
        }

        /// <summary>
        /// The function fill row color 
        /// </summary>
        /// <param name="color">Color to paint the row with</param>
        /// <param name="index">index of the row to paint</param>
        private void FiilRowColor(Color color, int index)
        {
            dgvTableList.Rows[index].DefaultCellStyle.BackColor = color;
        }

        /// <summary>
        ///  Method wich works when the user press on table from the data grid
        ///  if the table is occupied - the order details show
        ///  if the table is unoccupied - the order details remove
        /// </summary
        private void dgvTableList_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvTableList.SelectedRows.Count > 0)
            {
                if (dgvTableList.CurrentRow.Cells[1].Value.ToString() != "פנוי")//occupied
                {
                    currentOrder = db.GetOrderByTableId(int.Parse(dgvTableList.CurrentRow.Cells[0].Value.ToString()));
                    FillPanelWithOrderDetails();
                }
                else//unoccupied
                    ClearDetails();
            }
        }

        /// <summary>
        /// Method to fill the order details panel with the details of the chosen table order
        /// </summary>
        public void FillPanelWithOrderDetails()
        {
            LinesInOrder[] linesInOrder = db.GetLinesOfOrder(currentOrder.OrderID);

            Employee emp = db.GetEmployeeById(currentOrder.EmployeeID);
            FillLinesInOrderList(linesInOrder);
            lblTableNum.Text = currentOrder.TableID.ToString();
            if (currentOrder.CustomerId != -1)
            {
                Customer customer = db.GetCustomerById(currentOrder.CustomerId);
                lblCustomerName.Text = customer.FirstName + " " + customer.LastName;
            }
            else
                lblCustomerName.Text = "לא נבחר לקוח";

            lblEmployeeName.Text = emp.FirstName + " " + emp.LastName;
            lblOrderAmount.Text = currentOrder.TotalPrice.ToString() + " ש''ח ";
        }

        /// <summary>
        /// Method to fill lines in order data grid with the order of the choosen table
        /// </summary>
        /// <param name="linesInOrder"></param>
        private void FillLinesInOrderList(LinesInOrder[] linesInOrder)
        {
            int lastRowIndex = 0;
            dgvOrderList.Rows.Clear();
            //loop to pass on all the lines in the specific order
            for (int i = 0; i < linesInOrder.Length; i++)
            {
                dgvOrderList.Rows.Add(linesInOrder[i].ProductName, linesInOrder[i].Amount, linesInOrder[i].TotalPrice);
                dgvOrderList.Rows[i].Selected = false; 
            }
            lastRowIndex = linesInOrder.Length;
            if (currentOrder.isCancels())//check if the current order has cancles
            {
                cancelsInOrder = new List<CancellationsInOrder>(db.GetCancelsOfOrder(currentOrder.OrderID));
                for (int i = 0; i < cancelsInOrder.Count; i++)
                {
                    dgvOrderList.Rows.Add(cancelsInOrder[i].printName(), 1, cancelsInOrder[i].PriceToSub * -1);
                    dgvOrderList.Rows[lastRowIndex + i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
        }

        /// <summary>
        /// Method wich clear the panel with order details
        /// </summary>
        private void ClearDetails()
        {
            dgvOrderList.Rows.Clear();
            lblCustomerName.Text = "";
            lblEmployeeName.Text = "";
            lblTableNum.Text = "";
            lblOrderAmount.Text = "";
        }

        /// <summary>
        /// timer method to update the clock
        /// </summary>
        private void tmr_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lblDateTime.Text = date.ToString("dd/MM/yyyy  HH:mm:ss");
        }

        /// <summary>
        /// method wich works when the user press on "refresh table list" button
        /// the method will refresh the tables details to the update details
        /// </summary>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            tables = db.GetTablesData();
            FillTableList();
        }
    }
}
