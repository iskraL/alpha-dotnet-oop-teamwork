using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    public class IntMultiplication : BinaryOperation<int>
    {
        protected override IOperand<int> ApplyOperation(IOperand<int> operand1, IOperand<int> operand2)
        {
            return new IntType(operand1.Value * operand2.Value);
        }
    }
}
