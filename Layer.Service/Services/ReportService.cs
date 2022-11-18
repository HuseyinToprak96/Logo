using AutoMapper;
using Layer.Core.Dtos;
using Layer.Core.Interfaces.Repository;
using Layer.Core.Interfaces.Service;
using Layer.Core.Interfaces.UnitOfWork;
using Layer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Service.Services
{
    public class ReportService : Service<Report>, IReportService
    {
        private readonly IReportRepository _reportRepository;

        public ReportService(IMapper mapper, IGenericRepository<Report> genericRepository, IUnitOfWork unitOfWork, IReportRepository reportRepository) : base(mapper, genericRepository, unitOfWork)
        {
            _reportRepository = reportRepository;
        }

        public async Task<XReportDatas> GetReport(DateTime firstDate, DateTime endDate)
        {
            return await _reportRepository.GetReport(firstDate,endDate);
        }
        public async Task<IEnumerable<Report>> GetAllReports()
        {
            return await _reportRepository.GetAllReports();
        }

        public async Task<IEnumerable<Lg00101Clfline>> Deneme()
        {
            return await _reportRepository.Deneme();
        }

        public XReportDatas GetReport2(DateTime? StartDate, DateTime EndDate, int language)
        {
            return _reportRepository.GetReport2(StartDate,EndDate,language);
        }

        public async Task<IEnumerable<Report>> Reports()
        {
            return await _reportRepository.Reports();
        }

        public async Task<XReportDatas> GetExpiryReportDatas(DateTime firstDate, DateTime endDate)
        {
            return await _reportRepository.GetExpiryReportDatas(firstDate, endDate);
        }
    }
}
