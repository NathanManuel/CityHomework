using System;

namespace City
{    
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars("BWM", 123);
            Console.WriteLine(c);

            Street s1 = new Street("Bulevart");
            Console.WriteLine(s1);

            Park p1 = new Park("1 Decembrie");
            Console.WriteLine(p1);

            Building b1 = new Building("Str. Food");
            Console.WriteLine(b1);

        }
    }
}
