using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Street
    {
        private string streetName;
        public Street(string streetName)
        {
            this.streetName = streetName;
        }

       public string getStreet()
        {
            return this.streetName;
        }
        override
        public string ToString()
        {
            return "The street name is: " + this.streetName;
        }
    }
}
