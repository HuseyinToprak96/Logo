using Layer.Core.Dtos;
using Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.Repository
{
    public interface IReportRepository:IGenericRepository<Report>
    {
        Task<XReportDatas> GetReport(DateTime firstDate,DateTime endDate);
        Task<XReportDatas> GetExpiryReportDatas(DateTime firstDate, DateTime endDate);
        XReportDatas GetReport2(DateTime? StartDate, DateTime EndDate, int language);
        Task<IEnumerable<Report>> GetAllReports();
        Task<IEnumerable<Lg00101Clfline>> Deneme();
        Task<IEnumerable<Report>> Reports();
    }
}
