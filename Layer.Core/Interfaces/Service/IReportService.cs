using Layer.Core.Dtos;
using Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.Service
{
    public interface IReportService:IService<Report>
    {
        Task<XReportDatas> GetReport(DateTime firstDate, DateTime endDate);
        Task<IEnumerable<Report>> GetAllReports();
        Task<IEnumerable<Lg00101Clfline>> Deneme();
        Task<IEnumerable<Report>> Reports();
        XReportDatas GetReport2(DateTime? StartDate,DateTime EndDate,int language);
        Task<XReportDatas> GetExpiryReportDatas(DateTime firstDate, DateTime endDate);
    }
}
