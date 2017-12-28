using System;
using System.Data;
using Mathematics.Engine;
using Mathematics.Engine.Contracts;
using Mathematics.Operands.Contracts;
using Mathematics.Operands.Models;
using System.Collections;
using System.Collections.Generic;

namespace Mathematics
{
    class Startup
    {
        static void Main()
        {
            
            var tokenize = new InfixToPostfixConverter();
            Token[] arr = tokenize.Tokenize("(1+2)*(3+2)");
            
            var output = tokenize.ConvertInfixToPostix(arr);

            string[] array = new string[output.Count];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = output.Dequeue().Value;
                Console.WriteLine(array[i]);
            }
            IReversePolishNotationCalculator calc = new ReversePolishNotationCalculator();

          
          
                var result = calc.EvaluateRPNExpression(array);
                Console.WriteLine(result.Value);
          

        }
    }
}