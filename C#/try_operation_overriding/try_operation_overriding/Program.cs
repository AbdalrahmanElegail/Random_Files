namespace try_operation_overriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money m1 = new(15, "Apple price");
            Money m2 = new(10, "Orange price");

            Console.WriteLine(m1 + m2);
            Console.WriteLine(m1 - m2);
            Console.WriteLine(m1 * m2);
            Console.WriteLine(m1 / m2);
            Console.WriteLine(m1 > m2);
            Console.WriteLine(m1 < m2);
            Console.WriteLine(m1 >= m2);
            Console.WriteLine(m1 <= m2);
            Console.WriteLine(m1 == m2);
            Console.WriteLine(m1 != m2);

            Console.ReadKey();
        }
    }

    public class Money(decimal _Price, string _Name)
    {
        public decimal Price { get; set; } = Math.Round(_Price , 2);
        public string Name { get; set; } = _Name;

        public static decimal operator +(Money a, Money b) => a.Price + b.Price; 
        public static decimal operator -(Money a, Money b) => a.Price - b.Price; 
        public static decimal operator *(Money a, Money b) => a.Price * b.Price; 
        public static decimal operator /(Money a, Money b) => a.Price / b.Price; 
        public static bool operator >(Money a, Money b) => a.Price > b.Price; 
        public static bool operator <(Money a, Money b) => a.Price < b.Price; 
        public static bool operator >=(Money a, Money b) => a.Price >= b.Price; 
        public static bool operator ==(Money a, Money b) => a.Price == b.Price; 
        public static bool operator !=(Money a, Money b) => a.Price != b.Price; 
        public static bool operator <=(Money a, Money b) => a.Price <= b.Price;
    }
}
