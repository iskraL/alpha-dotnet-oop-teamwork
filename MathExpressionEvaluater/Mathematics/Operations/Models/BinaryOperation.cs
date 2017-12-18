using System;
using System.Collections.Generic;
using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    internal abstract class BinaryOperation : IAssociativityOperation
    {
        protected BinaryOperation()
        {
            this.Operands = new List<IOperand>();
            this.Associativity = OperationAssociativity.LeftToRight;
        }

        protected IList<IOperand> Operands { get; }

        public OperationAssociativity Associativity { get; }

        public IOperand Result
        {
            get
            {
                if (!this.IsComplete)
                {
                    throw new InvalidOperationException("Too few operands");
                }

                switch (this.Associativity)
                {
                    case OperationAssociativity.LeftToRight:
                        return ApplyOperation(Operands[0], Operands[1]);
                    default:
                        return ApplyOperation(Operands[1], Operands[0]);
                }
            }
        }

        public bool IsComplete => this.Operands.Count == 2;

        public void AddOperand(IOperand operand)
        {
            if (!this.IsComplete)
            {
                this.Operands.Add(operand);
            }
        }

        protected abstract IOperand ApplyOperation(IOperand o1, IOperand o2);
        
    }
}
