using System;
using System.Collections.Generic;
using Mathematics.Engine.Contracts;
using Mathematics.General.Models;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Contracts;

namespace Mathematics.Engine
{
    internal sealed class ReversePolishNotationCalculator : IReversePolishNotationCalculator
    {
        protected readonly Stack<IOperand> machineStack;

        public ReversePolishNotationCalculator()
        {
            this.machineStack = new Stack<IOperand>();
        }

        public IOperand EvaluateRPNExpression(string[] tokens)
        {
            this.machineStack.Clear();

            foreach (var token in tokens)
            {
                if (Table.Operations.ContainsKey(token))
                {
                    var operation = Table.GetOperation(token);
                    EvaluateOperation(operation);
                }
                else
                {
                    var operand = IntType.Parse(token);
                    this.machineStack.Push(operand);
                }
            }

            if (this.machineStack.Count != 1)
            {
                throw new Exception("Invalid mathematical expression");
            }

            return this.machineStack.Pop();
        }

        private void EvaluateOperation(IOperation operation)
        {
            while (!operation.IsComplete)
            {
                if (this.machineStack.Count == 0)
                {
                    throw new InvalidOperationException("Ivalid mathematical expression");
                }

                operation.AddOperand(this.machineStack.Pop());
            }

            this.machineStack.Push(operation.Result);
        }
    }
}
