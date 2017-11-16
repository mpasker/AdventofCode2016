using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCodeTests
{
    public class Any
    {
        private static readonly Random Random = new Random();
        public static int Number()
        {
            return Random.Next();
        }
    }
}
