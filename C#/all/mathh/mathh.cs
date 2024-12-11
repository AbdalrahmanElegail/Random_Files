using System.Threading.Channels;

namespace mathh
{
    public static class Math1
    {

        public static int prop { get; set; }

       

        public static void Greet()
        {
            Console.WriteLine("Hello maths");
        }

        public static void PrintSumOf(int a, int b)
        {
            Console.WriteLine($"operation: {a}+{b}={a + b}");
        }

    }
}
