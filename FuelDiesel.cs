using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class FuelDiesel : Fuel
    {
        protected double weight;
        protected double volume;
        public FuelDiesel()
        {
            this.density = 3.0;
            this.Type = "Diesel";
        }


        public new double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 2.0 * density;
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = (value / 12.0) * density;
            }
        }
    }
}
