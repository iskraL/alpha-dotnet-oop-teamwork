using Mathematics.Operands.Contracts;

namespace Mathematics.Engine.Contracts
{
    interface IRPNCalculator<T>
    {
        IOperand<T> EvaluateRPNExpression(string[] tokens);
    }
}
