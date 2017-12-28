namespace Mathematics.Engine.Contracts
{
    using Mathematics.Operations.Enums;

    internal interface IToken
    {
        string Value { get; set;}
        int ParametersCount { get;}//Can be used if unary operations are added
        TokenType Type { get;}
        OperationAssociativity Associativity { get;}
    }
}
