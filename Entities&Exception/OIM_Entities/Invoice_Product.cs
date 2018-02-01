using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIM_Entities
{
    public class Invoice_Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string UnitType { get; set; }
        public int Price { get; set; }
        public int CategoryId { get; set; }
    }
}
