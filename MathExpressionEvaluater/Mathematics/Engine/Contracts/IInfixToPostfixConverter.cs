using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine.Contracts
{
    internal interface IInfixToPostfixConverter
    {
        Token[] Tokenize(string expression);
        Queue<Token> ConvertInfixToPostix(Token[] tokens);
    }
}
