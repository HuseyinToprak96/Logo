using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Unitsetl
    {
        public int Logicalref { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Unitsetref { get; set; }
        public short? Linenr { get; set; }
        public short? Mainunit { get; set; }
        public double? Convfact1 { get; set; }
        public double? Convfact2 { get; set; }
        public double? Width { get; set; }
        public double? Length { get; set; }
        public double? Height { get; set; }
        public double? Area { get; set; }
        public double? Volume { get; set; }
        public double? Weight { get; set; }
        public int? Widthref { get; set; }
        public int? Lengthref { get; set; }
        public int? Heightref { get; set; }
        public int? Arearef { get; set; }
        public int? Volumeref { get; set; }
        public int? Weightref { get; set; }
        public short? Divunit { get; set; }
        public string Measurecode { get; set; }
        public string Globalcode { get; set; }
    }
}
