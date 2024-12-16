using System.Numerics;
using System.Runtime.CompilerServices;

namespace try_event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new("Facebook", 100m, true);

            stock.ChangePriceBy(0.01m);
            stock.ChangePriceBy(-0.01m);
            stock.ChangePriceBy(0);

            Console.WriteLine();

            stock.Subscribe = false;
            stock.ChangePriceBy(0.01m);
            stock.ChangePriceBy(-0.01m);
            stock.ChangePriceBy(0);

            Console.ReadKey();
        }
    }

    public delegate void PriceChangeHandler(Stock stock, decimal oldPrice);
    public class Stock
    {
        public event PriceChangeHandler PriceChange;
        public string Name { get; set; } 
        public decimal Price {  get; set; } 
        public bool Subscribe { get; set; }

        public Stock(string _Name, decimal _Price, bool _Subscribe = false )
        {
            Subscribe = _Subscribe;
            Name = _Name;
            if (Price < 0) Price = 0;
            else Price = _Price;
        }

        private void Stock_PriceChange(Stock stock, decimal oldPrice)
        {
            string sign = "";
            if (stock.Price > oldPrice) { Console.ForegroundColor = ConsoleColor.Green; sign = "UP"; }
            else if (stock.Price < oldPrice) { Console.ForegroundColor = ConsoleColor.Red; sign = "DOWN"; }
            else Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"New Price for {stock.Name}: {stock.Price} {sign}");
        }
        public void ChangePriceBy(decimal percent) 
        {
            PriceChange = null;
            decimal oldPrice = this.Price;
            this.Price += percent*this.Price;
            PriceChange += Stock_PriceChange;
            if (Subscribe) PriceChange(this,oldPrice);
            else PriceChange(this, this.Price);
            
        }
    }
}
