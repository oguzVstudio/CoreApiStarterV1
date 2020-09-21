using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("SellerTargetTable", Schema = "app_metadata")]
    public class SellerTargetTable
    {
        [Key]
        public int Id { get; set; }
        public int SellerId { get; set; }
        [ForeignKey(nameof(SellerId))] public SellerTable Seller { get; set; }
        public double Target { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
}
