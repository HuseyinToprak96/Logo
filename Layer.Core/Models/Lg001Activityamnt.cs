using System;
using System.Collections.Generic;

#nullable disable

namespace Layer.Core.Models
{
    public partial class Lg001Activityamnt
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public int? Ovhdtrref { get; set; }
        public DateTime? Date { get; set; }
        public double? Amount { get; set; }
    }
}
