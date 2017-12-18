using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    internal struct DecimalType : IOperand
    {
        public DecimalType(decimal value)
        {
            this.Value = value;
        }
        public decimal Value { get; }
    }
}
