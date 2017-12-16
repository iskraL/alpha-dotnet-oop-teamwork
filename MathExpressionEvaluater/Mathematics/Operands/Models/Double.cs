using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    class Double : IOperand<double>
    {
        public Double(double value)
        {
            this.Value = value;
        }
        public double Value { get; }
    }
}
