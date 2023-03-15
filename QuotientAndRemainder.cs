using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class QuotientAndRemainder
    {
        public static void FindQuotientRemainder()
        {
            int dividend, divisor;

            Console.WriteLine("Enter a value for dividend");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a value for divisor");
            divisor = Convert.ToInt32(Console.ReadLine());


            int remainder = dividend % divisor;
            int Quotient = dividend / divisor;

            Console.WriteLine("dividend " + dividend + " and divisor " + divisor);
            Console.WriteLine("the quotient is " + Quotient + " and the remainder is " + remainder);
        }
    }
}
