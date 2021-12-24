using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet5OctBatch_2021.Models
{
    public class ViewSales
    {
        // items properties
        public Sale objSale { get; set; }
        public IList<SaleLine> ListSaleLine { get; set; }
    }
}
