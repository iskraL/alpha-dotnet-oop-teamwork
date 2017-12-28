namespace Mathematics.Operations.Models
{
    using Mathematics.Operations.Enums;

    internal abstract class BinaryOperation : Operation
    {
        protected BinaryOperation() : 
            base(OperationAssociativity.LeftToRight)
        {

        }

        public override bool IsComplete => this.Operands.Count == 2;
    }
}
