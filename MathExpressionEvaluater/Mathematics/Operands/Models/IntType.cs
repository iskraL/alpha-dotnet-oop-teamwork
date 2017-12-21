using System;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    public struct IntType : IOperand
    {
        public IntType(int value)
        {
            this.Value = value;
        }

        public int Value { get; }

        public static IntType Parse(string str)
        {
            int value;
            if (!int.TryParse(str, out value))
            {
                throw new ArgumentException();
            }

            return new IntType(value);
        }
    }
}
