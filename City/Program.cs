using System;

namespace City
{
    public class Cars
    {
        private string carName = null;
        private int carNumber;
        private string v1;
        private int v2;

      

        public Cars(string carName, int carNumber)
        {
            this.carName = carName;
            this.carNumber = carNumber;
        }

        override
    public string ToString()
        {
            string text;
            text ="The cars name is " + this.carName + " and has the number plate " + this.carNumber;
            return text;
        }

        
    }

    public class Street
    {
        private string streetName;
        public Street(string streetName)
        {
            this.streetName = streetName;
        }

        override
        public string ToString()
        {
            return "The street name is: " + this.streetName;
        }
    }    
   
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
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars("BWM", 123);
            Console.WriteLine(c);

            Street s1 = new Street("Bulevart");
            Console.WriteLine(s1);

        }
    }
}
