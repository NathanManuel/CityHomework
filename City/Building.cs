using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Building
    {
        private string buildingType;
        private Street s;
        public Building(string buildingType, Street s)
        {
            this.buildingType = buildingType;
            this.s = s;
        }

        

        override
      public string ToString()
        {
            return "The building is a " + this.buildingType + " and the street name is "+ this.s.getStreet(); 
        }
    }
}
