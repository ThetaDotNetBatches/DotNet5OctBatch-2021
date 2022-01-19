using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DotNet5OctBatch_2021.Models
{
    public partial class Item
    {
        public int Id { get; set; }
        public int? ItemCategory { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int? ItemSerial { get; set; }
        public double? ItemPrice { get; set; }
        public double? ItemQuantity { get; set; }
        public double? ItemMinStock { get; set; }
        public double? ItemMaxStock { get; set; }
        public double? ItemOpeningStock { get; set; }
        public DateTime? OpeningStockDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
       [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Image { get; set; }
    }
}
