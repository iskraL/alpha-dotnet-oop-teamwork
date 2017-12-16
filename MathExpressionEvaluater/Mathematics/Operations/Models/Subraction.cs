using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    class Subraction<T> : BinaryOperation<T> where T : struct 
    {
        public Subraction()
        {
            this.Priority = OperationPriority.MidHigh;
        }

        public override T GetResult()
        {
            if (!this.IsComplete())
            {
                throw new InvalidOperationException("Not enought operands!");
            }

            return (dynamic)(this.operands[0].Value) - (dynamic)(this.operands[1].Value);
        }

        public override OperationPriority Priority { get; }
    }
}
