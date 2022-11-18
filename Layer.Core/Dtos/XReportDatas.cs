using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Dtos
{
    public class XReportDatas
    {
        public string FirmName { get; set; }
        public DateTime FirstDate { get; set; }
        public DateTime EndDate { get; set; }
        public double ExpiryTotalBalance { get; set; }
        public double NotExpiryTotalBalance { get; set; }
        public List<XReportTableDatas> ExpiryDatas { get; set; } = new();
        public List<XReportTableDatas> NotExpiryDatas { get; set; } = new();
        public List<BankaDto> Bankas { get; set; } = new();
        public string CariHesapMail { get; set; }
        public string BA_BS_Mail { get; set; }
        public string Data1 { get; set; }
        public string Data2 { get; set; }
        public string Data3 { get; set; }
        public string Data4 { get; set; }
        public string Data5 { get; set; }
        public string Data6 { get; set; }
        public string Data7 { get; set; }
        public string Data8 { get; set; }
        public string Data9 { get; set; }
        public string Data10 { get; set; }
    }
}
