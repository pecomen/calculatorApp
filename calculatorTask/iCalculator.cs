﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorTask
{
    public interface  iCalculator
    {
        double  Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }
}
