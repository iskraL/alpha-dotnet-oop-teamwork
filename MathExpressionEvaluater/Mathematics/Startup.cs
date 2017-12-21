using System;
using System.Data;
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
            IReversePolishNotationCalculator calc = new ReversePolishNotationCalculator();

            try
            {
                var result = calc.EvaluateRPNExpression(new [] {"11", "5", "|"});
                Console.WriteLine(result.Value);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            int x = ((5 + (4))) + (4);
        }
    }
}