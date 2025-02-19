using System.Runtime.InteropServices;

namespace contest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int n = arr[0];
                int m = arr[1];
                int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int[] b = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int b1 = b[0];
                for (int j = 0; j < n; j++)
                {
                    a[j] = b1 - a[j];
                }

                if (IsSorted(a))
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        public static bool IsSorted(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] > a[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
