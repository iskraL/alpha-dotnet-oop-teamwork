using Mathematics.Operations.Contracts;

namespace Mathematics.Core.Contracts
{
    interface IFactory
    {
        IOperation<int> CreateIntAdditionOperation();
        IOperation<decimal> CreateDecimalAdditionOperation();

        IOperation<int> CreateIntSubstractionOperation();
        IOperation<decimal> CreateDecimalSubstractionOperation();

        IOperation<int> CreateIntDivisionOperation();
        IOperation<decimal> CreateDecimalDivisionOperation();

        IOperation<int> CreateIntMultiplicationOperation();
        IOperation<decimal> CreateDecimalMultiplicationOperation();
    }
}
