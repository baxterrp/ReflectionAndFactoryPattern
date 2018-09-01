using SimpleCalculatorWithReflectionAndFactory.Interfaces;

namespace SimpleCalculatorWithReflectionAndFactory.MathStuff
{
    public class MathEngine : IMathEngine
    {
        ICalculatorFactory factory;

        public MathEngine(ICalculatorFactory factory)
        {
            this.factory = factory;
        }

        public string DoMath(string className, decimal a, decimal b)
        {
            var calculator = factory.GetCalculator(className);
            string results = calculator != null ? calculator.Calculate(a, b).ToString() : "Invalid Results";

            return results;
        }
    }
}