﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    class Modulo<T> : BinaryAssociativityOperation<T> where T : struct 
    {
        public Modulo()
        {
            this.Priority = OperationPriority.High;
        }

        public override T GetResult()
        {
            if (!this.IsComplete())
            {
                throw new InvalidOperationException("Not enought operands!");
            }

            return (dynamic)(this.operands[0].Value) % (dynamic)(this.operands[1].Value);
        }

        public override OperationPriority Priority { get; }
    }
}
