using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Contracts
{
    interface IAssociativityOperation<T> : IOperation<T> where T : struct
    {
        OperationAssociativity Associativity { get; }
    }
}
