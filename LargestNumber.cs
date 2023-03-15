using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class LargestNumber
    {
        public static void CheckLargestNumber()
        {
            int N1, N2, N3;

            Console.WriteLine("Find the Largest Number");

            Console.WriteLine("Enter the 1st number");
            N1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 2nd number");
            N2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the 3rd number");
            N3 = Convert.ToInt32(Console.ReadLine());


            if (N1 > N2)
            {
                if(N1 > N3)
                {
                    Console.WriteLine(" 1st Number "+ N1 +" Is greater ");
                }
                else
                {
                    Console.WriteLine("3rd Number "+ N3 +" is Greater");
                }
            }

            else if(N2 > N3)
            {
                Console.WriteLine("2nd Number "+ N2 + " Is Greater");
            }

            else
            {
                Console.WriteLine("3rd Number "+ N3 +" Is Greater");
            }

        }
    }
}
