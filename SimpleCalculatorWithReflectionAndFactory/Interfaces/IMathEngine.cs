using SimpleCalculatorWithReflectionAndFactory.MathStuff;

namespace SimpleCalculatorWithReflectionAndFactory.Interfaces
{
    public  interface IMathEngine
    {
        string DoMath(string className, decimal a, decimal b);
    }
}
