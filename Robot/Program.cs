using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(drinks / shelves);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("At least 1 shelf");
            }
            catch (Exception e) {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}