using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    class DecimalAddition : BinaryOperation<decimal>
    {
        protected override IOperand<decimal> ApplyOperation(IOperand<decimal> o1, IOperand<decimal> o2)
        {
            return new DecimalType(o1.Value * o2.Value);
        }
    }
}
