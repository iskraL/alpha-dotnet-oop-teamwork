﻿using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    class BitwiseExclusiveOR : BinaryOperation
    {
        protected override IOperand ApplyOperation(IOperand o1, IOperand o2)
        {
            return new IntType(o1.Value ^ o2.Value);
        }
    }
}