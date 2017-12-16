using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    abstract class BinaryOperation<T> : IPriorityOperation<T>, IAssociativityOperation<T> where T : struct
    {
        protected BinaryOperation()
        {
            this.operands = new List<IOperand<T>>();
            this.Associativity = OperationAssociativity.LeftToRight;
        }

        protected IList<IOperand<T>> operands;

        public abstract OperationPriority Priority { get; }

        public OperationAssociativity Associativity { get; }

        public abstract T GetResult();

        public void AddOperand(IOperand<T> operand)
        {
            if (!this.IsComplete())
            {
                this.operands.Add(operand);
            }
        }

        public bool IsComplete()
        {
            return operands.Count == 2;
        }
    }
}
