using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class LCapidmconn
    {
        public int Logicalref { get; set; }
        public short? Nr { get; set; }
        public short? Conntype { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Rootdir { get; set; }
        public string Workspace { get; set; }
        public string Saverootdir { get; set; }
    }
}
