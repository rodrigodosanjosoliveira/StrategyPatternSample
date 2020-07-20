using StrategyPatternSample.Interfaces;

namespace StrategyPatternSample
{
    public class Context
    {
        private readonly IOperation _operation;

        public Context(IOperation operation)
        {
            _operation = operation;
        }

        public int ExecuteOperation(int numero1, int numero2)
            => _operation.DoOperation(numero1, numero2);
    }
}
