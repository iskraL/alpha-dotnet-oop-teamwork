using System;

namespace Mathematics
{
    public class Program
    {
        static void Main(string[] args)
        {
            Expression e = new Expression();
            Console.WriteLine(e.Evaluate("(11+11)"));           
        }
    }
}