using System.Collections;
using System.Linq;
namespace tryyy
{
    internal class Program
    {
        public enum Color
        {
            Red,
            Green,
            Blue,
            yellow,
            purple,
            cyan,
            magenta,
            mentgreen,
            mentblue 
        }

        static void Main(string[] args)
        {


            Color clr1 = (Color)1;
            Console.WriteLine($"{clr1}  =   {(int)clr1}");
            Console.WriteLine("-------------------------------");

            var x = Enum.IsDefined(clr1) ? clr1 : throw new ArgumentException("Status must be one of the Bstatus Enum");
            Console.WriteLine(x);

            
            foreach (var clri in Enum.GetValues<Color>())
            {
                Console.WriteLine($"{clri}  =  {(int)clri}");
            }





            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;





            //Console.WriteLine(Color.Green);
            //Console.WriteLine(Color.1);




            Console.ReadKey();
        } 
      
    }
          
}
