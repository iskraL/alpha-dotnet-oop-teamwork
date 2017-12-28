namespace Mathematics.Engine
{
    using System;

    internal static class Validator
    {
        public static void ValidateNextSymbol(Token currentToken, Token nextToken)
        {
            switch (currentToken.Type)
            {
                case TokenType.Operator:
                    if (nextToken.Type == TokenType.RightBracket)
                    {
                        try
                        {
                            throw new InvalidMathematicalExpressionException("Invalid mathematical expression. Operators cannot be followed by right brackets");
                        }
                        catch(InvalidMathematicalExpressionException e)
                        {
                            Console.WriteLine(e.Message);
                            System.Environment.Exit(1);
                        }
                    }
                        break;
                case TokenType.LeftBracket:
                    if (nextToken.Type == TokenType.RightBracket)
                    {
                        try
                        {
                            throw new InvalidMathematicalExpressionException("Invalid mathematical expression. Left bracket cannot be directly followed by a right bracket.");
                        }
                        catch (InvalidMathematicalExpressionException e)
                        {
                            Console.WriteLine(e.Message);
                            System.Environment.Exit(1);
                        }
                    }
                    break;

                case TokenType.RightBracket:
                    if (nextToken.Type == TokenType.LeftBracket)
                    {
                        try
                        {
                            throw new InvalidMathematicalExpressionException("Invalid mathematical expression. Right bracket cannot be directly followed by a left bracket.");
                        }
                        catch (InvalidMathematicalExpressionException e)
                        {
                            Console.WriteLine(e.Message);
                            System.Environment.Exit(1);
                        }
                    }
                    if (nextToken.Type == TokenType.Operand)
                    {
                        try
                        {
                            throw new InvalidMathematicalExpressionException("Invalid mathematical expression. Right bracket cannot be directly followed by an operand.");
                        }
                        catch (InvalidMathematicalExpressionException e)
                        {
                            Console.WriteLine(e.Message);
                            System.Environment.Exit(1);
                        }
                    }
                    break;
            }           
        }

        public static void ValidateBrackets(int operatorsStackCount)
        {
            if (operatorsStackCount == 0)
            {
                try
                {
                    throw new InvalidMathematicalExpressionException("Missmatched brackets");
                }
                catch (InvalidMathematicalExpressionException e)
                {
                    Console.WriteLine(e.Message);
                    System.Environment.Exit(1);
                }
            }
        }
    }
}
