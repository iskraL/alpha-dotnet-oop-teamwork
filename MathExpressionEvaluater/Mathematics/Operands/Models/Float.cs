using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operands.Models
{
    class Float : IOperand<float>
    {
        public Float(float value)
        {
            this.Value = value;
        }
        public float Value { get;  }
    }
}
