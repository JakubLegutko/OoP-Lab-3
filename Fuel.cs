using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    abstract class Fuel : ITransportable
    {
        public double Weight { get; set; }
        public double Volume { get; set; }
        public string Type { get; set; }
        protected double density;
    }
}
