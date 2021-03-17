using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class Engine : ITransportable
    {
        private double weight { get; set; }
        private double volume { get; set; }
        public double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 12.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 22.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }

        private FuelTank Tank;
        private Waste Waste;

        public Engine(FuelTank tank, Waste waste)
        {
            this.Tank = tank;
            this.Waste = waste;

        }

        public double GetVelocity(double submarineWeight)
        {
            return 100 / submarineWeight;

        }

        public bool CheckFuelBeforeTravel(double travelTime)
        {
            if (travelTime == Tank.Volume)
                return true;
            else return false;
        }
        public void Travel(double travelTime)
        {
            Waste.VisitPort();
            for (double i = 0; i < travelTime; i += 3)
            {
                Tank.Volume -= 2;
                Waste.Weight += 1;
            }
        }



    }
}
