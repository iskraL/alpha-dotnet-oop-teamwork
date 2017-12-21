using Mathematics.Operands.Contracts;

namespace Mathematics.Engine.Contracts
{
    interface IReversePolishNotationCalculator
    {
        IOperand EvaluateRPNExpression(string[] tokens);
    }
}
