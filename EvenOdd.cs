using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class EvenOdd
    {
        public static void CheckEvenOdd()
        {
            Console.WriteLine("Enter Number");
            int N = Convert.ToInt32(Console.ReadLine());

            if( N % 2 == 0)
            {
                Console.WriteLine(N + " is even number");
            }

            else
            {
                Console.WriteLine(N + " is odd number");
            }
        }
    }
}
