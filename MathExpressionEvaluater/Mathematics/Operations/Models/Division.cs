using System;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics.Operations.Models
{
    internal class Division : BinaryOperation
    {
        protected override IOperand ApplyOperation(IOperand o1, IOperand o2)
        {
            if (o1 is IntType && o2 is IntType)
            {
                return new IntType(((IntType)o1).Value / ((IntType)o2).Value);
            }
            else if (o1 is FloatType && o2 is FloatType)
            {
                return new FloatType(((FloatType)o1).Value / ((FloatType)o2).Value);
            }
            else if (o1 is DoubleType && o2 is DoubleType)
            {
                return new DoubleType(((DoubleType)o1).Value / ((FloatType)o2).Value);
            }
            else if (o1 is DecimalType && o2 is DecimalType)
            {
                return new DecimalType(((DecimalType)o1).Value / ((DecimalType)o2).Value);
            }

            throw new NotSupportedException("Operation not supported on IOperand args");
        }
    }
}
