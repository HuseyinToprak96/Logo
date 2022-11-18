using Layer.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Logo.Sablons
{
    public static class SablonMailOrDownload
    {
            public static StringBuilder XReport(XReportDatas datas)
            {
                var sb = new StringBuilder();
                sb.Append($@"<html>
<head></head>
<body>
<div>
 <h3> Değerli müşterimiz :{datas.FirmName} A.Ş.</h3>
<p>
    {datas.FirstDate} tarihi itibari ile firmanızın tarafımızdan yapmış olduğu alımlarla ilgili mevcut bakiyeniz {datas.ExpiryTotalBalance} TL'dir.
</p>
</div>
<table class='table table-striped' align='center'>
<tr>
<th>Vade Tarihi</th>
<th>İşlem Tarihi</th>
<th>İşlem No</th>
<th>İşlem Türü</th>
<th>Açıklama</th>
<th>Gün</th>
<th>Tutar</th>
<th>Bakiye</th>
</tr>
");
                foreach (var data in datas.ExpiryDatas)
                {
                    sb.Append($@"<tr>
<td>{data.ExpiryDate}</td>
<td>{data.TransactionDate}</td>
<td>{data.TransactionNumber}</td>
<td>{data.TransactionType}</td>
<td>{data.Description}</td>
<td>{data.Day}</td>
<td>{data.Amount}</td>
<td>{data.Balance}</td>
</tr>");
                }
                sb.Append("</table>");
                sb.Append($@"<br />
<p>
    <strong> {datas.EndDate}</strong> tarihi itibari ile vadesi dolan toplam bakiyeniz <strong> {datas.NotExpiryTotalBalance} TL</strong> olacaktır.

    Mutabakatlarınız için aşağıdaki mail adreslerinden bize ulaşabilirsiniz.
<hr />
    Cari hesap mutabakatları için mail adresi :{datas.CariHesapMail}
<hr />
    BA/BS mutabakatları için mail adresi : {datas.BA_BS_Mail}
    <br />
    <hr />
</p>
<br />
<table class='table table-striped' align='center'>
<tr>
<th>Vade Tarihi</th>
<th>İşlem Tarihi</th>
<th>İşlem No</th>
<th>İşlem Türü</th>
<th>Açıklama</th>
<th>Gün</th>
<th>Tutar</th>
<th>Bakiye</th>
</tr>");
                foreach (var data in datas.NotExpiryDatas)
                {
                    sb.Append($@"<tr>
<td>{data.ExpiryDate}</td>
<td>{data.TransactionDate}</td>
<td>{data.TransactionNumber}</td>
<td>{data.TransactionType}</td>
<td>{data.Description}</td>
<td>{data.Day}</td>
<td>{data.Amount}</td>
<td>{data.Balance}</td>
</tr>");
                }
                sb.Append(@"</table>
<br />
<br />");
                sb.Append(@"
<p>Banka Havalesi ile ödemeleriniz için hesap numaralarımız ise aşağıdaki gibidir.</p>
<table class='table mt-3'>
<tr>
<th>BANKA</th>
<th>IBAN</th>
<th>PARA BİRİMİ</th>
<th>HESAP NO</th>
<th>ŞUBE KODU</th>
<th>ŞUBE ADI</th>
</tr>");
                foreach (var bank in datas.Bankas)
                {
                    sb.Append($@"<tr>
<td>{bank.Bank}</td>
<td>{bank.Ibn}</td>
<td>{bank.ParaBirimi}</td>
<td>{bank.HesapNo}</td>
<td>{bank.SubeKodu}</td>
<td>{bank.SubeAdi}</td>
</tr>
");
                }
                sb.Append(@"</table>
<br />
<br />
<p>
    İşbirliğiniz için teşekkür eder, iyi çalışmalar dileriz.
    <br />
    <a href='www.google.com'>  MERCEK BİLİŞİM</a>
</p>
</body>
</html>");
                return sb;
            }
        }
    }
