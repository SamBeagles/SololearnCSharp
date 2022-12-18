using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, int> coffee = new Dictionary<string, int>();

            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Capuccino", 80);
            coffee.Add("Mocha", 90);

            foreach (KeyValuePair<string, int> entry in coffee)
            {
                Console.WriteLine(entry.Key + ": " + (entry.Value - entry.Value * discount / 100));
            }
        }
    }
}