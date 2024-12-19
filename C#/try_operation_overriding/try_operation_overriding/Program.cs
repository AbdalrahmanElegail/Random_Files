namespace try_operation_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt1 = DateTime.Now;
            Console.WriteLine($"The Date And Time Now is: {dt1}");

            DateOnly dt2 = new(2003, 2, 20);
            dt2 = dt2.AddDays(10);
            Console.WriteLine($"My birthdaty is: {dt2}");
            
            Console.WriteLine();

            Product m1 = new(15, "Apple");
            Product m2 = new(10, "Orange");

            Console.WriteLine($"m1 => {m1}");
            Console.WriteLine($"m2 => {m2}");
            Console.WriteLine();
            Console.WriteLine($"Price of m1 + m2: {+m1} + {+m2} = {m1 + m2}");
            Console.WriteLine($"Price of m1 - m2: {+m1} - {+m2} = {m1 - m2}");
            Console.WriteLine($"Price of m1 * m2: {+m1} * {+m2} = {m1 * m2}");
            Console.WriteLine($"Price of m1 / m2: {+m1} / {+m2} = {m1 / m2}");
            Console.WriteLine($"Price of m1 > m2: {+m1} > {+m2} = {m1 > m2}");
            Console.WriteLine($"Price of m1 < m2: {+m1} < {+m2} = {m1 < m2}");
            Console.WriteLine($"Price of m1 >= m2: {+m1} >= {+m2} = {m1 >= m2}");
            Console.WriteLine($"Price of m1 <= m2: {+m1} <= {+m2} = {m1 <= m2}");
            Console.WriteLine($"Price of m1 == m2: {+m1} == {+m2} = {m1 == m2}");
            Console.WriteLine($"Price of m1 != m2: {+m1} != {+m2} = {m1 != m2}");
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class Product(decimal _Price, string _Name)
    {
        public decimal Price { get; set; } = Math.Round(_Price , 2);
        public string Name { get; set; } = _Name;

        public static decimal operator +(Product a, Product b) => a.Price + b.Price; 
        public static decimal operator -(Product a, Product b) => a.Price - b.Price; 
        public static decimal operator *(Product a, Product b) => a.Price * b.Price; 
        public static decimal operator /(Product a, Product b) => a.Price / b.Price; 
        public static bool operator >(Product a, Product b) => a.Price > b.Price; 
        public static bool operator <(Product a, Product b) => a.Price < b.Price; 
        public static bool operator >=(Product a, Product b) => a.Price >= b.Price; 
        public static bool operator ==(Product a, Product b) => a.Price == b.Price; 
        public static bool operator !=(Product a, Product b) => a.Price != b.Price; 
        public static bool operator <=(Product a, Product b) => a.Price <= b.Price;
        public static decimal operator +(Product a) => a.Price;

        public override string ToString() => $"Name :{Name}      Price: {Price}";
    }
}
