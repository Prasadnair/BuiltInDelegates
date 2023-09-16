using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesInCSharp
{
    internal class PredicateDelegate
    {
        public static void TestPredicateDelegate()
        {
            Predicate<int> isEven = (a) => a % 2 == 0;

            // Using the Predicate to filter a list of numbers
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<int> evenNumbers = numbers.FindAll(isEven);

            Console.WriteLine(string.Join(", ", evenNumbers));

        }
    }
}
