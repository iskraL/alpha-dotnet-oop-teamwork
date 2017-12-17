using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Contracts
{
    internal interface IPriorityOperation<T> : IOperation<T> where T : struct
    {
        OperationPriority Priority { get; }
    }
}
