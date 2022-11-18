using Layer.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Interfaces.Service
{
    public interface IMailService
    {
        bool MailSender(MailDto mailDto);
    }
}
