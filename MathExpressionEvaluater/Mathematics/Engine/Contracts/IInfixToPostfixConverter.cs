using System.Collections.Generic;

namespace Mathematics.Engine.Contracts
{
    internal interface IInfixToPostfixConverter
    {
        IEnumerable<string> ConvertInfixToPostix(string[] tokens);
    }
}
