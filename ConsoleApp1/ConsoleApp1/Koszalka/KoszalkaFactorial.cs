using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Koszalka
{
    class KoszalkaFactorial : IFactorial
    {
        public long CountFactorial(int number)
        {
            long result = 1;
            if (number > 0)
                for (int i = 1; i <= number; i++)
                    result *= i;
            else if (number == 0)
                result = 1;
            else
                throw new System.ArgumentException("Parameter cannot be < 0");

            Console.WriteLine($"Silnia dla {x} ma wartosc: {result}.");
            return result;
        }
    }
}
