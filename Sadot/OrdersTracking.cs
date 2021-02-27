/*
 * OrderTracking user control code
 * class with the code of the form of orders tracking and reports of the admin
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
using iTextSharp;//dll namespaces
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; //to create the file
using MyFont = iTextSharp.text.Font; //to work with class in windows form
using Font = iTextSharp.text.Font;

namespace Sadot
{
    public partial class OrdersTracking : UserControl
    {
        private DBSQL db = new DBSQL();
        Order[] orders;
        LinesInOrder[] selctedOrderLines;
        int orderIndex;
        private Document doc;
        private int ordersTotalPrice;
        private int orderTotalPrice;
        Order selectedOrderDetails;
        Employee selectedOrderEmployeeDetails;
        Customer selectedOrderCustomerDetails;
        Table[] tables;
        Customer[] customers;
        private List<CancellationsInOrder> cancelsInOrder; // List with all the canceles of cur order

        /// <summary>
        /// OrdersTracking user control constractor
        /// </summary>
        public OrdersTracking()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  Method wich works when the user control "OrdersTracking" loads
        ///  the method will get tables data from DB and fill the combo boxes
        /// </summary>
        private void OrdersTracking_Load(object sender, EventArgs e)
        {
            cboCustomers.Text = "כל הלקוחות";
            cboTableNum.Text = "כל השולחנות";
            tables = db.GetTablesData();
            customers = db.GetCustomersData();
            FillTabelsComboBox();
            FillCustomersComboBox();
        }

        /// <summary>
        /// method wich works when the user press on "show orders" button
        /// the method will get the orders by the parameters of the user and fill the orders data grid with the information
        /// </summary>
        private void btnShowOrders_Click(object sender, EventArgs e)
        {
            string startD = dtpStartDate.Value.ToString("yyyy-MM-dd");
            string endD = dtpEndDate.Value.ToString("yyyy-MM-dd");
            int startID = -1, endID = -1, startTableID = 0, endTableID = 0, startPrice = 0, endPrice = 0;

            if (cbFromUnLimit.Checked && cbToUnLimit.Checked)
                endPrice = int.MaxValue;
            else if (cbFromUnLimit.Checked)
                endPrice = int.Parse(nudToPrice.Value.ToString());
            else if (cbToUnLimit.Checked)
            {
                startPrice = int.Parse(nudFromPrice.Value.ToString());
                endPrice = int.MaxValue;
            }
            else
            {
                startPrice = int.Parse(nudFromPrice.Value.ToString());
                endPrice = int.Parse(nudToPrice.Value.ToString());
            }

            if (cboCustomers.Text == "כל הלקוחות")
                endID = int.MaxValue;
            else
                startID = endID = int.Parse(cboCustomers.Text);

            if (cboTableNum.Text == "כל השולחנות")
                endTableID = int.MaxValue;
            else
                startTableID = endTableID = int.Parse(cboTableNum.Text);

            orders = db.GetOrdersByParameters(startD, endD, startID, endID, startTableID, endTableID, startPrice, endPrice);
            FillOrdersList();
        }

        /// <summary>
        /// method wich fill tables combo box with all the tables in the resturant
        /// </summary>
        private void FillTabelsComboBox()
        {
            cboTableNum.Items.Add("כל השולחנות");
            cboTableNum.Text = "כל השולחנות";
            //loop to pass on all the tables
            for (int i = 0; i < tables.Length; i++)
            {
                cboTableNum.Items.Add(tables[i].TableID);
            }
        }

        /// <summary>
        /// method wich fill tables combo box with all the customers
        /// </summary>
        private void FillCustomersComboBox()
        {
            cboCustomers.Items.Add("כל הלקוחות");
            cboCustomers.Text = "כל הלקוחות";
            //loop to pass on all customers array
            for (int i = 0; i < customers.Length; i++)
            {
                cboCustomers.Items.Add(customers[i].CustomerId);
            }
        }

        /// <summary>
        /// method wich fill the orders data grid with the orders details from the uset choose
        /// </summary>
        private void FillOrdersList()
        {
            Customer customer = null;
            ordersTotalPrice = 0;
            dgvOrderList.Rows.Clear();
            if (orders.Length == 0)
            {
                MessageBox.Show("לא נמצאו הזמנות לפי הפרמטרים שנבחרו", "הודעת מערכת", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                //loop to pass on all orders array
                for (int i = 0; i < orders.Length; i++)
                {
                    if (orders[i].CustomerId != -1)
                        customer = db.GetCustomerById(orders[i].CustomerId);

                    dgvOrderList.Rows.Add(orders[i].OrderID, orders[i].TableID, (orders[i].CustomerId == -1)? "לא נבחר לקוח" : customer.GetFullName(), orders[i].OrderDate.ToString("dd-MM-yyyy"), orders[i].TotalPrice);
                    dgvOrderList.Rows[i].Selected = false;
                    ordersTotalPrice += orders[i].TotalPrice;
                }
                lblNumberOfOrders2.Text = orders.Length.ToString();
                lblOrdersTotalPrice2.Text = ordersTotalPrice.ToString() + "ש''ח";
            }

        }

        /// <summary>
        /// method wich works when the user select order from data grd
        /// the method will get the selected order details and fill the lines in order data grid
        /// </summary>
        private void dgvOrderList_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.SelectedRows.Count > 0)
            {
                orderIndex = dgvOrderList.CurrentCell.RowIndex;
                selectedOrderDetails = orders[orderIndex];
                selectedOrderEmployeeDetails = db.GetEmployeeById(selectedOrderDetails.EmployeeID);
                selectedOrderCustomerDetails = db.GetCustomerById(selectedOrderDetails.CustomerId);
                selctedOrderLines = db.GetLinesOfOrder(selectedOrderDetails.OrderID);
                FillOrderLines();
            }
        }

        /// <summary>
        /// method wich fill the lines in order panel with the chosen order details 
        /// </summary>
        private void FillOrderLines()
        {
            int lastRowIndex = 0;
            dgvOrderLines.Rows.Clear();
            //loop to pass selected order lines array
            for (int i = 0; i < selctedOrderLines.Length; i++)
            {
                dgvOrderLines.Rows.Add(selctedOrderLines[i].ProductName, selctedOrderLines[i].Amount, selctedOrderLines[i].TotalPrice);
                dgvOrderLines.Rows[i].Selected = false;
            }
            lastRowIndex = selctedOrderLines.Length;
            if (selectedOrderDetails.isCancels())//check if the current order has cancles
            {
                cancelsInOrder = new List<CancellationsInOrder>(db.GetCancelsOfOrder(selectedOrderDetails.OrderID));
                for (int i = 0; i < cancelsInOrder.Count; i++)
                {
                    dgvOrderLines.Rows.Add(cancelsInOrder[i].printName(), 1, cancelsInOrder[i].PriceToSub * -1);
                    dgvOrderLines.Rows[lastRowIndex + i].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }

            lblCustomerName2.Text = (selectedOrderCustomerDetails == null) ? "לא נבחר לקוח" : selectedOrderCustomerDetails.GetFullName();
            lblEmployeeName2.Text = selectedOrderEmployeeDetails.GetFullName();
            lblOrderTotalPrice2.Text = selectedOrderDetails.TotalPrice.ToString() + " ש''ח ";
        }

        /// <summary>
        /// method wich works when the fromUnLimit checked chaged
        /// the method will shows the numric field to fill
        /// </summary>
        private void cbFromUnLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFromUnLimit.Checked == false)
                nudFromPrice.Visible = true;
            else
                nudFromPrice.Visible = false;
        }

        /// <summary>
        /// method wich works when the toUnLimit checked chaged
        /// the method will shows the numric field to fill
        /// </summary>
        private void cbToUnLimit_CheckedChanged(object sender, EventArgs e)
        {
            if (cbToUnLimit.Checked == false)
                nudToPrice.Visible = true;
            else
                nudToPrice.Visible = false;
        }

        /// <summary>
        /// method wich works when the user press on "make orders report" button
        /// the method will make pdf report on desktop with all the orders detail
        /// </summary>
        private void btnOrdersReport_Click(object sender, EventArgs e)
        {
            if (dgvOrderList.Rows.Count > 0)
            {
                doc = new Document();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                PdfWriter.GetInstance(doc, new FileStream(path + @"\" + "Orders_report.pdf", FileMode.Create));
                doc.Open();
                PdfReports pdfReports = new PdfReports(doc);
                pdfReports.MakeDocHeader("דו''ח הזמנות בין התאריכים:");
                pdfReports.LineDown(5);
                pdfReports.MakeCenterHeader(dtpEndDate.Value.ToShortDateString() + "  -  " + dtpStartDate.Value.ToShortDateString(), 15);
                pdfReports.LineDown(15);
                float[] widthCell = new float[5];
                widthCell[0] = 25;
                widthCell[1] = 25;
                widthCell[2] = 40;
                widthCell[3] = 22;
                widthCell[4] = 25;
                string[,] detailsMat = OrdersDetailsToStrings(orders);
                pdfReports.MakeCenterTable(5, widthCell, detailsMat, orders.Length);
                pdfReports.LineDown(20);
                pdfReports.MakeRightHeader("סכ''ה הזמנות: " + orders.Length, 15);
                pdfReports.LineDown(10);
                pdfReports.MakeRightHeader("סכום הזמנות כולל: " + ordersTotalPrice, 15);
                doc.Close();//close file
                MessageBox.Show("דוח הזמנות בוצע בהצלחה!");
            }
        }

        /// <summary>
        /// help function to get the orders objects array and make it to matrix of string
        /// every row in the matrix is the details of the order, first row is the headers of columns
        /// </summary>
        private string[,] OrdersDetailsToStrings(Order[] orderArray)
        {
            int rows = orderArray.Length + 1;
            int cols = 5;
            string[,] resMat = new string[rows, cols];
            //headers row
            resMat[0, 0] = "מספר הזמנה";
            resMat[0, 1] = "מספר שולחן";
            resMat[0, 2] = "פרטי הלקוח";
            resMat[0, 3] = "תאריך הזמנה";
            resMat[0, 4] = "מחיר כולל";
            //loop to put in every row the spicific supplier details
            for (int i = 1; i < rows; i++)
            {
                resMat[i, 0] = orderArray[i - 1].OrderID.ToString();
                resMat[i, 1] = orderArray[i - 1].TableID.ToString();
                if (orderArray[i - 1].CustomerId != -1)
                {
                    Customer c = db.GetCustomerById(orderArray[i - 1].CustomerId);
                    resMat[i, 2] = c.FirstName + " " + c.LastName + " (" + c.CustomerId + ") ";
                }
                else
                    resMat[i, 2] = "לא נבחר לקוח";
                resMat[i, 3] = orderArray[i - 1].OrderDate.ToString();
                resMat[i, 4] = orderArray[i - 1].TotalPrice.ToString();
            }
            return resMat;
        }

        /// <summary>
        /// method wich works when the user press on "make spcific order report" button
        /// the method will make pdf report on desktop with the spcific chosen order detail
        /// </summary>
        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            if (dgvOrderLines.Rows.Count > 0)
            {
                doc = new Document();
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                PdfWriter.GetInstance(doc, new FileStream(path + @"\" + "Order_Number_" + selectedOrderDetails.OrderID + "_report.pdf", FileMode.Create));
                doc.Open();
                PdfReports pdfReports = new PdfReports(doc);
                pdfReports.MakeDocHeader("דו''ח עבור הזמנה מספר " + selectedOrderDetails.OrderID.ToString() + " : ");
                pdfReports.LineDown(10);
                pdfReports.MakeCenterHeader(dtpEndDate.Value.ToShortDateString() + "  -  " + dtpStartDate.Value.ToShortDateString(), 15);
                pdfReports.LineDown(15);
                pdfReports.MakeRightHeader("מלצר מבצע: " + selectedOrderEmployeeDetails.FirstName + " " + selectedOrderEmployeeDetails.LastName, 15);
                pdfReports.LineDown(5);
                pdfReports.MakeRightHeader((selectedOrderCustomerDetails == null) ? "לקוח מבצע: לא נבחר לקוח" : "לקוח מבצע: " + selectedOrderCustomerDetails.GetFullName(), 15);
                pdfReports.LineDown(10);
                float[] widthCell = new float[4];
                widthCell[0] = 5;
                widthCell[1] = 5;
                widthCell[2] = 20;
                widthCell[3] = 5;
                string[,] detailsMat = OrderDetailsToStrings(selctedOrderLines);
                pdfReports.MakeCenterTable(4, widthCell, detailsMat, selctedOrderLines.Length);
                pdfReports.LineDown(20);
                pdfReports.MakeRightHeader("מספר שורות בהזמנה: " + selctedOrderLines.Length, 15);
                pdfReports.LineDown(10);
                pdfReports.MakeRightHeader("סך ההזמנה: " + ordersTotalPrice + "ש\"ח ", 15);
                doc.Close();//close file
                MessageBox.Show("דוח עבור הזמנה ספציפית בוצע בהצלחה!");
            }
        }

        /// <summary>
        /// help function to get the lines in order objects array and make it to matrix of string
        /// every row in the matrix is the details of the spcsific line in order, first row is the headers of columns
        /// </summary>
        private string[,] OrderDetailsToStrings(LinesInOrder[] orderArray)
        {
            int rows = orderArray.Length + 1;
            int cols = 4;
            string[,] resMat = new string[rows, cols];

            //headers row
            resMat[0, 0] = "מס שורה";
            resMat[0, 1] = "שם המוצר";
            resMat[0, 2] = "כמות";
            resMat[0, 3] = "מחיר";

            //loop to put in every row the spicific supplier details
            for (int i = 1; i < rows; i++)
            {
                resMat[i, 0] = i.ToString();
                resMat[i, 1] = orderArray[i - 1].ProductName;
                resMat[i, 2] = orderArray[i - 1].Amount.ToString();
                resMat[i, 3] = orderArray[i - 1].TotalPrice.ToString();
            }
            return resMat;
        }
    }
}