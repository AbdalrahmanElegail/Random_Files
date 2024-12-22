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

            Product p1 = new(15, "Apple");
            Product p2 = new(10, "Mango");

            Console.WriteLine($"p1 => {p1}");
            Console.WriteLine($"p2 => {p2}");
            Console.WriteLine();
            Console.WriteLine($"p1  + p2: {+p1}  + {+p2} = {p1 + p2}");
            Console.WriteLine($"p1  - p2: {+p1}  - {+p2} = {p1 - p2}");
            Console.WriteLine($"p1  * p2: {+p1}  * {+p2} = {p1 * p2}");
            Console.WriteLine($"p1  / p2: {+p1}  / {+p2} = {p1 / p2}");
            Console.WriteLine($"p1  > p2: {+p1}  > {+p2} = {p1 > p2}");
            Console.WriteLine($"p1  < p2: {+p1}  < {+p2} = {p1 < p2}");
            Console.WriteLine($"p1 >= p2: {+p1} >= {+p2} = {p1 >= p2}");
            Console.WriteLine($"p1 <= p2: {+p1} <= {+p2} = {p1 <= p2}");
            Console.WriteLine($"p1 == p2: {+p1} == {+p2} = {p1 == p2}");
            Console.WriteLine($"p1 != p2: {+p1} != {+p2} = {p1 != p2}");
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
