using System;
using System.Collections.Generic;
using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    public abstract class BinaryOperation<T> : IOperation<T>, IAssociativityOperation
    {
        protected BinaryOperation()
        {
            this.Operands = new List<IOperand<T>>();
            this.Associativity = OperationAssociativity.LeftToRight;
        }

        protected IList<IOperand<T>> Operands { get; }

        public OperationAssociativity Associativity { get; }

        public IOperand<T> Result
        {
            get
            {
                if (!this.IsComplete)
                {
                    throw new InvalidOperationException("Too few operands");
                }

                return ApplyOperation(Operands[0], Operands[1]);
            }
        }

        public bool IsComplete => this.Operands.Count == 2;

        public void AddOperand(IOperand<T> operand)
        {
            if (!this.IsComplete)
            {
                this.Operands.Add(operand);
            }
        }

        protected abstract IOperand<T> ApplyOperation(IOperand<T> operand1, IOperand<T> operand2);
        
    }
}
