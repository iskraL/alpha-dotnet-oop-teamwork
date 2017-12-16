using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    class Int : IOperand<int>
    {
        public Int(int value)
        {
            this.Value = value;
        }
        public int Value { get; }
    }
}
