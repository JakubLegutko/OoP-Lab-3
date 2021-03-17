using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class OxygenBottle : IVisitPort
    {
        private double weight { get; set; }
        private double volume { get; set; }
        public double MaxCapacity { get; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 33.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 32.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public OxygenBottle(double capacity)
        {
            this.MaxCapacity = capacity;
        }
        public double VisitPort()
        {
            Volume = MaxCapacity;
            return 250.0;
        }
    }
}
