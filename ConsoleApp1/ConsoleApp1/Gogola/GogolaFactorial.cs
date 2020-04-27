using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Gogola
{
    class GogolaFactorial : IFactorial
    {
        public long CountFactorial(int number)
        {
            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }
    }
}
