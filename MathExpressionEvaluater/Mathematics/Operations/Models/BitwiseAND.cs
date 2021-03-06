﻿namespace Mathematics.Operations.Models
{
    using Mathematics.Operands.Contracts;
    using Mathematics.Operands.Models;

    internal class BitwiseAND : BinaryOperation
    {
        protected override IOperand ApplyOperation(IOperand o1, IOperand o2)
        {
            return new IntType(o1.Value & o2.Value);
        }
    }
}
