using System.Collections.Generic;

namespace Mathematics.Engine.Contracts
{
    using Operands.Contracts;

    internal interface IPostfixCalculator
    {
        IOperand EvaluateExpression(IEnumerable<string> tokens);
    }
}
