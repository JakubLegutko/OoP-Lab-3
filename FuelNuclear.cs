using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class FuelNuclear : Fuel
    {

        protected double weight;
        protected double volume;
        public FuelNuclear()
        {
            this.density = 300.0;
            this.Type = "Nuclear";
        }

        public new double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 8.0 *density; 
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = (value / 3.0) *density; 
            }
        }

    }
}
