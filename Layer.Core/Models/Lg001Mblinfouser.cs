using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Mblinfouser
    {
        public int Logicalref { get; set; }
        public short? Usertype { get; set; }
        public int? Cardref { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phonenumber { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Mbltype { get; set; }
        public string Tckno { get; set; }
    }
}
