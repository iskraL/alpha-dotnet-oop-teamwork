using Mathematics.Operands.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine.Contracts
{
    interface IRPNCalculator<T>
    {
        void AddOperand(IOperand<T> operand);
        IOperand<T> Result { get; }
    }
}
