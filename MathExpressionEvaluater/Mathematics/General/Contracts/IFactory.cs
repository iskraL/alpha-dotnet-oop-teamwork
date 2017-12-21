using Mathematics.Operations.Contracts;

namespace Mathematics.General.Contracts
{
    internal interface IFactory
    {
        IOperation CreateAdditionOperation();
        IOperation CreateMultiplicationOperation();
        IOperation CreateDivisionOperations();
        IOperation CreateSubractionOperation();
        IOperation CreateBitwiseANDOperation();
        IOperation CreateBitwiseExclusiveOROperation();
        IOperation CreateBitwiseInclusiveOROperation();
        IOperation CreateBiwiseLeftShiftOperation();
        IOperation CreateBiwiseRightShiftOperation();
        IOperation CreateModuloOperation();
    }
}
