using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    public class VowelConsonant
    {
        public static void CheckVowelConsonant()
        {
            Console.WriteLine("Enter the character");

            char A = Convert.ToChar(Console.ReadLine());

            if (A == 'a' || A == 'e' || A == 'i' || A == 'o' || A == 'u' || A == 'A' || A == 'E' || A == 'I' || A == 'O' || A == 'U')
            {
                Console.WriteLine(A + " is Vowel");
            }
            else if (( A >= 'a' && A <= 'z') || (A >= 'A' && A <= 'Z'))
            {
                Console.WriteLine(A + "  is Consonant");
            }

            else
            {
                Console.WriteLine("Please Enter a valid character");
            }
        }
    }
}
