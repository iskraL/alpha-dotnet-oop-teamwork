namespace Mathematics.Engine.Contracts
{
    using Mathematics.Operands.Contracts;

    internal interface IReversePolishNotationCalculator
    {
        IOperand EvaluateRPNExpression(string[] tokens);
    }
}
