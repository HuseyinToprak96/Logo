using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Distroutline
    {
        public int Logicalref { get; set; }
        public int? Distroutref { get; set; }
        public short? Linenr { get; set; }
        public int? Salesmanref { get; set; }
        public string Bcountrycode { get; set; }
        public string Bcitycode { get; set; }
        public string Btowncode { get; set; }
        public string Bdistrictcode { get; set; }
        public string Ecountrycode { get; set; }
        public string Ecitycode { get; set; }
        public string Etowncode { get; set; }
        public string Edistrictcode { get; set; }
    }
}
