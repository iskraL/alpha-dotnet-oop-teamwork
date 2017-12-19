using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    public class DecimalDivision : BinaryOperation<decimal>
    {
        protected override IOperand<decimal> ApplyOperation(IOperand<decimal> operand1, IOperand<decimal> operand2)
        {
            return new DecimalType(operand1.Value / operand2.Value);
        }
    }
}
