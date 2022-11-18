using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Business.DesignPatterns.CommandDesignPattern
{
    public class CreatePdfExcelTableActionCommand : ITableActionCommand
    {
        private PdfFile _pdfFile;
        public CreatePdfExcelTableActionCommand(PdfFile pdfFile)
        {
            _pdfFile = pdfFile;
        }
        public IActionResult Execute()
        {
            var excelMemoryStream = _pdfFile.Create();
            return new FileContentResult(excelMemoryStream.ToArray(), _pdfFile.fileType) { FileDownloadName=_pdfFile._fileName };
        }
    }
}
