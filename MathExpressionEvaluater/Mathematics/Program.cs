using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Models;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperand<int> o1 =  new Int(11);
            IOperand<float> o2 = new Float(2.3f);

            Multiplication<float> m = new Multiplication<float>();

            //m.AddOperand(o1);
            m.AddOperand(o2);

            Console.WriteLine(m.GetResult());
        }
    }
}
