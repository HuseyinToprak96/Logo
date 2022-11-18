using Layer.Core.Dtos;
using Layer.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Services
{
    public class MailService : IMailService
    {
        public bool MailSender(MailDto mailDto)
        {
            try
            {
                //Yöntem 1
                //var mail = new MailMessage()
                //{
                //    From = new MailAddress(mailDto.SenderMail)
                //};
                //mail.To.Add(new MailAddress(mailDto.Contacts));
                //mail.Subject = mailDto.Subject;
                //mail.Body = mailDto.Body;
                //mail.IsBodyHtml = true;
                //mail.BodyEncoding = Encoding.UTF8;
                //mail.SubjectEncoding = Encoding.UTF8;
                //mail.HeadersEncoding = Encoding.UTF8;
                //var smtpClient = new SmtpClient("smtp.outlook.com", 587)
                //{
                //    EnableSsl = true,
                //    Credentials = new NetworkCredential(mailDto.SenderMail, mailDto.Password)
                //};
                //smtpClient.Send(mail);
                //Yöntem 2
                //MailMessage mailMessage = new MailMessage();
                //SmtpClient smtpClient = new SmtpClient();
                //smtpClient.Credentials = new NetworkCredential(mailDto.SenderMail, mailDto.Password);
                //smtpClient.Port = 587;
                //smtpClient.Host = "smtp.gmail.com";
                //smtpClient.EnableSsl = true;
                //mailMessage.To.Add(new MailAddress(mailDto.Contacts));
                //mailMessage.From = new MailAddress(mailDto.SenderMail);
                //mailMessage.Subject=mailDto.Subject;
                //mailMessage.Body = mailDto.Body;
                //smtpClient.Send(mailMessage);
                //Yöntem 3
                MailMessage message = new MailMessage();
                message.From = new MailAddress(mailDto.SenderMail);
                message.Subject = mailDto.Subject;
                message.To.Add(new MailAddress(mailDto.Contacts));
                message.Body = mailDto.Body;
                message.IsBodyHtml = true;
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port=587,
                    Credentials=new NetworkCredential(mailDto.SenderMail,mailDto.Password),
                    EnableSsl=true
                };
                smtpClient.Send(message);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
