using System;
using System.Collections.Generic;
using Mathematics.Core.Engine;
using Mathematics.Engine.Contracts;
using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Models;

namespace Mathematics.Engine
{
    //Reversed Polish Notation Calculator
    internal abstract class RPNCalculator<T> : IRPNCalculator<T>
    {
        protected readonly Stack<IOperand<T>> machineStack;
        protected readonly Factory factory;

        protected RPNCalculator()
        {
            this.machineStack = new Stack<IOperand<T>>();
            this.factory = new Factory();
        }

        public IOperand<T> EvaluateRPNExpression(string[] tokens)
        {
            this.machineStack.Clear();

            foreach (var token in tokens)
            {
                if (Table.Operations.ContainsKey(token))
                {
                    var operation = ParseOperation(token);
                    EvaluateOperation(operation);
                }
                else
                {
                    var operand = ParseOperand(token);
                    this.machineStack.Push(operand);
                }
            }

            if (this.machineStack.Count != 1)
            {
                throw new Exception("Invalid mathematical expression");
            }

            return machineStack.Pop();
        }

        private void EvaluateOperation(IOperation<T> operation)
        {
            switch (this.machineStack.Count)
            {
                case 0:
                case 1:
                    throw new InvalidOperationException("Ivalid mathematical expression");
                default:
                    var o2 = this.machineStack.Pop();
                    var o1 = this.machineStack.Pop();

                    operation.AddOperand(o1);
                    operation.AddOperand(o2);

                    this.machineStack.Push(operation.Result);
                    break;
            }
        }

        protected abstract IOperation<T> ParseOperation(string token);

        protected abstract IOperand<T> ParseOperand(string token);
    }
}
