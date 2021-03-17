using System;
using System.Collections.Generic;
using System.Text;

namespace OoP_Lab_3
{
    class LifeSupportSystem
    {
        private List<OxygenBottle> oxygenBottles;
        private List<Human> crew;
        private FoodContainer FoodContainer;
        private Waste waste;

        public LifeSupportSystem(List<OxygenBottle> bottles, FoodContainer container, Waste waste, List<Human> crew)
        {
            this.oxygenBottles = bottles;
            this.FoodContainer = container;
            this.waste = waste;
            this.crew = crew;
        }

        public bool CheckSuppliesBeforeTravel(double travelTime)
        {
            if (oxygenBottles.Count < crew.Count) return false;
            else if (FoodContainer.Volume < (crew.Count / 3)) return false;
            else if (waste.Volume > 10) return false;
            else if (travelTime > 1000) return false;
            else if (oxygenBottles.Count < 1) return false;
            else if (FoodContainer.Volume < 1) return false;
            else return true;
        }
        public void Run(double travelTime)
        {
          for(double i= 0; i<travelTime; i+=4)
            {
                waste.Volume += 1;
                FoodContainer.Volume -= 2;
                oxygenBottles.RemoveAt(oxygenBottles.Count);
            }

        }
    }
}
