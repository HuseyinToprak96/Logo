using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LgSatifilter
    {
        public int Logicalref { get; set; }
        public short? Datatype { get; set; }
        public int? Ownerid { get; set; }
        public int? Instance { get; set; }
        public short? Defaultflg { get; set; }
        public string Tempname { get; set; }
        public string Explanation { get; set; }
        public int? Datasize { get; set; }
        public short? UpdateinfoCreatedby { get; set; }
        public int? UpdateinfoCreateddate { get; set; }
        public short? UpdateinfoCreatedhour { get; set; }
        public short? UpdateinfoCreatedmin { get; set; }
        public short? UpdateinfoCreatedsec { get; set; }
        public short? UpdateinfoModifiedby { get; set; }
        public int? UpdateinfoModifieddate { get; set; }
        public short? UpdateinfoModifiedhour { get; set; }
        public short? UpdateinfoModifiedmin { get; set; }
        public short? UpdateinfoModifiedsec { get; set; }
        public short? Userdefault { get; set; }
        public int? Usernr { get; set; }
        public string Authcode { get; set; }
        public short? Webdefflg { get; set; }
        public byte[] Ldata { get; set; }
    }
}
