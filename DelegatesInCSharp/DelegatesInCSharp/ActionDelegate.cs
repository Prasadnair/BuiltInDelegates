using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    internal class ActionDelegate
    {

        public static void TestActionDelegate()
        {
            Action<int,int> printSum = (a,b) => Console.WriteLine(a+b);

            printSum(10,10);
        }
    }
}
