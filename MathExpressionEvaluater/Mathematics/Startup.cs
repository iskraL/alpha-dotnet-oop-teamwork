using System;
using Mathematics.Engine;
using Mathematics.Engine.Contracts;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;

namespace Mathematics
{
    class Startup
    {
        static void Main()
        {
            IRPNCalculator<int> calc = new IntRPNCalculator();

            try
            {
                //var result = calc.EvaluateRPNExpression(new[] {"111", "11", "+" });
                //Console.WriteLine(result.Value);
                //result = calc.EvaluateRPNExpression(new[] { "43", "1234", "1" });
                //Console.WriteLine(result.Value);
                var result = calc.EvaluateRPNExpression(
                    new[] { "111", "11", "56", "-987", "111", "11", "56", "-987", "+", "+", "+", "+", "+", "+", "+" });

                Console.WriteLine(result.Value);
                //result = calc.EvaluateRPNExpression(new[] {"43", "1234", "1"});
                //Console.WriteLine(result.Value);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}