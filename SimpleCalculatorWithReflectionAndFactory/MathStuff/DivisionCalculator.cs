using SimpleCalculatorWithReflectionAndFactory.Interfaces;

namespace SimpleCalculatorWithReflectionAndFactory.MathStuff
{
    public class DivisionCalculator : ICalculator
    {
        public decimal Calculate(decimal a, decimal b)
        {
            return b != decimal.Zero ? a / b : decimal.Zero;
        }
    }
}