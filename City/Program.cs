using System;

namespace City
{    
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars("BWM", "BH 123");
            Console.WriteLine(c);

            Street s1 = new Street("Avram Iancu");
            Console.WriteLine(s1);

            Park p1 = new Park("1 Decembrie");
            Console.WriteLine(p1);

            Building b1 = new Building("Villa", s1);
            Console.WriteLine(b1);

            School sch1 = new School("Emanuel", 200, s1);
            Console.WriteLine(sch1);
        }
    }
}
