using System;
using System.Collections.Generic;

#nullable disable

namespace DotNet5OctBatch_2021.Models
{
    public partial class Sale
    {
        public int Id { get; set; }
        public int Serial { get; set; }
        public string Code { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public DateTime? SaleDate { get; set; }

        public decimal Qty { get; set; }

        public decimal Price { get; set; }
    }
}
