using Dapper;
using Layer.Core.Dtos;
using Layer.Core.Interfaces.Repository;
using Layer.Core.Models;
using Layer.Repository.DbAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Repository.Repositories
{
    public class ReportRepository : GenericRepository<Report>, IReportRepository
    {
        private readonly ISqlDataAccess _sqlSp;
        public ReportRepository(TİGER3Context db, ISqlDataAccess sqlSp) : base(db)
        {
            _sqlSp = sqlSp;
        }
        public async Task<XReportDatas> GetReport(DateTime firstDate, DateTime endDate)
        {
            //int id =1;
            var expiryDatas = await _sqlSp.LoadData<XReportTableDatas, dynamic>(storedProcedure: "dbo.spReport_ExpiryGetData", new { });
            var notExpiryDatas = await _sqlSp.LoadData<XReportTableDatas, dynamic>(storedProcedure: "dbo.spReport_NotExpiryGetData", new { });
            XReportDatas xReport = new XReportDatas { ExpiryDatas=expiryDatas.ToList(),NotExpiryDatas = notExpiryDatas.ToList() };
            //var report = (from t1 in _db.LCapifirms
            //              join t2 in _db.LCapigroups
            //              on t1.Firmtype equals t2.Superflg
            //              select new Report1Datas
            //              {
            //                  Data1 = t1.Accofficecode,
            //              }).SingleOrDefault();

            return new XReportDatas { Data1 = "Veri1", Data2 = "Veri2", Data3 = "Veri3", Data4 = "Veri4", Data5 = "Veri5", Data6 = "Veri6", Data7 = "Veri7", Data8 = "Veri8", Data9 = "Veri9", Data10 = "Veri10" };
        }
        public async Task<IEnumerable<Report>> GetAllReports()
        {
            //saklı prosedürler değişecek
            var expiryBalance = _sqlSp.LoadData<double, dynamic>(storedProcedure: "Sp_expiryBalance", new { });
            var expiryDatas = await _sqlSp.LoadData<XReportTableDatas, dynamic>(storedProcedure: "dbo.spReport_ExpiryGetData", new { });
            var notExpiryBalance = _sqlSp.LoadData<double, dynamic>(storedProcedure: "Sp_notExpiryBalance", new { });
            var notExpiryDatas = await _sqlSp.LoadData<XReportTableDatas, dynamic>(storedProcedure: "dbo.spReport_NotExpiryGetData", new { });
            XReportDatas xReport = new XReportDatas { ExpiryDatas = expiryDatas.ToList(), NotExpiryDatas = notExpiryDatas.ToList() };

            return await _db.Reports.ToListAsync();
        }

        public async Task<IEnumerable<Lg00101Clfline>> Deneme()
        {
            return await _sqlSp.QueryGetList<Lg00101Clfline>("select * from Dene");
        }

        public XReportDatas GetReport2(DateTime? StartDate, DateTime EndDate, int language)
        {
            XReportDatas x = new XReportDatas();
            x.FirmName = "Mercek Bilişim";
            x.ExpiryTotalBalance = 2000000;
            x.EndDate = DateTime.Now;
            x.FirstDate = DateTime.Now;
            x.CariHesapMail = "@mercekbilisim.com.tr";
            x.BA_BS_Mail = "@mercekbilisim.com.tr";
            x.NotExpiryTotalBalance = 500000;
            for (int i = 1; i <= 10; i++)
            {
                XReportTableDatas xReport = new XReportTableDatas { Amount=i, Balance=i, Day=10*1, Description="Açıklama", ExpiryDate=DateTime.Now, TransactionDate=DateTime.Now, TransactionNumber=$"000000{i}", TransactionType=$"İşlem {i}" };
                x.ExpiryDatas.Add(xReport);
            }
            for (int i = 1; i <= 15; i++)
            {
                XReportTableDatas xReport = new XReportTableDatas { Amount = i, Balance = i, Day = 10 * 1, Description = "Açıklama", ExpiryDate = DateTime.Now, TransactionDate = DateTime.Now, TransactionNumber = $"000000{i}", TransactionType = $"İşlem {i}" };
                x.NotExpiryDatas.Add(xReport);
            }
            for (int i = 1; i <= 5; i++)
            {
                BankaDto banka = new BankaDto { SubeAdi=$"Şube {i}", HesapNo=1000000+i, Ibn="10000000000"+i, ParaBirimi=$"Para {i}", SubeKodu="100"+i, Bank=$"Banka {i}" };
                x.Bankas.Add(banka);
            }
            return x;
        }

        public async Task<IEnumerable<Report>> Reports()
        {
            return await _sqlSp.QueryGetList<Report>("SELECT * FROM Reports");
        }

        public async Task<XReportDatas> GetExpiryReportDatas(DateTime firstDate, DateTime endDate)
        {
            var x = await _sqlSp.QueryGetList<XReportTableDatas>(@"SELECT 
C.DATE_ 'ExpiryDate',
C.CAPIBLOCK_CREADEDDATE 'TransactionDate',
C.TRANNO 'TransactionNumber',
                       (CASE C.MODULENR*100+C.TRCODE 
WHEN 431 THEN 'Purchase Invoice' 
WHEN 433 THEN 'Sales Return Invoice' 
WHEN 434 THEN 'Services Purchase Invoice' 
WHEN 436 THEN 'Purchase Return Invoice' 
WHEN 438 THEN 'Sales Invoice' 
WHEN 439 THEN 'Service Sales Invoice' 
WHEN 443 THEN 'Price Diff. Received Invoice' 
WHEN 444 THEN 'Sales Price Diff. Invoice' 
WHEN 456 THEN 'Producer Invoice' 
WHEN 501 THEN 'Cash Collection' 
WHEN 502 THEN 'Cash Payment' 
WHEN 503 THEN 'Debit Note' 
WHEN 504 THEN 'Credit Note' 
WHEN 505 THEN 'Remittance Slip' 
WHEN 514 THEN 'Opening Slip' 
WHEN 541 THEN 'Sales Due Date Diff. Invoice' 
WHEN 542 THEN 'Due Date Diff. Invoice (Received)' 
WHEN 545 THEN 'Tradesman Invoice(Issued)' 
WHEN 546 THEN 'Tradesman Invoice(Received)' 
WHEN 570 THEN 'Credit Card Slip' 
WHEN 571 THEN 'Credit Card Return Slip' 
WHEN 572 THEN 'Company Credit Card Slip' 
WHEN 573 THEN 'Company Credit Card Return Slip' 
WHEN 720 THEN 'Money Orders(Received)' 
WHEN 721 THEN 'Money Orders(Issued)' 
WHEN 724 THEN 'Conversion Letter(For Purchase)' 
WHEN 725 THEN 'Conversion Letter(For Sales)' 
WHEN 728 THEN 'Service Purchases Invoice(To Bank)' 
WHEN 729 THEN 'Service Sales Invoice(To Bank)' 
WHEN 730 THEN 'Producer Invoice(To Bank)' 
WHEN 661 THEN 'Checks Received' 
WHEN 662 THEN 'P.Notes Received' 
WHEN 663 THEN 'Checks Issued (To AR/AP)' 
WHEN 664 THEN 'P.Notes Issued (To AR/AP)' 
WHEN 1001 THEN 'Cash Collection(Safe)' 
WHEN 1002 THEN 'Cash Payment(Safe)' 
WHEN 6103 THEN 'Debit Note(Checks)' 
WHEN 6104 THEN 'Credit Note(Checks)' 
END) as TransactionType,'' as Description,
datediff(day, getdate(), C.Date_) 'Day',
(CASE  WHEN  C.SIGN = 0 AND C.TRCURR IN(0, 160)THEN C.TRNET ELSE '' END) 'Amount',
(CASE  WHEN c.SIGN = 1 AND c.TRCURR IN(0,160) THEN c.TRNET ELSE '' END) 'ALACAK',
(SELECT SUM(CASE WHEN SIGN = 0 AND TRCURR IN(0, 160) THEN TRNET ELSE 0 END) - SUM(CASE WHEN SIGN = 1 AND TRCURR IN(0, 160) THEN TRNET ELSE 0 END)
FROM LG_001_01_CLFLINE BAKIYE WHERE BAKIYE.CLIENTREF = c.CLIENTREF AND BAKIYE.DATE_ <= c.DATE_
AND BAKIYE.LOGICALREF <= (CASE WHEN BAKIYE.DATE_ = c.DATE_ THEN c.LOGICALREF ELSE BAKIYE.LOGICALREF END) ) 'Balance'
 FROM LG_001_01_CLFLINE C LEFT JOIN LG_001_CLCARD CD ON CD.LOGICALREF = C.CLIENTREF
 WHERE C.CLIENTREF = 2
 GROUP BY  c.TRNET,c.SIGN,c.TRCURR,c.CLIENTREF,c.DATE_,c.LOGICALREF,c.DATE_,C.CAPIBLOCK_CREADEDDATE,C.TRANNO,C.TRCODE,c.MODULENR
 ORDER BY C.DATE_
");
            return new XReportDatas { ExpiryDatas = x.ToList() };
        }
    }
}
