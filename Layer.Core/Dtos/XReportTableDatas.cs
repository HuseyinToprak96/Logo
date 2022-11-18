using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.Core.Dtos
{
    public class XReportTableDatas
    {
        public DateTime ExpiryDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionNumber { get; set; }
        public string TransactionType { get; set; }
        public string Description { get; set; }
        public int Day { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal Balance { get; set; }
    }
}
