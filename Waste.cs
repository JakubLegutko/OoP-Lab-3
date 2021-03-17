using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class Waste : IVisitPort
    {

        private double weight { get; set; }
        private double volume { get; set; }

        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 8.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 3.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double VisitPort()
        {
     
        Volume = 0.0;
            return 300.0;
        }
    }
}
