using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapiterminal
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public string Code { get; set; }
        public int? Tattrib { get; set; }
        public short? Usernr { get; set; }
        public short? Prnnr1 { get; set; }
        public short? Prnnr2 { get; set; }
        public string Prnfiles1 { get; set; }
        public string Prnfiles2 { get; set; }
        public string Prnfiles3 { get; set; }
        public string Prnfiles4 { get; set; }
        public string Prnfiles5 { get; set; }
        public string Name { get; set; }
        public int? Userext { get; set; }
        public short? Taskcode { get; set; }
        public string Gatewayaddr { get; set; }
        public string Key { get; set; }
        public short? Progid { get; set; }
        public int? Serial { get; set; }
        public string Licencestr { get; set; }
        public string Terminfo { get; set; }
        public short? Termtype { get; set; }
    }
}
