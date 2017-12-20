using Mathematics.Operands.Contracts;
using Mathematics.Operations.Contracts;

namespace Mathematics.Core.Contracts
{
    internal interface IFactory
    {
        IOperation<int> CreateIntAdditionOperation();
        IOperation<decimal> CreateDecimalAdditionOperation();

        IOperation<int> CreateIntSubstractionOperation();
        IOperation<decimal> CreateDecimalSubstractionOperation();

        IOperation<int> CreateIntDivisionOperation();
        IOperation<decimal> CreateDecimalDivisionOperation();

        IOperation<int> CreateIntMultiplicationOperation();
        IOperation<decimal> CreateDecimalMultiplicationOperation();

        IOperand<int> GetIntTypeOperand(int num);
        IOperand<decimal> GetDecimalTypeOperand(decimal num);
    }
}
