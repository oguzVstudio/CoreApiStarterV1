using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace sTest.MetaData.Core.Models
{
    [Table("SellerTable", Schema = "app_metadata")]
    public class SellerTable
    {
        [Key]
        public int Id { get; set; }
        public string SellerName { get; set; }        
    }
}
