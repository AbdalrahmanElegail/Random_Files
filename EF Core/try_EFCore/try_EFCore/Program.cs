﻿namespace try_EFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var _context = new ApplicationDbContext();


            _context.SaveChanges();



        }
    }
}
