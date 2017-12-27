using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine
{
    internal class InvalidMathematicalExpressionException : Exception
    {
        public InvalidMathematicalExpressionException(string message) :base(message)
        {
        }
    }
}
