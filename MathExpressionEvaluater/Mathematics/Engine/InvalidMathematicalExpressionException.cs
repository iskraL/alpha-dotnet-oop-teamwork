using Mathematics.General.Models;

namespace Mathematics.Engine
{
    using System;

    public class InvalidMathematicalExpressionException : Exception
    {
        private const string ErrorMessage = ErrorMessages.InvalidMathExpression;

        public InvalidMathematicalExpressionException()
            : this(ErrorMessage)
        {
            
        }

        public InvalidMathematicalExpressionException(string message) 
            : base(message)
        {

        }
    }
}
