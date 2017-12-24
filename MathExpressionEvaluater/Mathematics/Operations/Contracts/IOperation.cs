using Mathematics.Operands.Contracts;

namespace Mathematics.Operations.Contracts
{
    internal interface IOperation
    {
        void AddOperand(IOperand operand);
        IOperand Result { get; }
        bool IsComplete { get; }
    }
}
