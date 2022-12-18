using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            var x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(pi*(x*x));
        }
    }
}