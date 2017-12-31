using System;
using System.Collections.Generic;
using Mathematics.Engine.Contracts;
using Mathematics.General.Models;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
namespace Mathematics.Engine
{
    using Operations.Contracts;

    internal sealed class PostfixCalculator : IPostfixCalculator
    {
        protected readonly Stack<IOperand> machineStack;

        public PostfixCalculator()
        {
            this.machineStack = new Stack<IOperand>();
        }

        public IOperand EvaluateExpression(IEnumerable<string> tokens)
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
                throw new InvalidMathematicalExpressionException();
            }

            return this.machineStack.Pop();
        }

        private void EvaluateOperation(IOperation operation)
        {
            while (!operation.IsComplete)
            {
                if (this.machineStack.Count == 0)
                {
                    throw new InvalidOperationException(string
                        .Format(ErrorMessages.IncompleteResult, operation.GetType().Name));
                }

                operation.AddOperand(this.machineStack.Pop());
            }

            this.machineStack.Push(operation.Result);
        }
    }
}
