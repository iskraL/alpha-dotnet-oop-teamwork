namespace Mathematics.Engine
{
    using Contracts;
    using Mathematics.General.Models;
    using System.Collections.Generic;

    internal class InfixToPostfixConverter : IInfixToPostfixConverter
    {
        public IEnumerable<string> ConvertInfixToPostix(string[] tokens)
        {
            int index = 0;
            Queue<string> outputQueue = new Queue<string>();
            Stack<string> operatorsStack = new Stack<string>();

            while (index < tokens.Length)
            {
                var token = tokens[index];
        
                if (index < tokens.Length - 1)
                {
                    if (token == "-" && tokens[index + 1] != "(")
                    {
                        if (tokens[0]=="-"||tokens[index - 1] == "(")
                        {
                            int v = 0;
                            index++;
                            if ((int.TryParse(tokens[index], out v)))
                            {
                                token = (0 - v).ToString();
                            }
                        }
                    }
                }

                int parsable;
                if (int.TryParse(token, out parsable))
                {
                    outputQueue.Enqueue(token);
                }
                else if (Table.Operations.ContainsKey(token))
                {
                    while (operatorsStack.Count != 0)
                    {
                        string currentOperator = operatorsStack.Peek();
                        if(!Table.Operations.ContainsKey(currentOperator))
                        {
                            break;
                        }  
                        else if(Table.Operations[token] == Table.Operations[currentOperator] ||
                             Table.Operations[token] < Table.Operations[currentOperator])
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
                else if (token=="(")
                {
                    if (tokens[index+1] == ")")
                    {
                        throw new InvalidMathematicalExpressionException();
                    }
                    operatorsStack.Push(token);
                }
                else if (token==")")
                {
                    while (operatorsStack.Peek() != "(")
                    {
                        outputQueue.Enqueue(operatorsStack.Pop());
                    }
                    operatorsStack.Pop();
                }
                else
                {
                    throw new InvalidMathematicalExpressionException();
                }
                index++;
            }
            while(operatorsStack.Count != 0)
            {
                if(operatorsStack.Peek() == "("
                     || operatorsStack.Peek()==")")
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
