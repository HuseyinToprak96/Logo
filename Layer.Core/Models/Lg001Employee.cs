using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Employee
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short? Factorydivnr { get; set; }
        public short? Factorynr { get; set; }
        public int? Calendarref { get; set; }
        public string Specode { get; set; }
        public string Cyphcode { get; set; }
        public int? Perscardref { get; set; }
        public short? Approved { get; set; }
        public double? Operationtime { get; set; }
        public double? Hourlystdcost { get; set; }
        public double? Hourlystdrpcost { get; set; }
        public int? Accountref { get; set; }
        public int? Centerref { get; set; }
        public short? Active { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
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
        public short? Imageinc { get; set; }
        public int? Wfstatus { get; set; }
        public int? Shftgrpref { get; set; }
        public string Empname { get; set; }
        public string Empsurname { get; set; }
        public string Tckno { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Bloodgrp { get; set; }
        public string Registercode { get; set; }
        public string Socialsecno { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string District { get; set; }
        public string Districtcode { get; set; }
        public string Town { get; set; }
        public string Towncode { get; set; }
        public string City { get; set; }
        public string Citycode { get; set; }
        public string Country { get; set; }
        public string Countrycode { get; set; }
        public string Telnrs1 { get; set; }
        public string Telnrs2 { get; set; }
        public string Emailaddr { get; set; }
        public string Guid { get; set; }
    }
}
