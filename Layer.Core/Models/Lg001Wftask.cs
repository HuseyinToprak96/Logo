using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Wftask
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public int? Wfcardref { get; set; }
        public int? Wflineref { get; set; }
        public short? Level { get; set; }
        public string Taskdef { get; set; }
        public DateTime? Begdate { get; set; }
        public int? Begtime { get; set; }
        public DateTime? Enddate { get; set; }
        public int? Endtime { get; set; }
        public short? Status { get; set; }
        public short? Completedper { get; set; }
        public short? Usernr { get; set; }
        public int? Wfroleref { get; set; }
        public short? Tasktype { get; set; }
        public short? Processtype { get; set; }
        public int? Pertaskref { get; set; }
        public int? Remindcount { get; set; }
        public short? Reminder { get; set; }
        public DateTime? Reminddate { get; set; }
        public int? Remindtime { get; set; }
        public short? Remindday { get; set; }
        public short? Remindminute { get; set; }
        public string Definition { get; set; }
        public int? Workplacetype { get; set; }
        public int? Recordref { get; set; }
        public short? Recordperiod { get; set; }
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
        public int? Parenttaskref { get; set; }
        public short? Recordcurop { get; set; }
        public short? Approvestat { get; set; }
        public short? Warned { get; set; }
        public short? Taskgrpnr { get; set; }
        public DateTime? Actenddate { get; set; }
        public int? Actendtime { get; set; }
        public short? Delaystatus { get; set; }
        public short? Sendwarn { get; set; }
        public short? Warntype { get; set; }
        public short? Warnusernr { get; set; }
        public int? Warnroleref { get; set; }
        public short? Warnsended { get; set; }
        public string Beginmailgroup { get; set; }
        public string Endmailgroup { get; set; }
        public short? Beginalert { get; set; }
        public short? Endalert { get; set; }
        public short? Repeattype { get; set; }
        public int? Repdate { get; set; }
        public int? Reptime { get; set; }
        public short? Repmonth { get; set; }
        public short? Repday36 { get; set; }
        public short? Repday7 { get; set; }
        public short? Repday6 { get; set; }
        public short? Repyearspin { get; set; }
        public short? Repmonthspin { get; set; }
        public short? Repdayspin { get; set; }
        public short? Rephourspin { get; set; }
        public short? Repminspin { get; set; }
        public int? Beginrepeatingtime { get; set; }
        public int? Beginrepeatingdate { get; set; }
        public short? Endrepeatingtype { get; set; }
        public int? Endrepeatingdate { get; set; }
        public int? Endrepeatingtime { get; set; }
        public short? Endrepeatingcount { get; set; }
        public short? Priority { get; set; }
        public int? Taskparams { get; set; }
        public short? Waittime { get; set; }
        public short? Cardtype { get; set; }
        public string Bmailto { get; set; }
        public string Bmailcc { get; set; }
        public string Bmailbcc { get; set; }
        public string Bmailuser { get; set; }
        public string Bmailrole { get; set; }
        public string Emailto { get; set; }
        public string Emailcc { get; set; }
        public string Emailbcc { get; set; }
        public string Emailrole { get; set; }
        public string Emailuser { get; set; }
        public short? Mailtype { get; set; }
        public short? Issms { get; set; }
        public short? Sendmailreport { get; set; }
        public string Guid { get; set; }
        public short? Usesms { get; set; }
        public short? Active { get; set; }
        public double? Begtotal { get; set; }
        public double? Endtotal { get; set; }
        public int? Payments { get; set; }
        public int? Arrivals { get; set; }
        public int? Collections { get; set; }
        public int? Procurements { get; set; }
    }
}
