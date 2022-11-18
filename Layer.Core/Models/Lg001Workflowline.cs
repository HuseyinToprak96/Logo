using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Workflowline
    {
        public int Logicalref { get; set; }
        public int? Wfcardref { get; set; }
        public short? Linenr { get; set; }
        public short? Level { get; set; }
        public short? Usernr { get; set; }
        public int? Roleref { get; set; }
        public short? Inform { get; set; }
        public double? Tasktimeamnt { get; set; }
        public short? Tasktimeunit { get; set; }
        public short? Delaystatus { get; set; }
        public short? Sendwarn { get; set; }
        public short? Warntype { get; set; }
        public short? Warnusernr { get; set; }
        public int? Warnroleref { get; set; }
        public string Condition { get; set; }
        public short? Tasktype { get; set; }
        public string Taskdef { get; set; }
        public short? Processtype { get; set; }
        public short? Reminder { get; set; }
        public string Bmailto { get; set; }
        public string Bmailcc { get; set; }
        public string Bmailbcc { get; set; }
        public short? Importance { get; set; }
        public short? Notification { get; set; }
        public short? Email { get; set; }
        public short? Sms { get; set; }
        public int? Msgtempref { get; set; }
    }
}
