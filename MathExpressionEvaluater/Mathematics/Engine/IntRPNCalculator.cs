using System;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Models;

namespace Mathematics.Engine
{
    internal class IntRPNCalculator : RPNCalculator<int>
    {
        protected override IOperation<int> GetOperation(string token)
        {
            throw new NotImplementedException();
        }

        protected override IOperand<int> GetOperand(string token)
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
