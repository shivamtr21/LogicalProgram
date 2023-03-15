using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class SwappingNumber
    {
        public static void SwapTheNumber()
        {
            int num1, num2;
            Console.WriteLine("Enter the 1st number for swapping");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number for swapping");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swapping a = " + num1 + " and b = " + num2);

            num1 = num1 * num2;
            num2 = num1 / num2;
            num1 = num1 / num2;

            Console.WriteLine("After swapping a = " + num1 + " and b = " + num2);

        }
    }
}
