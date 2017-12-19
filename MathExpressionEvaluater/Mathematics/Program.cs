using System;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Models;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperand o1 = new DecimalType(11);
            IOperand o2 = new DecimalType(4);

            Console.WriteLine(o1.GetType() == o2.GetType());    

            Division m = new Division();

            m.AddOperand(o2);
            m.AddOperand(o1);

            IOperand result = m.Result;
            Console.WriteLine(((DecimalType)result).Value);
        }
    }
}
