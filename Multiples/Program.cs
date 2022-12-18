using System;
using System.Collections.Generic;

namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(7);
            int x = 1;
            for (x = 1; x <= number; x++){
                if (x%3 != 0) 
                {
                    Console.Write(x);
                }
                else Console.Write("*");
            }
        }
    }
}