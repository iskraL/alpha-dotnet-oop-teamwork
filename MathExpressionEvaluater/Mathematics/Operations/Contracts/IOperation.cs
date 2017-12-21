using Mathematics.Operands.Contracts;

namespace Mathematics.Operations.Contracts
{
    public interface IOperation
    {
        void AddOperand(IOperand operand);
        IOperand Result { get; }
        bool IsComplete { get; }
    }
}
