using StrategyPatternSample.Interfaces;

namespace StrategyPatternSample.Operations
{
    public class Add : IOperation
    {
        public int DoOperation(int numero1, int numero2) => numero1 + numero2;
    }
}
