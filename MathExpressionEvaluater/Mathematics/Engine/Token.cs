using Mathematics.General.Models;
using Mathematics.Operations.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics.Engine
{
    internal class Token
    {
        private int value;
        private OperationAssociativity associativity;
        private int precedence;

        public Token()
        {
            this.Associativity = associativity;
            this.Precedence = precedence;
        }

        public string Value { get; set; }
        public string OperatorSymbol { get; private set; }
        public int ParametersCount { get; private set; }//Can be used if unary operations are added
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
                        token.Associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "-":
                        token.OperatorSymbol = "-";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "/":
                        token.OperatorSymbol = "/";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "*":
                        token.OperatorSymbol = "*";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "%":
                        token.OperatorSymbol = "%";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "&":
                        token.OperatorSymbol = "&";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "|":
                        token.OperatorSymbol = "|";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case "<<":
                        token.OperatorSymbol = "<<";
                        token.associativity = OperationAssociativity.LeftToRight;
                        token.Value = str;
                        break;
                    case ">>":
                        token.OperatorSymbol = ">>";
                        token.associativity = OperationAssociativity.LeftToRight;
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
