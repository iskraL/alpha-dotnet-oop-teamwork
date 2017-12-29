namespace Mathematics.Engine
{
    using System;

    internal class InvalidMathematicalExpressionException : Exception
    {
        private const string IvalidMathematicalExpressionMessage = "Ivalid mathematical expression!";

        public InvalidMathematicalExpressionException()
            : this(IvalidMathematicalExpressionMessage)
        {
            
        }

        public InvalidMathematicalExpressionException(string message) 
            : base(message)
        {

        }
    }
}
