using System;

namespace Mathematics
{
    public class Startup
    {
        static void Main()
        {
            string expression = Console.ReadLine();
            Expression e = new Expression();
            Console.WriteLine(e.Evaluate(expression));
        }
    }
}