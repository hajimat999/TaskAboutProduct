using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Product
    {
        public string Name;
        public int Count;
        public double Price;
        public double TotalIncome;

        public Product(string name)
        {
            Name = name;

        }

        public double Sell()
        {
            if(Count > 0)
            {
                Count--;
                TotalIncome += Price;
                Console.WriteLine("1 eded satildi");
            }
            else
            {
                Console.WriteLine("Mehsul Qalmayib");
            }
            return TotalIncome;
        }
    }
}
