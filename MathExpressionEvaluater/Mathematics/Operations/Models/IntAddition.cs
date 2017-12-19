using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    internal class IntAddition : BinaryOperation<int>
    {
        protected override IOperand<int> ApplyOperation(IOperand<int> o1, IOperand<int> o2)
        {
            return new IntType(o1.Value + o2.Value);
        }
    }
}
