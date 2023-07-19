using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorTask
{
    public class Calculator
    {
        public double Addition(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivisionEquality(double num1, double num2)
        {
            if (num2 == 0)
            {
                return 0;
            }

            return num1 / num2;
        }
    }

}
