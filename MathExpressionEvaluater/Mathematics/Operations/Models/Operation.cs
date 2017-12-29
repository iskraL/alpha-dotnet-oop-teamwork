namespace Mathematics.Operations.Models
{
    using System;
    using System.Collections.Generic;
    using Operands.Contracts;
    using Contracts;
    using Enums;

    internal abstract class Operation : IOperation, IAssociativityOperation
    {
        protected Operation(OperationAssociativity associativity)
        {
            this.Operands = new List<IOperand>();
            this.Associativity = associativity;
        }

        protected IList<IOperand> Operands { get; }

        public IOperand Result
        {
            get
            {
                if (!this.IsComplete)
                {
                    throw new InvalidOperationException();
                }

                return ApplyOperation(this.Operands[1], this.Operands[0]);
            }
        }

        public abstract bool IsComplete { get; }
        public OperationAssociativity Associativity { get; }

        protected abstract IOperand ApplyOperation(IOperand o1, IOperand o2);

        public void AddOperand(IOperand operand)
        {
            if (!this.IsComplete)
            {
                this.Operands.Add(operand);
            }
        }

    }
}
