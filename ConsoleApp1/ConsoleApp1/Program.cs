using ConsoleApp1.Kubik;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IFibonacci> fibonacciList = new List<IFibonacci>();
            fibonacciList.Add(new KubikFibonacci());

            foreach(var fibonacci in fibonacciList)
            {
                Console.WriteLine(fibonacci.CountValueOfElement(0));
                Console.WriteLine(fibonacci.CountValueOfElement(1));
                Console.WriteLine(fibonacci.CountValueOfElement(2));
                Console.WriteLine(fibonacci.CountValueOfElement(3));
                Console.WriteLine(fibonacci.CountValueOfElement(4));
                Console.WriteLine(fibonacci.CountValueOfElement(5));
                Console.WriteLine(fibonacci.CountValueOfElement(6));

            }
        }
    }
}
