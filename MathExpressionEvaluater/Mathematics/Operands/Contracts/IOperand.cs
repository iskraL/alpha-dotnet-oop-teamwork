namespace Mathematics.Operands.Contracts
{
    internal interface IOperand<T>
    {
        T Value { get; set; }
    }
}
