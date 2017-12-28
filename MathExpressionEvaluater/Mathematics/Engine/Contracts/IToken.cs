using Mathematics.Operations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine.Contracts
{
    internal interface IToken
    {
        string Value { get; set;}
        int ParametersCount { get;}//Can be used if unary operations are added
        TokenType Type { get;}
        OperationAssociativity Associativity { get;}
    }
}
