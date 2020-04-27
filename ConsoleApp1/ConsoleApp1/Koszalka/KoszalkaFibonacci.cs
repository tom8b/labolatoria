using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Koszalka
{
    class KoszalkaFibonacci : IFibonacci
    {
        public int CountValueOfElement(int elementNumber)
        {
            int result = 1;

            if (elementNumber == 1 || elementNumber == 2)
                result = 1;
            else if (elementNumber <= 0)
            {
                throw new System.ArgumentException("Parameter cannot be <= 0");
            }
            else
            {
                int f1 = 1;
                int f2 = 1;
                int temp;
                for (int i = 3; i <= elementNumber; i++)
                {
                    temp = f1 + f2;
                    f1 = f2;
                    f2 = temp;
                }
                result = f2;
            }

            Console.WriteLine($"{elementNumber} element w ciagu Fibonacciego ma wartosc: {result}.");
            return result;
        }
    }
}


