using DinkToPdf;
using DinkToPdf.Contracts;
using Layer.Core.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Business.DesignPatterns.ChainOfResponsibility
{
    public class PdfProcessHandler:ProcessHandler
    {
        private string _fileName;
        private string fileType => "application/octet-stream";
        private readonly HttpContext _context;
        public PdfProcessHandler(string fileName, HttpContext context)
        {
            _fileName = fileName;
            _context = context;
        }

        public override object Handle(object o)
        {
            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
        ColorMode = ColorMode.Color,
        Orientation = Orientation.Portrait,
        PaperSize = PaperKind.A4,
    },
                Objects = {
        new ObjectSettings() {
            PagesCount = true,
            HtmlContent = o.ToString(),
            WebSettings = { DefaultEncoding = "utf-8",UserStyleSheet=Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/lib/bootstrap/dist/css/bootstrap.css") },
            HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
        }
    }
            };

            var converter = _context.RequestServices.GetRequiredService<IConverter>();
            var x = converter.Convert(doc);
            MemoryStream pdfMs = new MemoryStream(x);
            return base.Handle(pdfMs);
        }
    }
}
