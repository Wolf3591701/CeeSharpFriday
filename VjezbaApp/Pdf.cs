using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VjezbaApp
{
    public class Pdf
    {
        static void GeneratePdf(string[] args)
        {
            //Create PDF
            PdfDocument document = new PdfDocument();

            //Add a page to the created PDF
            PdfPage page = document.AddPage();

            //For drawing in PDF Page you will nedd XGraphics Object
            XGraphics graphics = XGraphics.FromPdfPage(page);

            //font selection
            XFont font = new XFont("Verdana", 20, XFontStyle.Regular);

            //page formatting
            graphics.DrawString("Sup peeps!", font, XBrushes.Aqua,
            new XRect(10, 10, page.Width, page.Height),
            XStringFormats.Center);

            // Save the document...
            string filename = "Sup.pdf";
            document.Save(filename);

        }
    }
}


