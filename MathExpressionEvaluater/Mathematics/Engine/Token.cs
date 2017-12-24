using Mathematics.General.Models;
using Mathematics.Operations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine
{
    class Token
    {
        private int value;
        private string operatorSymbol;
        private int parametersCount;
        private TokenType type;
        private OperationAssociativity associativity;
        private int precedence;
        public Token()
        {
            this.OperatorSymbol = operatorSymbol;
            this.ParametersCont = parametersCount;
            this.Type = type;
            this.Associativity = associativity;
            this.Precedence = precedence;
        }
        public string Value { get;  set; }
        public string OperatorSymbol { get; private set; }
        public int ParametersCont { get; private set; }
        public TokenType Type { get; private set; }
        public OperationAssociativity Associativity { get; private set; }
        public int Precedence
        {
            get
            {
                return Table.Operations[this.OperatorSymbol];
            }
            private set
            {
                this.precedence = value;
            }
        }

        public static Token StringToTokenParser(string str)
        {
            Token token = new Token();
            if(int.TryParse(str, out token.value))
            {
                token.Type = TokenType.Operand;
                token.Value = str;
            }else if (str == "(")
            {
                token.Type = TokenType.LeftBracket;
                token.Value = str;

            }
            else if (str == ")")
            {
                token.Type = TokenType.RightBracket;
                token.Value = str;
            }
            else
            {
                token.Type = TokenType.Operator;
                switch (str)
                {
                    case "+":
                        token.OperatorSymbol = "+";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.ParametersCont = 2;
                        token.Value = str;

                        break;
                    case "-":
                        token.OperatorSymbol = "-";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.ParametersCont = 2;
                        token.Value = str;

                        break;
                    case "/":
                        token.OperatorSymbol = "/";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.ParametersCont = 2;
                        token.Value = str;

                        break;
                    case "*":
                        token.OperatorSymbol = "*";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.ParametersCont = 2;
                        token.Value = str;

                        break;
                    default:
                        throw new ArgumentException("Not a valid token");
                }
            }
            return token;
        }

    }
}
