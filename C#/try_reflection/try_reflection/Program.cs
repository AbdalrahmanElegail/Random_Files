using System;
using System.Reflection;

namespace try_reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wallet w1 = new();
            Console.WriteLine(w1 + "\n");
            Type t1 = typeof(Wallet);


            Console.Write("Enter New Name: ");
            string Name = Console.ReadLine()!.Trim();
            t1.GetProperty("HolderName", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)!.SetValue(w1, Name);
            Console.WriteLine(w1 + "\n");

            Console.Write("Enter Balance: ");
            int balance = int.Parse(Console.ReadLine()!);
            t1.GetProperty("Balance", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)!.SetValue(w1, balance);
            Console.WriteLine(w1 + "\n");

            while (true)
            {
                Console.Write("Enter the Method you want to affect (Deposit/Withdraw): ");
                string method = Console.ReadLine()!.Trim();

                if (method != "Deposit" && method != "Withdraw")
                {
                    Console.WriteLine("Invalid method name! Please enter 'Deposit' or 'Withdraw'.");
                    continue;
                }

                Console.Write($"Enter the amount you want to {method}: ");
                if (!int.TryParse(Console.ReadLine(), out int amount) || amount <= 0)
                {
                    Console.WriteLine("Invalid amount! Please enter a valid positive integer.");
                    continue;
                }

                MethodInfo? methodInfo = t1.GetMethod(method, BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

                if (methodInfo == null)
                {
                    Console.WriteLine($"Method '{method}' not found!");
                    continue;
                }

                methodInfo.Invoke(w1, [amount]);
                Console.WriteLine("Updated Wallet:\n" + w1);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
            }
        }
    }

    public class Wallet
    {
        public int Balance { get; private set; }
        private string? HolderName { get; set; }

        private void Deposit(int amount) => Balance += amount;
        private void Withdraw(int amount) => Balance -= amount;

        public override string ToString() => $"Name: {HolderName} | Balance: ${Balance}";
    }
}
