using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("SalesTable", Schema = "app_metadata")]
    public class SalesTable
    {
        [Key]
        public int Id { get; set; }
        public int OrderId { get; set; }
        [ForeignKey(nameof(OrderId))] public OrderTable Order { get; set; }
        public DateTime SalesDate { get; set; }
        public int SellerId { get; set; }
        [ForeignKey(nameof(SellerId))] public SellerTable Seller { get; set; }
    }
}
