using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Building
    {
        private string adress;
        private Street s;
        public Building(string adress, Street s)
        {
            this.adress = adress;
            this.s = s;
        }

        

        override
      public string ToString()
        {
            return "The house adress is " + this.adress + " and the street name is "+ this.s.getStreet(); 
        }
    }
}
