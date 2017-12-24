using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    internal class Substraction : BinaryOperation
    {
        protected override IOperand ApplyOperation(IOperand o1, IOperand o2)
        {
            return new IntType(o1.Value - o2.Value);
        }
    }
}
