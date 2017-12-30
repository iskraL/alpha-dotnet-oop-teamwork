namespace Mathematics.Engine
{
    using System;
    using Mathematics.Engine.Contracts;
    using Mathematics.General.Models;

    public class ExpressionParser : IExpressionParser
    {
        private const char WhiteSpace = ' ';

        public string[] Parse(string expression)
        {
            return CleanExpressionInput(expression)
                .Split(new[] {WhiteSpace}, StringSplitOptions.RemoveEmptyEntries);
        }

        private string CleanExpressionInput(string expression)
        {
            foreach (var operation in Table.Operations.Keys)
            {
                expression = expression.Replace(operation, $" {operation} ");
            }

            expression = expression
                .Replace("(", " ( ")
                .Replace(")", " ) ");

            return expression;
        }
    }
}