using Mathematics.Operands.Contracts;

namespace Mathematics.Engine.Contracts
{
    internal interface IReversePolishNotationCalculator
    {
        IOperand EvaluateRPNExpression(string[] tokens);
    }
}
