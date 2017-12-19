namespace Mathematics.Operands.Contracts
{
    public interface IOperand<T>
    {
        T Value { get; set; }
    }
}
