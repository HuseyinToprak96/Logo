using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgCstvnd
    {
        public int Logicalref { get; set; }
        public short? Active { get; set; }
        public short? Cardtype { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Origin { get; set; }
        public string Postcode { get; set; }
        public string Telnr1 { get; set; }
        public string Telnr2 { get; set; }
        public string Faxnr { get; set; }
        public short? Clanguage { get; set; }
        public short? Ccurrency { get; set; }
        public string Weburl { get; set; }
        public int? Custcat { get; set; }
        public short? Grouporg { get; set; }
        public int? Parentorg { get; set; }
        public short? Textinc { get; set; }
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
        public int? Primarycontref { get; set; }
        public string Countrycode { get; set; }
        public string Citycode { get; set; }
        public string Towncode { get; set; }
        public string Town { get; set; }
        public string Districtcode { get; set; }
        public string District { get; set; }
        public short? Recstatus { get; set; }
        public string Rivalfirm { get; set; }
        public string Telcodes1 { get; set; }
        public string Telcodes2 { get; set; }
        public string Faxcode { get; set; }
        public string Guid { get; set; }
    }
}
