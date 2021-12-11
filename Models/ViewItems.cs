using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5OctBatch_2021.Models
{
    public class ViewItems
    {
        // items properties
        public int Id { get; set; }
        public int ItemCategory { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int ItemSerial { get; set; }
        public double ItemPrice { get; set; }
        public double ItemQuantity { get; set; }
        public double ItemMinStock { get; set; }
        public double ItemMaxStock { get; set; }
        public double ItemOpeningStock { get; set; }
        public DateTime OpeningStockDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string CatName { get; set; }
        public string CatCode { get; set; }
    }
}
