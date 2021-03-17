using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class Scientist : Human
    {
        public new double Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                weight = value * 8.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        public new double Weight
        {
            get { return weight; }
            set
            {
                weight = value;
                volume = value / 3.0; // assume density equal to 7000 kg/m^3 (arbitrary number)
            }
        }
        private double WorkTime;
        private Equipment equipment;
        public Scientist(Equipment equipment)
        {
            this.equipment = equipment;
        }
        public void Work(double time)
        {
            for(double i = 0; i<time; i+=24)
               Console.WriteLine(equipment.GatherData());
                
            
        }
    }
}
