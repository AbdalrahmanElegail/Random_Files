using try_ef_scafold.Data;
using System.Linq;

namespace try_ef_scafold
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new AppDbContext();

            var customers = from c in _context.Customers
                            join o in _context.Orders
                            on c.CustomerId equals o.CustomerId 
                            select new {CName = c.FirstName, ODate =o.OrderDate };


            foreach (var customer in customers)
            {
                Console.WriteLine($"C: {customer.CName} ------ O: {customer.ODate}");
            }   









            _context.SaveChanges();

            Console.ReadLine();
        }
    }
}
