using System;

namespace Mathematics.Engine
{
    using Contracts;
    using System.Collections.Generic;

    internal class InfixToPostfixConverter : IInfixToPostfixConverter
    {
        //todo: implement me :D
        public IEnumerable<string> ConvertInfixToPostix(string[] tokens)
        {
            //int index = 0;
            //Queue<string> outputQueue = new Queue<string>();
            //Stack<string> operatorsStack = new Stack<string>();

            //while (index < tokens.Count())
            //{
            //     var token = tokens[index];

            //     if (token.Type == TokenType.Operand)
            //     {
            //         outputQueue.Enqueue(token);
            //     }
            //     else if (token.Type == TokenType.Operator)
            //     {
            //         if (index < tokens.Count() - 1)
            //         {
            //            nextToken = tokens[index + 1];
            //            Validator.ValidateNextSymbol(token, nextToken);
            //         }

            //         while (operatorsStack.Count != 0)
            //         {
            //            Token currentOperator = operatorsStack.Peek();
            //             if(currentOperator.Type != TokenType.Operator)
            //             {
            //                 break;
            //             }
            //             else if(token.Associativity==OperationAssociativity.LeftToRight &&token.Precedence== currentOperator.Precedence ||
            //                 token.Precedence < currentOperator.Precedence)
            //             {
            //                 outputQueue.Enqueue(operatorsStack.Pop());                 
            //             }
            //             else
            //             {
            //                 break;
            //             }
            //         }
            //         operatorsStack.Push(token);
            //     }
            //     else if (token.Type == TokenType.LeftBracket)
            //     {
            //         if (index < tokens.Count() - 1)
            //         {
            //             nextToken = tokens[index + 1];
            //             Validator.ValidateNextSymbol(token, nextToken);
            //         }
            //         operatorsStack.Push(token);
            //     }
            //     else if (token.Type == TokenType.RightBracket)
            //     {
            //         if (index < tokens.Count() - 1)
            //         {
            //             nextToken = tokens[index + 1];
            //             Validator.ValidateNextSymbol(token, nextToken);
            //         }
            //         while (operatorsStack.Peek().Type != TokenType.LeftBracket)
            //         {
            //             outputQueue.Enqueue(operatorsStack.Pop());
            //             Validator.ValidateBrackets(operatorsStack.Count);
            //         }
            //         operatorsStack.Pop();
            //     }
            //     index++;
            // }
            // while(operatorsStack.Count != 0)
            // {
            //     if(operatorsStack.Peek().Type == TokenType.LeftBracket 
            //         || operatorsStack.Peek().Type == TokenType.RightBracket)
            //     {
            //         throw new InvalidMathematicalExpressionException("Missmatched brackets");
            //     }
            //     else
            //     {
            //         outputQueue.Enqueue(operatorsStack.Pop());
            //     }
            // }
            //return outputQueue;

            throw new NotImplementedException();
        }
    }
}
