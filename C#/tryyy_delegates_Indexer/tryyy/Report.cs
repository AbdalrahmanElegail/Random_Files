using System;
using System.Linq;

namespace tryyy
{

    internal static class Report
    {
        //public delegate bool IllegibleSales(People p);
        public static void View(People people, string title, Predicate<People> isIllegible /* ||  Func<People,bool> isIllegible  ||  IllegibleSales isIllegible  */)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var p in from p in people.OfType<People>()
                              where isIllegible(p)
                              select p)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\n\n");
        }
    }
}
