using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Dtos
{
    public class BankaDto
    {
        public int Id { get; set; }
        public string Bank { get; set; }
        public string Ibn { get; set; }
        public string ParaBirimi { get; set; }
        public int HesapNo { get; set; }
        public string SubeKodu { get; set; }
        public string SubeAdi { get; set; }
    }
}
