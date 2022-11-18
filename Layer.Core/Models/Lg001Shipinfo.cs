using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Shipinfo
    {
        public int Logicalref { get; set; }
        public int? Clientref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Faxnr { get; set; }
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
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public string Tradinggrp { get; set; }
        public string Vatnr { get; set; }
        public string Taxnr { get; set; }
        public string Taxoffice { get; set; }
        public string Towncode { get; set; }
        public string Town { get; set; }
        public string Districtcode { get; set; }
        public string District { get; set; }
        public string Citycode { get; set; }
        public string Countrycode { get; set; }
        public short? Active { get; set; }
        public short? Textinc { get; set; }
        public string Emailaddr { get; set; }
        public string Inchange { get; set; }
        public string Telcodes1 { get; set; }
        public string Telcodes2 { get; set; }
        public string Faxcode { get; set; }
        public string Longitude { get; set; }
        public string Latitute { get; set; }
        public string Cityid { get; set; }
        public string Townid { get; set; }
        public int? Shipbegtime1 { get; set; }
        public int? Shipbegtime2 { get; set; }
        public int? Shipbegtime3 { get; set; }
        public int? Shipendtime1 { get; set; }
        public int? Shipendtime2 { get; set; }
        public int? Shipendtime3 { get; set; }
        public string Postlabelcode { get; set; }
        public string Senderlabelcode { get; set; }
        public string Title { get; set; }
        public short? Defaultflg { get; set; }
        public string Postcodeledesp { get; set; }
        public string Sendercodeledesp { get; set; }
        public short? Isperscomp { get; set; }
        public string Tckno { get; set; }
        public string Sname { get; set; }
        public string Ssurname { get; set; }
    }
}
