﻿using SimpleCalculatorWithReflectionAndFactory.Interfaces;

namespace SimpleCalculatorWithReflectionAndFactory.MathStuff
{
    public class SubtractionCalculator : ICalculator
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return a - b;
        }
    }
}