using System;
using Mathematics.Core.Contracts;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Models;

namespace Mathematics.Core.Engine
{
    internal class Factory : IFactory
    {
        public IOperation<int> CreateIntAdditionOperation()
        {
            return new IntAddition();
        }

        public IOperation<decimal> CreateDecimalAdditionOperation()
        {
            return new DecimalAddition();
        }

        public IOperation<int> CreateIntSubstractionOperation()
        {
            throw new NotImplementedException();
        }

        public IOperation<decimal> CreateDecimalSubstractionOperation()
        {
            throw new NotImplementedException();
        }

        public IOperation<int> CreateIntDivisionOperation()
        {
            throw new NotImplementedException();
        }

        public IOperation<decimal> CreateDecimalDivisionOperation()
        {
            throw new NotImplementedException();
        }

        public IOperation<int> CreateIntMultiplicationOperation()
        {
            throw new NotImplementedException();
        }

        public IOperation<decimal> CreateDecimalMultiplicationOperation()
        {
            throw new NotImplementedException();
        }

        public IOperand<int> GetIntTypeOperand(int num)
        {
            return new IntType(num);
        }

        public IOperand<decimal> GetDecimalTypeOperand(decimal num)
        {
            throw new NotImplementedException();
        }
    }
}
