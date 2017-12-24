using System;
using System.Collections.Generic;
using Mathematics.Operations.Contracts;

namespace Mathematics.General.Models
{
    static class Table
    {
        private static readonly Dictionary<string, int> operations;
        private static readonly Factory factory;

        static Table()
        {
            factory = new Factory();

            operations = new Dictionary<string, int>()
            {
                {"_", 7 },
                { "*", 6 },
                { "/", 6 },
                { "%", 6 },
                { "+", 5 },
                { "-", 5 },
                { "<<", 4 },
                { ">>", 4 },
                { "&", 3 },
                { "^", 2 },
                { "|", 1 }
            };
        }

        public static Dictionary<string, int> Operations => new Dictionary<string, int>(operations);

        public static IOperation GetOperation(string token)
        {
            switch (token)
            {
                case "+":
                    return factory.CreateAdditionOperation();
                case "-":
                    return factory.CreateSubractionOperation();
                case "*":
                    return factory.CreateMultiplicationOperation();
                case "/":
                    return factory.CreateDivisionOperations();
                case "%":
                    return factory.CreateModuloOperation();
                case "^":
                    return factory.CreateBitwiseExclusiveOROperation();
                case "|":
                    return factory.CreateBitwiseInclusiveOROperation();
                case "&":
                    return factory.CreateBitwiseANDOperation();
                case "<<":
                    return factory.CreateBiwiseLeftShiftOperation();
                case ">>":
                    return factory.CreateBiwiseRightShiftOperation();
                default:
                    throw new ArgumentException();
            }
        }

    }
}
