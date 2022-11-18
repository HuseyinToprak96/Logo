using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Ucostcontrol
    {
        public int Logicalref { get; set; }
        public short? Controltype { get; set; }
        public short? Priority { get; set; }
        public string Methodname { get; set; }
        public string Categoryname { get; set; }
        public short? Successtype { get; set; }
        public short? Actiontype { get; set; }
        public short? Active { get; set; }
        public byte[] Ldata { get; set; }
    }
}
