using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Gogola
{
    class GogolaFibonacci : IFibonacci
    {
        public int CountValueOfElement(int elementNumber)
        {
            int a = 0, b = 1;

            for (int i = 0; i < elementNumber; i++)
            {
                b = b + a;
                a = b - a;
            }

            return b;
        }
    }
}


