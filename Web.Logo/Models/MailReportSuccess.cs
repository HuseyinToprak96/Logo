using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Logo.Models
{
    public class MailReportSuccess
    {
        public DateTime? FirstDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Email { get; set; } = "";
        public int Language { get; set; }
    }
}
