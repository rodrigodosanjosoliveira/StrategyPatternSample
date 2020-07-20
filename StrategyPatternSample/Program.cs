using StrategyPatternSample.Operations;

using static System.Console;

namespace StrategyPatternSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new Add());
            WriteLine($"10 + 5 = {context.ExecuteOperation(10, 5)}");

            context = new Context(new Subtract());
            WriteLine($"10 - 5 = {context.ExecuteOperation(10, 5)}");

            context = new Context(new Multiply());
            WriteLine($"10 * 5 = {context.ExecuteOperation(10, 5)}");
        }
    }
}
