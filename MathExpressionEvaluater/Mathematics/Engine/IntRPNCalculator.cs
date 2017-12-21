using System;
using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Models;

namespace Mathematics.Engine
{
    internal class IntRPNCalculator : RPNCalculator<int>
    {
        protected override IOperation<int> ParseOperation(string token)
        {
            return new IntAddition();
        }

        protected override IOperand<int> ParseOperand(string token)
        {
            int value;
            if (int.TryParse(token, out value))
            {
                return this.factory.GetIntTypeOperand(value);
            }

            throw new ArgumentException($"Ivalid operand: {token}");
        }
    }
}
