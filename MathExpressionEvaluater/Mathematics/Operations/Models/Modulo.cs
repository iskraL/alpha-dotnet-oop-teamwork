using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    class Modulo : BinaryOperation
    {
        protected override IOperand ApplyOperation(IOperand o1, IOperand o2)
        {
            return new IntType(o1.Value % o2.Value);
        }
    }
}
