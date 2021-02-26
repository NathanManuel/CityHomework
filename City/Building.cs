using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Building
    {
        private string adress;
        public Street s;

        public Building(string adress)
        {
            this.adress = adress;
        }

        override
      public string ToString()
        {
            return "The house adress is " + this.adress;
        }
    }
}
