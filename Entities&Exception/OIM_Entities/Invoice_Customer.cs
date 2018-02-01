using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIM_Entities
{
    public class Invoice_Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
    }
}
