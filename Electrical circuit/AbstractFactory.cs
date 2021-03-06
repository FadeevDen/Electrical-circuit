﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electrical_circuit
{
    public class AbstractFactory
    {
        public abstract class Element
        {
            public MarginForElement Margin { get; set; }
            public TypeOfElement Type { get; set; }
        }        
        
        public class Wire : Element
        {

        }

        public class Resistance : Element
        {

        }

        public class CurrentSource : Element
        {

        }

        public class CornerWire : Element
        {
             
        }
       
        public abstract class ElectricalFactory
        {
            public abstract Element CreateNewElement();
            public void MethodForAllElements() { }
        }

        public class WireFactory : ElectricalFactory
        {
            public override Element CreateNewElement()
            {
                return new Wire();
            }
        }

        public class ResistanceFactory : ElectricalFactory
        {
            public override Element CreateNewElement()
            {
                return new Resistance();
            }
        }

        public class CurrentSourceFactory : ElectricalFactory
        {
            public override Element CreateNewElement()
            {
                return new CurrentSource();
            }
        }

        public class CornerWireFactory : ElectricalFactory
        {
            public override Element CreateNewElement()
            {
                return new CornerWire();
            }
        }
    }
}
