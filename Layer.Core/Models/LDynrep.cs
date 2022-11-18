using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LDynrep
    {
        public int Logicalref { get; set; }
        public int? Repid { get; set; }
        public short? Moduleid { get; set; }
        public short? Reportgrpid { get; set; }
        public short? Active { get; set; }
        public short? Reportowner { get; set; }
        public short? Reporttype { get; set; }
        public short? Gettfromfilter { get; set; }
        public short? Prnttallpages { get; set; }
        public short? Getshwdetfilter { get; set; }
        public int? Enginever { get; set; }
        public string Reportver { get; set; }
        public short? Dontprntmstrdetnotex { get; set; }
        public string Name { get; set; }
        public int? NameLnglistid { get; set; }
        public string Title { get; set; }
        public int? TitleLnglistid { get; set; }
        public short? Dbtype { get; set; }
        public short? Usercansortgrp { get; set; }
        public string Flnamefornav { get; set; }
        public byte[] Ldata { get; set; }
    }
}
