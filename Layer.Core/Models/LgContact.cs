using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgContact
    {
        public int Logicalref { get; set; }
        public string Name { get; set; }
        public string Midinit { get; set; }
        public string Famname { get; set; }
        public string Title { get; set; }
        public int? Cstvndref { get; set; }
        public string Jobtitle { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Workphone { get; set; }
        public string Homephone { get; set; }
        public string Mobphone { get; set; }
        public string Asstphone { get; set; }
        public string Officefax { get; set; }
        public string Emailaddr { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public int? Contcat { get; set; }
        public int? Siteid { get; set; }
        public int? Orglogicref { get; set; }
        public short? CapiblockCreatedby { get; set; }
        public DateTime? CapiblockCreadeddate { get; set; }
        public short? CapiblockCreatedhour { get; set; }
        public short? CapiblockCreatedmin { get; set; }
        public short? CapiblockCreatedsec { get; set; }
        public short? CapiblockModifiedby { get; set; }
        public DateTime? CapiblockModifieddate { get; set; }
        public short? CapiblockModifiedhour { get; set; }
        public short? CapiblockModifiedmin { get; set; }
        public short? CapiblockModifiedsec { get; set; }
        public short? Textinc { get; set; }
        public string Countrycode { get; set; }
        public string Citycode { get; set; }
        public string Towncode { get; set; }
        public string Town { get; set; }
        public string Districtcode { get; set; }
        public string District { get; set; }
        public short? Recstatus { get; set; }
        public string Workphcod { get; set; }
        public string Homephcod { get; set; }
        public string Mobphcod { get; set; }
        public string Asstphcod { get; set; }
        public string Offfaxcod { get; set; }
        public string Guid { get; set; }
    }
}
