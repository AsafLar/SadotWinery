using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDFWEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Download()
        {
            var document = new Document(PageSize.A4);

            //document = new Document(new Rectangle(288f, 144f), 20, 20, 20, 20);
            //document.SetPageSize(iTextSharp.text.PageSize.A4.Rotate());


            var stream = new MemoryStream();
            var writer = PdfWriter.GetInstance(document, stream);



            PdfPTable table = CreateTable();

            document.Open();
            document.Add(table);
            document.Close();

            var ms = new MemoryStream(stream.ToArray());
            ms.Seek(0, SeekOrigin.Begin);
            var file = File(ms, "application/pdf");
            file.FileDownloadName = "דוח.pdf";

            return file;
        }

        private PdfPTable CreateTable()
        {
            BaseFont bf = BaseFont.CreateFont(Server.MapPath("~/Fonts/GISHA.ttf"), BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            Font gisha = new Font(bf, 12, Font.BOLD, Color.WHITE);

            PdfPTable table = new PdfPTable(2);
            table.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            ////////////////
            PdfPCell cell = new PdfPCell(new Phrase("מזהה", gisha));
            cell.BackgroundColor = Color.BLACK;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("שם", gisha));
            cell.BackgroundColor = Color.BLACK;
            table.AddCell(cell);
            ////////////////

            gisha = new Font(bf, 12, Font.NORMAL, Color.BLACK);
            var colorEven = new Color(200, 200, 200);

            ///////////////////
            cell = new PdfPCell(new Phrase("123", gisha));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("שלמה גולדברג", gisha));
            table.AddCell(cell);
            ///////////////////

            ///////////////////
            cell = new PdfPCell(new Phrase("5555", gisha));
            cell.BackgroundColor = colorEven;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("יוסי גולדברג", gisha));
            cell.BackgroundColor = colorEven;
            table.AddCell(cell);
            ///////////////////

            ///////////////////
            cell = new PdfPCell(new Phrase("8874", gisha));
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("נועם שפר", gisha));
            table.AddCell(cell);
            ///////////////////

            ///////////////////
            cell = new PdfPCell(new Phrase("31334", gisha));
            cell.BackgroundColor = colorEven;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("חגי כהן", gisha));
            cell.BackgroundColor = colorEven;
            table.AddCell(cell);
            ///////////////////
            return table;
        }
    }
}
