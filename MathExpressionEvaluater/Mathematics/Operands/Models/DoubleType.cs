using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    internal struct DoubleType : IOperand
    {
        public DoubleType(double value)
        {
            this.Value = value;
        }
        public double Value { get; }
    }
}
