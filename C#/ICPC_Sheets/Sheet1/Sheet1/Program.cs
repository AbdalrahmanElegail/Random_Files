using System;
namespace Sheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////    Q1    /////////////////////
            int n = int.Parse(Console.ReadLine()!);
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int dema = 0;
            int sereja = 0;
            int l = 0;
            int r = n - 1;
            for (int k = 0; k < n; k++)
            {
                if (l>r) break;
                int x = arr[l] >= arr[r] ? arr[l++] : arr[r--];
                if (k % 2 == 0)
                {
                    sereja += x;
                }
                else
                {
                    dema += x;
                }
            }
            Console.Write($"{sereja} {dema}");
            
            /////////////////////    Q2    /////////////////////
            

        
        }
    }
}
