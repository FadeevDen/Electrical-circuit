﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_circuit
{
    public class MarginForElement
    {
        public double Up { get; set; }
        public double Right { get; set; }
        public double Down { get; set; }
        public double Left { get; set; }

        public MarginForElement(double up, double right, double down, double left)
        {
            Up = up;
            Right = right;
            Down = down;
            Left = left;
        }
    
    }

   
}
