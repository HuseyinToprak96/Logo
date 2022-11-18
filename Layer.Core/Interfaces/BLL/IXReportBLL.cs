using Layer.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.BLL
{
    public interface IXReportBLL
    {
        bool SendMail(XReportDatas report, MailDto mailDto);
    }
}
