using Layer.Core.Dtos;
using Layer.Core.Interfaces.BLL;
using Layer.Core.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Service.Business
{
    public class XReportBLL:IXReportBLL
    {
        private readonly IMailService _mailService;

        public XReportBLL(IMailService mailService)
        {
            _mailService = mailService;
        }

        public bool SendMail(XReportDatas report,MailDto mailDto)
        {
            mailDto.Body += "<style>td, th {padding:8px;text-align:left;border-bottom: 1px solid #ddd; }table {border-collapse: collapse;width: 80%;margin:auto;}</style> ";
            mailDto.Body += $"<h3> Değerli müşterimiz :{report.FirmName} A.Ş.</h3>";
            mailDto.Body += $"<p>{DateTime.Now.ToShortDateString()} tarihi itibari ile firmanızın tarafımızdan yapmış olduğu alımlarla ilgili mevcut bakiyeniz {1} TL'dir.</p> ";
            mailDto.Body += $"<p>Cari hesabınızda görünen açık faturalarınızın tamamı aşağıdaki listede belirtilmiş olup, ilk açık fatura tarihi {report.FirstDate.ToShortDateString()}'dur.</p> ";
            mailDto.Body += "<table><tr><th> Başlık 1 </th><th> Başlık 2 </th><th> Başlık 3 </th><th> Başlık 4 </th><th> Başlık 5 </th></tr>";
            for (int i = 1; i <= 5; i++)
            {
                mailDto.Body += $"<tr><td>{report.Data1} {i}</td><td> {report.Data2} {i} </td><td>{report.Data3} {i}</td><td>{report.Data4} {i}</td><td>{report.Data5} {i} </td></tr>";
            }
            mailDto.Body += $"</table><br /><p><strong> {DateTime.Now.ToShortDateString()} </strong> tarihi itibari ile vadesi dolan toplam bakiyeniz<strong> {1} TL </strong> olacaktır.</ br> Mutabakatlarınız için aşağıdaki mail adreslerinden bize ulaşabilirsiniz.Cari hesap mutabakatları için mail adresi : mutabakat @mercekbilisim.com.tr. BA / BS mutabakatları için mail adresi : tahsilat @mercekbilisim.com.tr <br /><br /><hr />Banka Havalesi ile ödemeleriniz için hesap numaralarımız ise aşağıdaki gibidir.</p> <br /><br /><table><tr><th> Başlık 1 </th><th> Başlık 2 </th> <th> Başlık 3 </th><th> Başlık 4 </th> <th> Başlık 5 </th> </tr> ";
            for (int i = 1; i <= 5; i++)
            {
                mailDto.Body += $"<tr><td> {report.Data6} {i} </td><td> {report.Data7} {i} </td><td> {report.Data8} {i} </td><td> {report.Data9} {i} </td> <td> {report.Data10} {i} </td> </tr> ";
            }
            mailDto.Body+= "   </table><br /><br /><hr /><p>İşbirliğiniz için teşekkür eder, iyi çalışmalar dileriz.<br /><a href = 'www.google.com' > MERCEK BİLİŞİM </ a></p> ";
            return _mailService.MailSender(mailDto);
        }
    }
}
