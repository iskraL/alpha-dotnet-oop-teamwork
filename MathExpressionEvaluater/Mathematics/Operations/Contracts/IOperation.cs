using Mathematics.Operands.Contracts;

namespace Mathematics.Operations.Contracts
{
    public interface IOperation<T>
    {
        void AddOperand(IOperand<T> operand);
        IOperand<T> Result { get; }
        bool IsComplete { get; }
    }
}
