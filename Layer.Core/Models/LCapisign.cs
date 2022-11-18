using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapisign
    {
        public int Logicalref { get; set; }
        public string Sign { get; set; }
        public int? Vers { get; set; }
        public short? Key1 { get; set; }
        public short? Key2 { get; set; }
        public short? Key3 { get; set; }
        public short? Key4 { get; set; }
        public string Webacc { get; set; }
        public string Webserver { get; set; }
        public short? Mtype { get; set; }
        public string Otherprgpath { get; set; }
        public short? Eslibrary { get; set; }
        public short? Notusehint { get; set; }
        public short? Usesitebterm { get; set; }
        public string Lconnuser { get; set; }
        public string Lconnuserpass { get; set; }
        public string Weblink { get; set; }
        public string Emailserveraddr { get; set; }
        public string Emailaddr { get; set; }
        public string Emailusername { get; set; }
        public string Emailpass { get; set; }
        public int? Emailserverport { get; set; }
        public short? Usetls { get; set; }
        public short? Ssltype { get; set; }
        public string Ldbbackupuser { get; set; }
        public string Ldbbackupuserpass { get; set; }
        public string Ldbbackupdomain { get; set; }
        public string Ldbbackupdomainip { get; set; }
        public string Ldbbackupdatasetid { get; set; }
        public string Ldbbackupdatasetname { get; set; }
        public short? Ldbbackupexecavreg { get; set; }
        public string Ldbbackupwebsrvurl { get; set; }
        public string Ldbbackupreportlink { get; set; }
        public short? Tigerhr { get; set; }
        public short? Maxdopnr { get; set; }
        public DateTime? Liccheckdate { get; set; }
        public short? Tigerhrabsence { get; set; }
        public int? Ebookvers { get; set; }
        public int? Ebeyannamevers { get; set; }
    }
}
