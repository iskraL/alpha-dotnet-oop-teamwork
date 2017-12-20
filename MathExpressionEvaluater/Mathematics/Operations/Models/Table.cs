using System.Collections.Generic;

namespace Mathematics.Operations.Models
{
    static class Table
    {
        static Table()
        {
            Operations = new Dictionary<string, int>()
            {
                { "*", 5 },
                { "/", 5 },
                { "%", 5 },
                { "+", 4 },
                { "-", 4 },
                { "&", 3 },
                { "^", 2 },
                { "|", 1 }
            };
        }

        public static Dictionary<string, int> Operations { get; }
    }
}
