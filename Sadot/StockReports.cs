/*
 * SelectCustomer user control code
 * class with the code of the form of stock information and reports to use of the admin in admin panel
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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; 
using MyFont = iTextSharp.text.Font;
using Font = iTextSharp.text.Font;

namespace Sadot
{
    //enum with the months in hebrew to use for headers
    public enum Months
    {
        ינואר = 1,
        פברואר,
        מרץ,
        אפריל,
        מאי,
        יוני,
        יולי,
        אוגוס,
        ספטמבר,
        אוקטובר, 
        נובמר,
        דצמבר
    };

    public partial class StockReports : UserControl
    {
        private Stock[] stock;
        private DBSQL db = new DBSQL();
        private string type;
        private string daysToSum;
        private string sort;
        private Document doc;

        /// <summary>
        /// user control constractor
        /// </summary>
        public StockReports()
        {
            InitializeComponent();
        }

        /// <summary>
        /// method wich works when the StockReports user control loads
        /// </summary>
        private void StockReports_Load(object sender, EventArgs e)
        {
            type = "WHERE 1 GROUP BY `productID`";
            sort = "ORDER BY total DESC";
            DateTime today = DateTime.Today;
            lblTitle.Text = "מלאי לחודש - " + ((Months)DateTime.Now.Month).ToString();
            dtpStartDate.MinDate = new DateTime(today.Year, today.Month, 1);
            dtpStartDate.MaxDate = today;
            //set end date limits
            dtpEndDate.MinDate = new DateTime(today.Year, today.Month, 1);
            dtpEndDate.MaxDate = today;
            //checkMonthAndYearForStock();
        }

        /// <summary>
        /// method wich check the current month and year with the month and year of the current stock
        /// if new month or year make a report, zeroing the current stock (year or month or both) and update to the new year or month
        /// </summary>
        private void checkMonthAndYearForStock()
        {
            DateTime currentDate = DateTime.Now;
            int monthFromStock = db.GetCurrentMonth();
            int yearFromStock = db.GetCurrentyYear();
            string header;
            string qurey;
            //check if this is a new month
            if (currentDate.Month != monthFromStock) 
            {
                qurey = "SELECT productID, product.name , SUM(`1`+`2`+`3`+`4`+`5`+`6`+`7`+`8`+`9`+`10`+`11`+`12`+`13`+`14`+`15`+`16`+`17`+`18`+`19`+`20`+`21`+`22`+`23`+`24`+`25`+`26`+`27`+`28`+`29`+`30`+`31`) AS total FROM `stockByDate` INNER JOIN product ON stockByDate.productID = product.id WHERE 1 GROUP BY `productID` ";
                stock = db.GetStockDataBy(qurey);
                header = "דוח מלאי עבור חודש " + " - " + (Months)monthFromStock + " - " + yearFromStock;
                MakePdfReport(header);
                //db.GetStockDataBy(qurey);
                //loop to pass on all the array with stock details
                for(int i  = 0; i < stock.Length; i++)
                {
                    db.UpdateProductInStockByYear(monthFromStock.ToString(), stock[i].TotalAmount, stock[i].ProductID, currentDate.Month);//(string num, double amount, int productID, int currentMonth)
                }
                db.ResetStockByDate();
            }
            //check if this is a new year
            if (currentDate.Year != yearFromStock)
            {
                qurey = "SELECT productID, product.name , SUM(`1`+`2`+`3`+`4`+`5`+`6`+`7`+`8`+`9`+`10`+`11`+`12`) AS total FROM `stockByYear` INNER JOIN product ON stockByYear.productID = product.id WHERE 1 GROUP BY `productID` ";
                stock = db.GetStockDataBy(qurey);
                header = "דוח מלאי עבור שנת " + " - " + (Months)DateTime.Now.Year;
                MakePdfReport(header);
                db.ResetStockByYear(currentDate.Year);
            }
        }

        /// <summary>
        /// method wich works when the user press on "show stock" button
        /// the method will get the amounts of orders from stock table in the data base by the chosen parameters
        /// and show on table
        /// </summary>
        private void btnShowStock_Click(object sender, EventArgs e)
        {
            daysToSum = DaysToString(dtpStartDate.Value.Day, dtpEndDate.Value.Day);
            string qurey = "SELECT `productID`, product.name , SUM(" + daysToSum + ") AS total FROM `stockByDate` INNER JOIN product ON stockByDate.productID = product.id " + type + " " + sort;
            stock = db.GetStockDataBy(qurey);
            FillStockTable();
        }

        /// <summary>
        /// method to create string of the days between dates to sum
        /// </summary>
        /// <param name="startDay">start date of user chose</param>
        /// <param name="endDay">end date of user chose</param>
        /// <returns></returns>
        private string DaysToString(int startDay, int endDay)
        {
            string res = "";
            for (int i = startDay; i < endDay; i++)
            {
                res += "`" + i + "`" + "+";
            }
            res += "`" + endDay + "`";
            return res;
        }

        /// <summary>
        /// method to get the type from the user chose
        /// </summary>
        /// <param name="type">the type of the user chose</param>
        /// <returns>srting - type of the products</returns>
        private string GetProductType(string type)
        {
            string res = string.Empty;
            if (type == "אוכל")
                res = "Dish";
            if (type == "יינות")
                res = "Wine";
            if (type == "קינוחים")
                res = "Dessert";
            if (type == "כללי")
                res = "General";
            if (type == "שתייה קלה / אלכוהול")
                res = "SoftDrink";
            if (type == "שתייה חמה")
                res = "HotDrink";
            return res;
        }

        /// <summary>
        /// method to fill stock table with the stock array details
        /// </summary>
        private void FillStockTable()
        {
            dgvStockUntilToday.Rows.Clear();
            for (int i = 0; i < stock.Length; i++)
            {
                dgvStockUntilToday.Rows.Add(stock[i].Name, stock[i].TotalAmount);
            }
        }

        /// <summary>
        /// method wich works when the user press on one of the display radios buttons
        /// the method will get the type of the uer chose and update the query to show only the products from this type
        /// </summary>
        private void rbType_Click(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "כל המוצרים")
                type = "WHERE 1 GROUP BY `productID`";
            else
                type = "WHERE product.type = '" + GetProductType(((RadioButton)sender).Text) + "' GROUP BY `productID`";
        }

        /// <summary>
        /// method wich works when the user press on one of the sort radio buttons
        /// the method will get the sort option of the uer chose and update the query
        /// </summary>
        private void rbSort_Click(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "הנמכר ביותר")
                sort = "ORDER BY total DESC";
            else
                sort = "ORDER BY total ASC";
        }

        /// <summary>
        /// method wich works when the user press on "make pdf report" button
        /// the method will make pdf report of the chosen stock details
        /// </summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (dgvStockUntilToday.Rows.Count > 0)
            {
                string header = "דוח הזמנות בין תאריכים: "+ "\n" + dtpEndDate.Value.ToShortDateString() + "  -  " + dtpStartDate.Value.ToShortDateString();
                MakePdfReport(header);
            }
            else
            {
                MessageBox.Show("אין נתונים להוצאת דו''ח");
            }
        }

        /// <summary>
        /// method wich make pdf report from the chosen stock details
        /// </summary>
        /// <param name="reportHeader">the header of the report</param>
        private void MakePdfReport(string reportHeader)
        {
            doc = new Document();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            PdfWriter.GetInstance(doc, new FileStream(path + @"\" + "Stock_report.pdf", FileMode.Create));
            doc.Open();
            PdfReports pdfReports = new PdfReports(doc);
            pdfReports.MakeDocHeader("דו''ח כמויות");
            pdfReports.LineDown(5);
            pdfReports.MakeCenterHeader(reportHeader, 15);
            pdfReports.LineDown(15);
            float[] widthCell = new float[3];
            widthCell[0] = 10;
            widthCell[1] = 30;
            widthCell[2] = 10;
            string[,] detailsMat = StockDetailsToStrings(stock);
            pdfReports.MakeCenterTable(3, widthCell, detailsMat, stock.Length);
            pdfReports.LineDown(20);
            doc.Close();//close file
            MessageBox.Show("דוח המלאי בוצע בהצלחה!");
        }

        /// <summary>
        /// help function to get the stock objects array and make it to matrix of string
        /// every row in the matrix is the details of the stock, first row is the headers of columns
        /// </summary>
        private string[,] StockDetailsToStrings(Stock[] stock)
        {
            int rows = stock.Length + 1;
            int cols = 3;
            string[,] resMat = new string[rows, cols];
            //headers row
            resMat[0, 0] = "מס סדורי";
            resMat[0, 1] = "שם המוצר";
            resMat[0, 2] = "כמות רכישות";
            //loop to put in every row the spicific stock details
            for (int i = 1; i < rows; i++)
            {
                resMat[i, 0] = i.ToString();
                resMat[i, 1] = stock[i - 1].Name;
                resMat[i, 2] = stock[i - 1].TotalAmount.ToString();
            }
            return resMat;
        }
    }
}
