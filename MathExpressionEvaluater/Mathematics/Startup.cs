using System;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Models;

namespace Mathematics
{
    class Startup
    {
        static void Main()
        {
            IOperand o1 =  new DecimalType(11);
            IOperand o2 = new DecimalType(2);

            Division m = new Division();

            m.AddOperand(o2);
            m.AddOperand(o1);

            IOperand result = m.Result;
            Console.WriteLine(((DecimalType)result).Value);
        }
    }
}