using DinkToPdf.Contracts;
using Layer.Core.Dtos;
using Layer.Core.Interfaces.BLL;
using Layer.Core.Interfaces.Service;
using Layer.Core.Models;
using Layer.Service.Business;
using Layer.Service.Business.DesignPatterns.ChainOfResponsibility;
using Layer.Service.Business.DesignPatterns.CommandDesignPattern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Logo.Models;
using Web.Logo.Sablons;
namespace Web.Logo.Controllers
{
    public class ReportController : Controller
    {
        private static List<BankaDto> Bankas=new();
        private static MailReportSuccess _reportSuccess=new();
        private readonly IReportService _reportService;
        private readonly IXReportBLL _xReportBLL;
        private readonly IConverter converter;
        public ReportController(IReportService reportService, IXReportBLL xReportBLL, IConverter converter)
        {
            _reportService = reportService;
            _xReportBLL = xReportBLL;
            this.converter = converter;
        }
        public async Task<IActionResult> List()
        {
            return View(await _reportService.Reports());
        }
        public IActionResult Create()
        {
           //var deneme=  _reportService.Deneme();
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Create(Report report)
        {
            await _reportService.AddAsync(report);
            return RedirectToAction("List");
        }
        public IActionResult XReport(int p=0)
        {
            Bankas = new List<BankaDto>();
            _reportSuccess = new();
            ViewBag.Error = p;
            return View(_reportService.GetReport2(DateTime.Now,DateTime.Now,1));
        }
        [HttpPost]
        public async Task<IActionResult> XReport(string receiverMail,DateTime firstDate,DateTime endDate)
        {
            var result =await _reportService.GetReport(firstDate,endDate);
            result.FirstDate = firstDate;
            result.EndDate = endDate;
            MailDto mailDto = new MailDto { Contacts = receiverMail, SenderMail = "ht241224@gmail.com", Password= "kpgzddcyriovphrd", Subject="Bilgilendirme" };
           var status= _xReportBLL.SendMail(result, mailDto);
            int str = 0;
            str = status ? 1 : -1;
            return Redirect("/Report/XReport?p="+str);
        }

        public IActionResult MailZip()
        {
            List<XReportTableDatas> list = new List<XReportTableDatas>();
            for (int i = 1; i <= 20; i++)
            {
                XReportTableDatas data = new XReportTableDatas { Amount = i, Balance = 20 * i, Day = i, Description = $"Açıklama {i}", ExpiryDate=DateTime.Now, TransactionDate=DateTime.Now, TransactionNumber=$"00000{i}", TransactionType=$"İslem {i}" };
                list.Add(data);
            }
            var excelProcessHandler = new ExcelProcessHandler<XReportTableDatas>();
            var zipFileProcessHandler = new ZipFileProcessHandler<XReportTableDatas>(".xlsx");
            var sendEmailProcessHandler = new SendEmailProcessHandler("hesapozeti.zip", _reportSuccess.Email);
            excelProcessHandler.SetNext(zipFileProcessHandler).SetNext(sendEmailProcessHandler);
            excelProcessHandler.Handle(list);
            return RedirectToAction("XReport");
        }
        public async Task<IActionResult> PdfZipMail()
        {
            var db = await _reportService.GetExpiryReportDatas(DateTime.Now, DateTime.Now);//
            if (Bankas != null && Bankas.Count>0 && _reportSuccess!=null && _reportSuccess.Email!="" ) { 
            var data = _reportService.GetReport2(_reportSuccess.FirstDate,_reportSuccess.EndDate,_reportSuccess.Language);
            data.Bankas = Bankas;
            var pdfProcessHandler = new PdfProcessHandler("hesapozet.pdf",HttpContext);
            //pdfProcessHandler.Handle(data);
            var zipFileProcessHandler = new ZipFileProcessHandler<XReportTableDatas>(".pdf");
            var sendEmailProcessHandler = new SendEmailProcessHandler("hesapozeti.zip", _reportSuccess.Email);
            pdfProcessHandler.SetNext(zipFileProcessHandler).SetNext(sendEmailProcessHandler);
            pdfProcessHandler.Handle(SablonMailOrDownload.XReport(data));
                return RedirectToAction("XReport");
            }
            return Redirect("/Report/XReport?p="+-1);
        }
        public IActionResult Download(int transaction)
        {
            var data = _reportService.GetReport2(_reportSuccess.FirstDate, _reportSuccess.EndDate,_reportSuccess.Language);
            data.Bankas = Bankas;
            FileCreateInvoker fileCreateInvoker = new FileCreateInvoker();
            PdfFile pdfFile = new PdfFile("veri.pdf",HttpContext,SablonMailOrDownload.XReport(data));
            fileCreateInvoker.SetCommand(new CreatePdfExcelTableActionCommand(pdfFile));
            return fileCreateInvoker.CreateFile(); ;
        }
        public IActionResult Edit(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Report report)
        {
            return View();
        }
        public JsonResult Remove(int id)
        {
            return Json(0);
        }
        public JsonResult AddBank(string json)
        {
            var bank = JsonConvert.DeserializeObject<BankaDto>(json);
            bank.Id =Bankas.Count>0? Bankas.LastOrDefault().Id + 1:1;
            Bankas.Add(bank);
            return Json(bank.Id);
        }
        public JsonResult RemoveBank(int id)
        {
            var count = Bankas.Count;
            if (Bankas.Remove(Bankas.Where(x => x.Id == id).FirstOrDefault()))
            {
            return Json(1);
            }
            return Json(0);
        }
        public JsonResult Success(string json)
        {
            var reportSuccess = JsonConvert.DeserializeObject<MailReportSuccess>(json);
            if (_reportSuccess.Email == null || _reportSuccess.Email=="")
            {
                _reportSuccess = reportSuccess;
                return Json(1);
            }
            return Json(0);
        }
    }
}
