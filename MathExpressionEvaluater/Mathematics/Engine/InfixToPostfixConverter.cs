using Mathematics.Engine.Contracts;
using Mathematics.Operations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine
{
    internal class InfixToPostfixConverter : IInfixToPostfixConverter
    {
        public Token[] Tokenize(string expression)
        {
            string[] splitExpression = SplitExpression(expression);
            IList<Token> tokens = new List<Token>();
            int index = 0;
            while(index<splitExpression.Length)
            {
                Token token = Token.StringToTokenParser(splitExpression[index]);
                if (splitExpression[index] == "-" && splitExpression[index+1]!= "(")
                {
                    if (tokens.Count == 0
                        || tokens[tokens.Count-1].Type==TokenType.LeftBracket
                        || tokens[tokens.Count - 1].Type == TokenType.Operator)
                    {
                        int nextValue = 0;
                        index++;
                        if((int.TryParse(splitExpression[index], out nextValue))){
                            token.Value = (0 - nextValue).ToString();
                        }
                    }
                }
                tokens.Add(token);
                index++;
            }
            return tokens.ToArray();
        }

        private string[] SplitExpression(string expression)
        {
            expression = expression.Replace("+", " + ");
            expression = expression.Replace("-", " - ");
            expression = expression.Replace("/", " / ");
            expression = expression.Replace("*", " * ");
            expression = expression.Replace("%", " % ");
            expression = expression.Replace("&", " & ");
            expression = expression.Replace("|", " | ");
            expression = expression.Replace("<<", " << ");
            expression = expression.Replace(">>", " >> ");
            expression = expression.Replace("(", " ( ");
            expression = expression.Replace(")", " ) ");
            expression = expression.Trim();

            while(expression.Contains("  "))
            {
                expression = expression.Replace("  ", " ");
            }

            return expression.Split(' ');
        }

        public Queue<Token> ConvertInfixToPostix(Token[] tokens)
        {
            int index = 0;
            Queue<Token> outputQueue = new Queue<Token>();
            Stack<Token> operatorsStack = new Stack<Token>();
            while (index < tokens.Count())
            {
                Token token = tokens[index];
                Token nextToken;

                if (token.Type == TokenType.Operand)
                {
                    outputQueue.Enqueue(token);
                }
                else if (token.Type == TokenType.Operator)
                {
                    if (index < tokens.Count() - 1)
                    {
                       nextToken = tokens[index + 1];
                       Validator.ValidateNextSymbol(token, nextToken);
                    }
                    
                    while (operatorsStack.Count != 0)
                    {
                       Token currentOperator = operatorsStack.Peek();
                        if(currentOperator.Type != TokenType.Operator)
                        {
                            break;
                        }
                        else if(token.Associativity==OperationAssociativity.LeftToRight &&token.Precedence== currentOperator.Precedence ||
                            token.Precedence < currentOperator.Precedence)
                        {
                            outputQueue.Enqueue(operatorsStack.Pop());                 
                        }
                        else
                        {
                            break;
                        }
                    }
                    operatorsStack.Push(token);
                }
                else if (token.Type == TokenType.LeftBracket)
                {
                    if (index < tokens.Count() - 1)
                    {
                        nextToken = tokens[index + 1];
                        Validator.ValidateNextSymbol(token, nextToken);
                    }
                    operatorsStack.Push(token);
                }
                else if (token.Type == TokenType.RightBracket)
                {
                    if (index < tokens.Count() - 1)
                    {
                        nextToken = tokens[index + 1];
                        Validator.ValidateNextSymbol(token, nextToken);
                    }
                    while (operatorsStack.Peek().Type != TokenType.LeftBracket)
                    {
                        outputQueue.Enqueue(operatorsStack.Pop());
                        Validator.ValidateBrackets(operatorsStack.Count);
                    }
                    operatorsStack.Pop();
                }
                index++;
            }
            while(operatorsStack.Count != 0)
            {
                if(operatorsStack.Peek().Type == TokenType.LeftBracket 
                    || operatorsStack.Peek().Type == TokenType.RightBracket)
                {
                    throw new InvalidMathematicalExpressionException("Missmatched brackets");
                }
                else
                {
                    outputQueue.Enqueue(operatorsStack.Pop());
                }
            }
           return outputQueue;
        }
    }
}
