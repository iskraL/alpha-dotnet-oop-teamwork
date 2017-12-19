using System;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    public struct IntType : IOperand<int>
    {
        public IntType(int value)
        {
            this.Value = value;
        }

        public int Value { get; set; }
    }
}
