namespace SimpleCalculatorWithReflectionAndFactory.Interfaces
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(string className);
    }
}
