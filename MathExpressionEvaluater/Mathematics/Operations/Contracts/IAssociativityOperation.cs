using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Contracts
{
    internal interface IAssociativityOperation : IOperation
    {
        OperationAssociativity Associativity { get; }
    }
}
