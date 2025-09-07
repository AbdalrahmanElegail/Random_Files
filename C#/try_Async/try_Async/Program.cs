namespace try_Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MakeTeaAsync();
            Console.ReadLine();
        }

        public static void MakeTea()
        {
            string poiledWater = PoilWater();
            Console.WriteLine("Adding Tea Bag.");
            Console.WriteLine("Adding Sugar.");
            Console.WriteLine($"Pooring {poiledWater} in the Cup");
            Console.WriteLine("Tea is Ready.");

        }
        public static string PoilWater()
        {
            Console.WriteLine("Kattle Started.");
            Console.WriteLine("Waiting For Kattle To Poil Water.");

            Task.Delay(5000).GetAwaiter().GetResult();
            Console.WriteLine("Kattle Poiled Water.");

            return "Poiled Water";
        }

        //Async Version
        public static async void MakeTeaAsync()
        {
            Task<string> startPoilingWater = PoilWaterAsync();

            Console.WriteLine("Adding Tea Bag.");
            Console.WriteLine("Adding Sugar.");

            string PoilingWaterResult = await startPoilingWater;
            Console.WriteLine($"Pooring {PoilingWaterResult} in the Cup");
            Console.WriteLine("Tea is Ready.");

        }
        public static async Task<string> PoilWaterAsync()
        {
            Console.WriteLine("Kattle Started.");
            Console.WriteLine("Waiting For Kattle To Poil Water.");

            await Task.Delay(5000);
            Console.WriteLine("Kattle Poiled Water.");

            return "Poiled Water";
        }
    }
}
