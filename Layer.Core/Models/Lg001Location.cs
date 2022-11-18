using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Location
    {
        public int Logicalref { get; set; }
        public short? Invennr { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public int? Widthref { get; set; }
        public int? Lengthref { get; set; }
        public int? Heightref { get; set; }
        public double? Minlevel { get; set; }
        public double? Maxlevel { get; set; }
        public short? Shelftype { get; set; }
        public short? Contenttype { get; set; }
        public short? Priority { get; set; }
        public int? Usetref { get; set; }
        public int? Uomref { get; set; }
        public short? Iseuropalette { get; set; }
        public short? Siteid { get; set; }
        public short? Recstatus { get; set; }
        public int? Orglogicref { get; set; }
        public int? Wfstatus { get; set; }
    }
}
