/*
 * PrintBon class code
 * class with the code of bons and bill print options
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sadot
{
    public class PrintBon
    {
        private PrintDocument pdoc = null;
        private LinesInOrder[] linesInOrde;
        private int table;
        private Employee selectedEmployee;
        private DBSQL db = new DBSQL(); 
        private List<LinesInOrder> kitchen = new List<LinesInOrder>();
        private List<LinesInOrder> Bar = new List<LinesInOrder>();
        private List<LinesInOrder> Waiters = new List<LinesInOrder>();
        private LinesInOrder[] Receipt;
        private String underLine = "----------------------------------"; 
        private Font titleFont = new Font("Courier New", 25, FontStyle.Bold);
        private Font infoFont = new Font("Courier New", 15);
        private Font bonFontBold = new Font("Courier New", 18, FontStyle.Bold);
        private Font bonFontBold_2 = new Font("Courier New", 14, FontStyle.Bold);
        private Font bonFont = new Font("Courier New", 15);
        private Font underLineFont = new Font("Courier New", 10);
        private PaperSize psize = new PaperSize("Custom", 80, 200);
        private int startX = 0;
        private int startY = 0;
        private int Offset = 0;
        private int endX = 280;
        Graphics graphics;
        StringFormat drawFormatCenter;
        StringFormat drawFormatLeft;
        StringFormat drawFormatRight;
        private CancellationsInOrder[] curr_order_cancellations;

        /*additions to glass and take away bottle to prevent duplicate lines IDS*/
        public const int GLASS_ID_SCALE_FACTOR = 4000;
        public const int TA_BOTTLE_ID_SCALE_FACTOR = 6000;

        /// <summary>
        /// method wich send the event of printing and all the necessary information to print on the bon
        /// (lines in order arra, table number, emploee id)
        /// </summary>
        public void Print(LinesInOrder[] linesInOrdersToPrint, int tableNumber , int employeeID)
        {
            linesInOrde = linesInOrdersToPrint;
            table = tableNumber;
            selectedEmployee = db.GetEmployeeById(employeeID);
            FillListsToPrintBon();
            if (kitchen.Count > 0)
            {
                CreateDocToPrintByDepartment(pdoc_PrintKitehen);
            }
            if (Bar.Count > 0)
            {
                CreateDocToPrintByDepartment(pdoc_PrintBar);
            }
            if (Waiters.Count > 0)
            {
                CreateDocToPrintByDepartment(pdoc_PrintWaiters);
            }
        }

        /// <summary>
        /// method wich send to the correct event by the department
        /// </summary>
        /// <param name="department"></param>
        void CreateDocToPrintByDepartment(PrintPageEventHandler department)
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            pdoc.DefaultPageSettings.PaperSize.Height = 3000;
            pdoc.DefaultPageSettings.PaperSize.Width = 500;
            pdoc.PrintPage += new PrintPageEventHandler(department);
            pdoc.Print();
        }

        /// <summary>
        /// method wich fill the lists to print the details on the bon
        /// </summary>
        /// <param name="department"></param>
        private void FillListsToPrintBon()
        {
            string department = string.Empty;
            for (int i = 0; i < linesInOrde.Length; i++)
            {
                LinesInOrder curr_line = new LinesInOrder(linesInOrde[i]);

                if (curr_line.isLineGlass())
                    curr_line.ProductID -= GLASS_ID_SCALE_FACTOR;

                if (curr_line.isLineTakeAwayBottle())
                    curr_line.ProductID -= TA_BOTTLE_ID_SCALE_FACTOR;

                department = db.GetProdductDepartmentByID(curr_line.ProductID);
                if (department == "kitchen")
                    kitchen.Add(curr_line);
                if (department == "Bar")
                    Bar.Add(curr_line);
                if (department == "Waiters")
                    Waiters.Add(curr_line);
                department = string.Empty;
            }
        }

        /// <summary>
        /// method wich print bon to "kitchen" department
        /// </summary>
        void pdoc_PrintKitehen(object sender, PrintPageEventArgs e)
        {
            func(" מטבח ", e);
            for (int i = 0; i < kitchen.Count; i++)
            {
                string productOriginalName = string.Empty;
                productOriginalName = db.GetProductNameByID(kitchen[i].ProductID);
                if (productOriginalName != kitchen[i].ProductName)
                {
                    string[] str = kitchen[i].ProductName.Split(new char[] { '-' });
                    graphics.DrawString(str[0] + " X" + kitchen[i].Amount, bonFontBold, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 30), drawFormatRight);
                    Offset = Offset + 25;
                    for (int j = 1; j < str.Length; j++)
                    {
                        graphics.DrawString(str[j] + "___-", bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
                        Offset = Offset + 20;
                    }
                }
                else
                {
                    graphics.DrawString(kitchen[i].ProductName + " X" + kitchen[i].Amount, bonFontBold, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
                    Offset = Offset + 20;
                }

            }
            Offset = Offset + 20;
            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 40;
        }

        /// <summary>
        /// method wich print bon to "bar" department
        /// </summary>
        void pdoc_PrintBar(object sender, PrintPageEventArgs e)
        {
            func(" בר ", e);
            for (int i = 0; i < Bar.Count; i++)
            {
                string productType = db.GetProductTypeByID(Bar[i].ProductID); 
                if ("Wine" == productType)
                {
                    if(Bar[i].ProductName.Contains("-"))
                    {
                        string[] str = Bar[i].ProductName.Split(new char[] { '-' });
                        graphics.DrawString(str[0] + " X" + Bar[i].Amount, bonFontBold, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 30), drawFormatRight);
                        Offset = Offset + 20;
                        graphics.DrawString(str[1] + "_____", bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
                        Offset = Offset + 20;
                        if (Bar[i].isLineBottle())
                        {
                            graphics.DrawString(Bar[i].Notes + "X  כוסות", bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
                            Offset = Offset + 20;
                        }
                    }
                    else
                    {
                        graphics.DrawString(Bar[i].ProductName + " X" + Bar[i].Amount, bonFontBold_2, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 30), drawFormatRight);
                        Offset = Offset + 25;
                    }
                }
                else
                {
                    graphics.DrawString(Bar[i].ProductName + " X" + Bar[i].Amount, bonFontBold, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 30), drawFormatRight);
                    Offset = Offset + 25;
                }
            }
            Offset = Offset + 20;
            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 40;
        }

        /// <summary>
        /// function to print bon to "watiers" department
        /// </summary>
        void pdoc_PrintWaiters(object sender, PrintPageEventArgs e)
        {

            func(" מלצריות ", e);
            for (int i = 0; i < Waiters.Count; i++)
            {
                graphics.DrawString(Waiters[i].ProductName + " X" + Waiters[i].Amount, bonFontBold, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
                Offset = Offset + 20;
            }
            Offset = Offset + 20;
            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 40;
        }

        /// <summary>
        /// method wich make the start necessary definitions
        /// make to prevent duplication of code
        /// </summary>
        /// <param name="department">the string with the department of the bon to pront in the header</param>
        /// <param name="e">necessary for graphic variable</param>
        private void func(string department, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            startX = 0;
            startY = 0;
            Offset = 0;
            endX = 280;

            drawFormatCenter = new StringFormat();
            drawFormatCenter.Alignment = StringAlignment.Center;
            drawFormatLeft = new StringFormat();
            drawFormatLeft.Alignment = StringAlignment.Near;
            drawFormatRight = new StringFormat();
            drawFormatRight.Alignment = StringAlignment.Far;

            graphics.DrawString(department, titleFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 40), drawFormatCenter);
            Offset = Offset + 40;
            graphics.DrawString(" שולחן : " + table, infoFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
            Offset = Offset + 20;
            graphics.DrawString(" שעה   : " + DateTime.Now.ToShortTimeString(), infoFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
            Offset = Offset + 20;
            graphics.DrawString(" מלצר  : " + selectedEmployee.FirstName, infoFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
            Offset = Offset + 30;

            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
        }

        ///// <summary>
        ///// method wich fill the lists to print the details on the receipt
        ///// </summary>
        ///// <param name="orderLines">the array with the lines of the order to print on the receipt</param>
        //private void FillListsToPrintReceipt(LinesInOrder[] orderLines)
        //{
        //    string department = string.Empty;
        //    for (int i = 0; i < orderLines.Length; i++)
        //    {
        //        if (orderLines[i].isLineGlass())
        //            orderLines[i].ProductID -= GLASS_ID_SCALE_FACTOR;

        //        if (orderLines[i].isLineTakeAwayBottle())
        //            orderLines[i].ProductID -= TA_BOTTLE_ID_SCALE_FACTOR;

        //        department = db.GetProdductDepartmentByID(orderLines[i].ProductID);
        //        if (department == "kitchen")
        //            kitchen.Add(orderLines[i]);
        //        if (department == "Bar")
        //            Bar.Add(orderLines[i]);
        //        if (department == "Waiters")
        //            Waiters.Add(orderLines[i]);
        //        department = string.Empty;
        //    }
        //}
        private Order orderInfo;

        /// <summary>
        /// method wich print the recept of order
        /// </summary>
        /// <param name="orderLines">the array with the lines of the order to print on the receipt</param>
        /// <param name="tableNumber">the table numebr of the order</param>
        /// <param name="order">the order of the table</param>
        public void PrintReceipt(LinesInOrder[] orderLines , int tableNumber , Order order)
        {
            Receipt = orderLines;
            table = tableNumber;
            orderInfo = order;
            CreateDocToPrintByDepartment(pdoc_PrintReceipt);
        }

        /// <summary>
        /// method wich print the receipt of order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void pdoc_PrintReceipt(object sender, PrintPageEventArgs e)
        {
            graphics = e.Graphics;
            int dif = 5;
            int width = 42;
            int height = 30;
            string date = "" + DateTime.Now.ToShortDateString() + "  -  " + DateTime.Now.ToShortTimeString();

            startX = 0;
            startY = 0;
            Offset = 0;
            endX = 280;


            drawFormatCenter = new StringFormat();
            drawFormatCenter.Alignment = StringAlignment.Center;
            drawFormatLeft = new StringFormat();
            drawFormatLeft.Alignment = StringAlignment.Near;
            drawFormatRight = new StringFormat();
            drawFormatRight.Alignment = StringAlignment.Far;

            //Logo
            Image img = System.Drawing.Image.FromFile("logo.bmp");
            graphics.DrawImage(img, new Rectangle(startX, startY + Offset, endX, 100));
            Offset = Offset + 100;//Space between lines

            graphics.DrawString("Sadot Winery", titleFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 40), drawFormatCenter);
            Offset = Offset + 40;//Space between lines
            graphics.DrawString(" שולחן : " + table , underLineFont , new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset, endX, 20), drawFormatRight);
            Offset = Offset + 20;//Space between lines
            graphics.DrawString(" תאריך : " + date, underLineFont, new SolidBrush(Color.Black), new Rectangle(startX, startY + Offset , endX, 20), drawFormatRight);
            Offset = Offset + 30;//Space between lines


            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;


            startY = Offset;
            graphics.DrawString("סה\"כ", new Font("Courier New", 10 , FontStyle.Underline), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
            startX += width + dif;
            graphics.DrawString("כמות", new Font("Courier New", 10 , FontStyle.Underline), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
            startX += width + dif;
            graphics.DrawString("מחיר", new Font("Courier New", 10 , FontStyle.Underline), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
            startX += width + dif;
            graphics.DrawString("פריט", new Font("Courier New", 10 , FontStyle.Underline), new SolidBrush(Color.Black), new Rectangle(startX, startY, 130, height), drawFormatRight);
            startX = 0;
            startY += height + dif;

            for (int i = 0; i < Receipt.Length; i++)
            {
                if(Receipt[i].ProductName.Contains("על חשבון הבית"))
                    graphics.DrawString("OTH", new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                else
                    graphics.DrawString(Receipt[i].TotalPrice.ToString(), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                startX += width + dif;
                graphics.DrawString(Receipt[i].Amount.ToString() , new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                startX += width + dif;
                graphics.DrawString((Receipt[i].TotalPrice / Receipt[i].Amount).ToString(), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                startX += width + dif;
                if(Receipt[i].isLineGlass() || Receipt[i].isLineTakeAwayBottle())
                    graphics.DrawString(SplitProductName(Receipt[i].ProductName.ToString()) + "\n" + Receipt[i].Notes, new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, 130, height), drawFormatRight);
                else if (Receipt[i].isLineBottle())
                    graphics.DrawString(SplitProductName(Receipt[i].ProductName.ToString()) + "\n" +"בקבוק", new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, 130, height), drawFormatRight);
                else
                    graphics.DrawString(SplitProductName(Receipt[i].ProductName.ToString()), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, 130, height), drawFormatRight);
                startX = 0;
                startY += height + dif;
            }

            if(orderInfo.isCancels())
            {
                curr_order_cancellations = db.GetCancelsOfOrder(orderInfo.OrderID);
                for (int i = 0; i < curr_order_cancellations.Length; i++)
                {
                    graphics.DrawString((curr_order_cancellations[i].PriceToSub * -1).ToString(), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                    startX += width + dif;
                    graphics.DrawString("1", new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                    startX += width + dif;
                    graphics.DrawString((curr_order_cancellations[i].PriceToSub).ToString(), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, width, height), drawFormatRight);
                    startX += width + dif;
                    graphics.DrawString(curr_order_cancellations[i].printNameForRecipt(db), new Font("Courier New", 8), new SolidBrush(Color.Black), new Rectangle(startX, startY, 130, height), drawFormatRight);
                    startX = 0;
                    startY += height + dif;
                }
            }

            graphics.DrawString(underLine, underLineFont, new SolidBrush(Color.Black), startX, startY );
            startY = startY + 20;
            graphics.DrawString("סה\"כ       : " + (orderInfo.TotalPrice - orderInfo.Discount) + " ש\"ח " , bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY , endX, 20), drawFormatRight);
            startY +=  20;

            if(orderInfo.Discount > 0)
            {
                graphics.DrawString("הנחה         : " + orderInfo.Discount.ToString() + " ש\"ח ", bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY, endX, 20), drawFormatRight);
                startY += 20;
            }
            graphics.DrawString("סה\"כ לתשלום: " + orderInfo.TotalPrice.ToString() + " ש\"ח ", bonFont, new SolidBrush(Color.Black), new Rectangle(startX, startY, endX, 30), drawFormatRight);
            startY += 20;
            graphics.DrawString("תודה רבה יקב שדות", underLineFont, new SolidBrush(Color.Black), new Rectangle(startX, startY , endX, 20), drawFormatRight);
            startY += 20;
            graphics.DrawString("מסמך זה אינו קבלה" , underLineFont, new SolidBrush(Color.Black), new Rectangle(startX, startY , endX, 20), drawFormatRight);
            startY += 20;
        }

        /// <summary>
        /// method wich split product name
        /// </summary>
        /// <param name="productName">the string with the name to split</param>
        /// <returns></returns>
        private string SplitProductName(string productName)
        {
            string[] str = productName.Split('-');
            return str[0];
        }
    }
}