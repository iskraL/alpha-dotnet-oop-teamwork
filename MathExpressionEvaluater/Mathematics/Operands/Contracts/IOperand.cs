using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Operands.Contracts
{
    internal interface IOperand<T> where T : struct
    {
        T Value { get; }
    }
}
