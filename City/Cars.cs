using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    public class Cars
    {
        private string carName = null;
        private int carNumber;
       



        public Cars(string carName, int carNumber)
        {
            this.carName = carName;
            this.carNumber = carNumber;
        }

        override
    public string ToString()
        {
            string text;
            text = "The cars name is " + this.carName + " and has the number plate " + this.carNumber;
            return text;
        }


    }
}
