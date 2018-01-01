using System;

namespace Mathematics
{
    public class Startup
    {
        static void Main()
        {
            Expression e = new Expression();

            Console.WriteLine(e.Evaluate("("));

            Console.WriteLine("5 + (-4) = " + e.Evaluate("5 + (-4)"));
            Console.WriteLine("5 + -4 = " + e.Evaluate("5 + -4"));

            Console.WriteLine("-4 * 7 = " + e.Evaluate("-4 * 7"));
            Console.WriteLine("5 + -4 * 7 = " + e.Evaluate("5 + -4 * 7"));


        }
    }
}