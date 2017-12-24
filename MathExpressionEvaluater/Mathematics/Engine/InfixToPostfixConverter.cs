using Mathematics.Operations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine
{
    class InfixToPostfixConverter
    {
        public Token[] Tokenize(string expression)
        {
            string[] splitExpression = SplitExpression(expression);
            IList<Token> tokens = new List<Token>();
            int i = 0;
            while(i<splitExpression.Length)
            {
                Token token = Token.StringToTokenParser(splitExpression[i]);
                if (splitExpression[i] == "-" && splitExpression[i+1]!= "(")
                {
                    if (tokens.Count == 0
                        || tokens[tokens.Count-1].Type==TokenType.LeftBracket
                        || tokens[tokens.Count - 1].Type == TokenType.Operator)
                    {
                        int v = 0;
                        i++;
                        if((int.TryParse(splitExpression[i], out v))){
                            token.Value = (0 - v).ToString();
                        }
                    }
                }
                tokens.Add(token);
                i++;
            }

            return tokens.ToArray();
        }
        private string[] SplitExpression(string expression)
        {
            expression = expression.Replace("+", " + ");
            expression = expression.Replace("-", " - ");
            expression = expression.Replace("/", " / ");
            expression = expression.Replace("*", " * ");
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
            Stack<Token> operatorStack = new Stack<Token>();
            while (index < tokens.Count())
            {
                Token token = tokens[index];
                if (token.Type == TokenType.Operand)
                {
                    outputQueue.Enqueue(token);
                }
                else if (token.Type == TokenType.Operator)
                {
                    while (operatorStack.Count != 0)
                    {
                        Token operator2 = operatorStack.Peek();
                        if(operator2.Type != TokenType.Operator)
                        {
                            break;
                        }
                        else if(token.Associativity==OperationAssociativity.LeftToRight &&token.Precedence==operator2.Precedence ||
                            token.Precedence < operator2.Precedence)
                        {
                            outputQueue.Enqueue(operatorStack.Pop());
                           
                        }
                        else
                        {
                            break;
                        }
                    }
                    operatorStack.Push(token);
                }
                else if (token.Type == TokenType.LeftBracket)
                {
                    operatorStack.Push(token);
                }
                else if (token.Type == TokenType.RightBracket)
                {
                    while(operatorStack.Peek().Type != TokenType.LeftBracket)
                    {
                        outputQueue.Enqueue(operatorStack.Pop());
                        if (operatorStack.Count() == 0)
                        {
                            throw new Exception("Missmatched brackets");
                        }
                    }
                    operatorStack.Pop();
                }
                index++;
            }
            while(operatorStack.Count != 0)
            {
                if(operatorStack.Peek().Type == TokenType.LeftBracket 
                    || operatorStack.Peek().Type == TokenType.RightBracket)
                {
                            throw new Exception("Missmatched brackets");
                }
                else
                {
                    outputQueue.Enqueue(operatorStack.Pop());
                }
            }
           return outputQueue;
        }
    }
}
