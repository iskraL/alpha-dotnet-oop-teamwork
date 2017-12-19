using Mathematics.Operands.Contracts;

namespace Mathematics.Operations.Contracts
{
    internal interface IOperation<T>
    {
        void AddOperand(IOperand<T> operand);
        IOperand<T> Result { get; }
        bool IsComplete { get; }
    }
}
