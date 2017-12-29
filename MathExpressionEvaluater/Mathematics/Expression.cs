using System;
using Mathematics.Engine;
using Mathematics.Operands.Contracts;

namespace Mathematics
{
    class Expression
    {
        private readonly ExpressionParser parser;
        private readonly InfixToPostfixConverter postfixConverter;
        private readonly PostfixCalculator postfixCalculator;

        public Expression()
        {
            parser = new ExpressionParser();
            postfixConverter = new InfixToPostfixConverter();
            postfixCalculator = new PostfixCalculator();
        }

        public string Evaluate(string expression)
        {
            IOperand result;

            try
            {
                var infixExpression = parser.Parse(expression);
                var postfixExpression = postfixConverter.ConvertInfixToPostix(infixExpression);
                result = postfixCalculator.EvaluateExpression(postfixExpression);
            }
            catch (Exception exp)
            {
                return exp.Message;
            }

            return result.Value.ToString();
        }
    }
}