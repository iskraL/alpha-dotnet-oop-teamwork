using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    internal struct FloatType : IOperand
    {
        public FloatType(float value)
        {
            this.Value = value;
        }
        public float Value { get;  }
    }
}
