using Mathematics.Operations.Enums;

namespace Mathematics.Operations.Models
{
    public abstract class BinaryOperation : Operation
    {
        protected BinaryOperation() : 
            base(OperationAssociativity.LeftToRight)
        {

        }

        public override bool IsComplete => this.Operands.Count == 2;
    }
}
