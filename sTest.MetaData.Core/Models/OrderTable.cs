using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("OrderTable", Schema = "app_metadata")]
    public class OrderTable
    {
        [Key]
        public int Id { get; set; }
        public string OrderName { get; set; }
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
