/*
LCM and HCF from Coding Challenges
by Silvio Duka

Last modified date: 2018-02-25 

LCM is the least common multiple of a set of numbers. 
HCF is the highest common factor of a set of numbers. 

Consider 10 and 15: 
Multiples of 10 are: 10, 20, 30, 40, ... 
Multiples of 15 are: 15, 30, 45, 60, ... 
=> 30 is the LCM of 10 and 15. 

Factors of 10 are: 1, 2, 5, 10 
Factors of 15 are: 1, 3, 5, 15 
=> 5 is the HCF of 10 and 15. 

Tasks: 
(Easy) Write a program to find the LCM and HCF of 2 numbers. 
(Medium) Write a program to find the LCM and HCF of 3 numbers. 
(Hard) Write a program to find the LCM and HCF of 4 or more numbers.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMandHCFMedium
{
    class Program
    {
        static int number1 = 10; //Insert a first number
        static int number2 = 15; //Insert a second number
        static int number3 = 20; //Insert a third number

        static void Main(string[] args)
        {
            Console.WriteLine($"The LCM of [{number1},{number2},{number3}] is {LCM()}");
            Console.WriteLine($"The HCF of [{number1},{number2},{number3}] is {HCF()}");
        }

        static int LCM()
        {
            int number = (number1 < number2) ? ((number1 < number3) ? number1 : number3) : number2;
            
            long multipliedAll = number1 * number2 * number3;

            for (int i = number; i < multipliedAll + 1; i += number)
            {
                int t = i % number1 + i % number2 + i % number3;

                if (t == 0) return i;
            }

            return 0;
        }

        static int HCF()
        {
            int number = (number1 < number2) ? ((number1 < number3) ? number1 : number3) : number2;

            for (int i = number; i > 0; i--)
            {
                int t = number1 % i + number2 % i + number3 % i;

                if (t == 0) return i;
            }

            return 0;
        }
    }
}