using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neispravna_racunska_operacija
{
     public class Exception_neispravna_racunska_operacija : Exception
        {
            public Exception_neispravna_racunska_operacija()
            {
            }

            public Exception_neispravna_racunska_operacija(string message) : base(message)
            {
            Console.WriteLine("Nije unešen ispravan znak računske operacije");
            }

            public Exception_neispravna_racunska_operacija(string message, Exception inner) : base(message, inner)
            {

            }
        }
    
}
