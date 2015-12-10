using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_circuit
{
    public class EndsOfWire
    {
        public Boolean First { get;  set; }
        public Boolean Second { get;  set; }
        public Boolean Checking { get; set; }
       
        public void Check()
        {
            if (First && Second == true)
            {
                Checking = true;
            }

            else
            {
                Checking = false;
            }
        }



    }
}
