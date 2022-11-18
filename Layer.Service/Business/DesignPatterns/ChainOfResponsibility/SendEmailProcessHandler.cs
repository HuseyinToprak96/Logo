using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Business.DesignPatterns.ChainOfResponsibility
{
    public class SendEmailProcessHandler:ProcessHandler
    {
        private readonly string _fileName;
        private readonly string _toEmail;
        public SendEmailProcessHandler(string fileName,string toEmail)
        {
            _fileName = fileName;
            _toEmail = toEmail;
        }
        public override object Handle(object o)
        {
            try
            {
                var zipMemoryStream = o as MemoryStream;
                zipMemoryStream.Position = 0;
                MailMessage message = new MailMessage();
                message.From = new MailAddress("ht241224@gmail.com");
                message.Subject = "Hesap Özeti";
                message.To.Add(new MailAddress(_toEmail));
                message.Body = "<h4>Zip Dosyası ektedir.</h4>";
                Attachment attachment = new Attachment(zipMemoryStream, _fileName, MediaTypeNames.Application.Zip);
                message.Attachments.Add(attachment);

                message.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("ht241224@gmail.com", "kpgzddcyriovphrd"),
                    EnableSsl = true
                };
                smtpClient.Send(message);
            }
            catch
            {
                
            }
            return base.Handle(null);
        }
    }
}
