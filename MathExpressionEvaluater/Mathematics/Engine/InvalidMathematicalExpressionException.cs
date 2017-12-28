namespace Mathematics.Engine
{
    using System;

    internal class InvalidMathematicalExpressionException : Exception
    {
        public InvalidMathematicalExpressionException(string message) :base(message)
        {
        }
    }
}
