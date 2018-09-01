using SimpleCalculatorWithReflectionAndFactory.Interfaces;
using System;

namespace SimpleCalculatorWithReflectionAndFactory.MathStuff
{
    public class CalculatorFactory : ICalculatorFactory
    {
        public ICalculator GetCalculator(string className)
        {
            if (!string.IsNullOrEmpty(className))
            {
                Type calcType = Type.GetType(className);
                object obj = Activator.CreateInstance(calcType);
                return obj as ICalculator;
            }
            return null;
        }
    }
}