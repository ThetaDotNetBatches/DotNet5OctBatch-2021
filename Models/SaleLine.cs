using System;
using System.Collections.Generic;

#nullable disable

namespace DotNet5OctBatch_2021.Models
{
    public partial class SaleLine
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int SaleId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public decimal Price { get; set; }

        public decimal Qty { get; set; }
    }
}
