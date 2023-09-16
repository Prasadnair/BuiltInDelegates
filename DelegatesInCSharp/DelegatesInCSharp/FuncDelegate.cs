using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    internal class FuncDelegate
    {
        public static void TestFuncDelegate()
        {
            Func<int, int,int> sum = (a,b) => a + b;
            int total= sum(20, 20);
            Console.WriteLine(total);

        }
    }
}
