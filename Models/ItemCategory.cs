using System;
using System.Collections.Generic;

#nullable disable

namespace DotNet5OctBatch_2021.Models
{
    public partial class ItemCategory
    {
        public int Id { get; set; }
        public string CatName { get; set; }
        public string CatCode { get; set; }
        public int? CatSerial { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? CatLevel { get; set; }
    }
}
