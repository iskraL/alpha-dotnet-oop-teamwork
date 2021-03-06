﻿namespace Mathematics.Operations.Contracts
{
    using Mathematics.Operands.Contracts;

    internal interface IOperation
    {
        void AddOperand(IOperand operand);
        IOperand Result { get; }
        bool IsComplete { get; }
    }
}
