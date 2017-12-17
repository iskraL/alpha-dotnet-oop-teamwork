using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    internal struct Decimal : IOperand<decimal>
    {
        public Decimal(decimal value)
        {
            this.Value = value;
        }
        public decimal Value { get; }
    }
}
