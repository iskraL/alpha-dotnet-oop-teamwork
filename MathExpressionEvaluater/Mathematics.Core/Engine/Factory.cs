using System;
using Mathematics.Core.Contracts;
using Mathematics.Operations.Contracts;
using Mathematics.Operations.Models;

namespace Mathematics.Core.Engine
{
    class Factory : IFactory
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
    }
}
