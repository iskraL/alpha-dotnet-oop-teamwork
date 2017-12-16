using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;

namespace Mathematics.Operations.Contracts
{
    interface IOperation<T> where T : struct
    {
        void AddOperand(IOperand<T> operand);
        T GetResult();
        bool IsComplete();
    }
}
