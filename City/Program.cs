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
   
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars("BWM", 123);


            Console.WriteLine("Hello World!");
            Console.WriteLine(c);

        }
    }
}
