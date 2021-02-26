using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Park
    {
        private string parkName;
        public Park(string parkName)
        {
            this.parkName = parkName;
        }

        override
       public string ToString()
        {
            return "The park is called: " + this.parkName;
        }

    }
}
