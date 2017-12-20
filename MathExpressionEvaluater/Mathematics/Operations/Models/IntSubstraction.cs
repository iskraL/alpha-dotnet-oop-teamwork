using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    public class IntSubstraction : BinaryOperation<int>
    {
        protected override IOperand<int> ApplyOperation(IOperand<int> operand1, IOperand<int> operand2)
        {
            return new IntType(operand1.Value - operand2.Value);
        }
    }
}
