using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    internal struct IntType : IOperand
    {
        public IntType(int value)
        {
            this.Value = value;
        }
        public int Value { get; }
    }
}
