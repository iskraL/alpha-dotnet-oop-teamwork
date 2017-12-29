namespace Mathematics.General.Models
{
    using Contracts;
    using Operations.Contracts;
    using Operations.Models;

    internal class Factory : IFactory
    {
        public IOperation CreateAdditionOperation()
        {
            return new Addition();
        }

        public IOperation CreateMultiplicationOperation()
        {
            return new Multiplication();
        }

        public IOperation CreateDivisionOperations()
        {
            return new Division();
        }

        public IOperation CreateSubractionOperation()
        {
            return new Substraction();
        }

        public IOperation CreateBitwiseANDOperation()
        {
            return new BitwiseAND();
        }

        public IOperation CreateBitwiseExclusiveOROperation()
        {
            return new BitwiseExclusiveOR();
        }

        public IOperation CreateBitwiseInclusiveOROperation()
        {
            return new BitwiseInclusiveOR();
        }

        public IOperation CreateBiwiseLeftShiftOperation()
        {
            return new BitwiseLeftShift();
        }

        public IOperation CreateBiwiseRightShiftOperation()
        {
            return new BitwiseRightShift();
        }

        public IOperation CreateModuloOperation()
        {
            return new Modulo();
        }
    }
}
