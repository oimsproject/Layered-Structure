using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OIM_Exception
{
    public class Invoice_Exceptions : ApplicationException
    {
        public Invoice_Exceptions()
        {

        }
        public Invoice_Exceptions(string message)
            : base(message)
        {

        }
    }
}
