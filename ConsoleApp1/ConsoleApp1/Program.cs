using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product("Versace");
            pro.Count = 500;
            pro.Price = 200000;
            pro.Sell();
            Console.WriteLine(pro.TotalIncome);
            pro.Sell();
            Console.WriteLine(pro.TotalIncome);

        }
    }
}
