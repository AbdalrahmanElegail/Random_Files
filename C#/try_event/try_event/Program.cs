using System.Numerics;
using System.Runtime.CompilerServices;

namespace try_event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock1 = new("Facebook", 100m);
            stock1.Subscribe();
            stock1.ChangePriceBy(0);
            stock1.ChangePriceBy(-0.01m);
            stock1.ChangePriceBy(0.01m);

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            Stock stock2 = new("Google", 100m);
            stock2.ChangePriceBy(0);
            stock2.ChangePriceBy(-0.01m);
            stock2.ChangePriceBy(0.01m);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");

            stock2.Subscribe();
            stock2.ChangePriceBy(0);
            stock2.ChangePriceBy(-0.01m);
            stock2.ChangePriceBy(0.01m);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");



            Console.ReadKey();
        }
    }

    //public delegate void PriceChangeHandler(Stock stock, decimal oldPrice, ref string sign);
    public class Stock(string _Name, decimal _Price)
    {
        public event Func<Stock, decimal, string>? PriceChangeService = null;

        //private event PriceChangeHandler? PriceChangeService2 = null;
        public string Name { get; set; } = _Name;
        public decimal Price { get; set; } = _Price < 0 ? 0 : _Price;
        private bool Subscribed { get; set; } = false;
        public void Subscribe() => Subscribed = true;

        private string StockPriceChangeService(Stock stock, decimal oldPrice)
        {
            string? sign;
            if (stock.Price > oldPrice) { Console.ForegroundColor = ConsoleColor.Green; sign = "UP"; }
            else if (stock.Price < oldPrice) { Console.ForegroundColor = ConsoleColor.Red; sign = "DOWN"; }
            else { Console.ForegroundColor = ConsoleColor.Gray; sign = "CONST"; }
            return sign;
        }
        public void ChangePriceBy(decimal percent) 
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            string? sign = "";
            decimal oldPrice = this.Price;
            this.Price += percent * this.Price;
            this.Price = Math.Round(this.Price,2); 
            if (Subscribed)
            {
                PriceChangeService += StockPriceChangeService;
                sign = PriceChangeService(this, oldPrice);
            }
            Console.WriteLine($"New Price for {this.Name}: {this.Price} {sign}");
        }
    }
}
