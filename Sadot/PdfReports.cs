/*
 * PdfReports class code
 * class with the code of pdf reports options
 * programmers: Asaf lariach & Yotam kaufman 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;//dll namespaces
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO; //to create the file
using MyFont = iTextSharp.text.Font; //to work with class in windows form
using Font = iTextSharp.text.Font;
using System.Windows.Forms;

namespace Sadot
{
    class PdfReports
    {
        private Document doc;
        private DBSQL db = new DBSQL();
        private BaseFont bf;
        private MyFont myFont;

        /// <summary>
        /// Constractor function
        /// </summary>
        /// <param name="doc">the spcific doc pointer</param>
        public PdfReports(Document doc)
        {
            this.doc = doc;
            bf = BaseFont.CreateFont(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "/Fonts/Fonts/GISHA.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
        }

        /// <summary>
        /// method wich make the doc header
        /// </summary>
        /// <param name="str">the string of the header</param>
        public void MakeDocHeader(string str)
        {
            myFont = new MyFont(bf, 30, MyFont.BOLD);
            myFont.Color = BaseColor.BLUE;

            PdfPTable header = new PdfPTable(1);
            header.DefaultCell.BorderWidth = 0;
            header.HorizontalAlignment = Element.ALIGN_CENTER;
            header.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            PdfPCell headerCell = new PdfPCell();
            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headerCell.Phrase = new Phrase(str, myFont);
            headerCell.BorderWidth = 0;
            header.AddCell(headerCell);

            doc.Add(header);
        }

        /// <summary>
        /// method wich make header in the center of page
        /// </summary>
        /// <param name="str">the string of the header</param>
        /// <param name="fontSize">the size of the header</param>
        public void MakeCenterHeader(string str, int fontSize)
        {
            myFont = new MyFont(bf, fontSize, MyFont.BOLD);
            myFont.Color = BaseColor.BLACK;

            PdfPTable header = new PdfPTable(1);
            header.DefaultCell.BorderWidth = 0;
            header.HorizontalAlignment = Element.ALIGN_CENTER;
            header.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            PdfPCell headerCell = new PdfPCell();
            headerCell.HorizontalAlignment = Element.ALIGN_CENTER;
            headerCell.Phrase = new Phrase(str, myFont);
            headerCell.BorderWidth = 0;
            header.AddCell(headerCell);

            doc.Add(header);
        }

        /// <summary>
        /// method wich make header in the right of page
        /// </summary>
        /// <param name="str">the string of the header</param>
        /// <param name="fontSize">the size of the header</param>
        public void MakeRightHeader(string str, int fontSize)
        {
            myFont = new MyFont(bf, fontSize, MyFont.BOLD);
            myFont.Color = BaseColor.BLACK;

            PdfPTable header = new PdfPTable(1);
            header.DefaultCell.BorderWidth = 0;
            header.HorizontalAlignment = Element.ALIGN_LEFT;
            header.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            PdfPCell headerCell = new PdfPCell();
            headerCell.HorizontalAlignment = Element.ALIGN_LEFT;
            headerCell.Phrase = new Phrase(str, myFont);
            headerCell.BorderWidth = 0;
            header.AddCell(headerCell);

            doc.Add(header);
        }

        /// <summary>
        /// method wich makes center table in the document
        /// </summary>
        /// <param name="cols">number of columns</param>
        /// <param name="widthCell">size of cell</param>
        /// <param name="detailsMat">the details to put in the cells</param>
        /// <param name="rows">number of rows</param>
        public void MakeCenterTable(int cols, float[] widthCell, string[,] detailsMat, int rows)
        {
            PdfPTable myTable = new PdfPTable(cols);
            myTable.HorizontalAlignment = Element.ALIGN_CENTER;
            myTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            myTable.SetTotalWidth(widthCell);

            //create cell and set it view
            PdfPCell myCell = new PdfPCell();
            myCell.BackgroundColor = BaseColor.WHITE;
            myCell.FixedHeight = 20;
            myCell.BorderColor = BaseColor.DARK_GRAY;
            myCell.HorizontalAlignment = Element.ALIGN_CENTER;
            myCell.VerticalAlignment = Element.ALIGN_MIDDLE;

            //create the headers of the table in the pdf file
            myFont = new MyFont(bf, 14, MyFont.BOLD);
            for (int i = 0; i < cols; i++)
            {
                myCell.Phrase = new Phrase(detailsMat[0, i], myFont);
                myTable.AddCell(myCell);
            }
            //create the table text and add it to the file
            myFont = new MyFont(bf, 12, MyFont.NORMAL);
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    myCell.Phrase = new Phrase(detailsMat[i, j], myFont);
                    myTable.AddCell(myCell);
                }
            }
            doc.Add(myTable);
        }

        /// <summary>
        /// method wich go line downs in the document
        /// </summary>
        /// <param name="sizeToDown">the size to line down</param>
        public void LineDown(int sizeToDown)
        {
            doc.Add(new Paragraph("\n", new MyFont(bf, sizeToDown, MyFont.BOLD)));//paragraph to line down
        }
    }
}

