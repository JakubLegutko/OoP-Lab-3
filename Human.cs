using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    abstract class  Human : ITransportable
    {
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 7.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        protected double volume;
        protected double weight;
    }
}
