using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INMAR_OnlineTest_ConsoleApp
{
  static  class NumberDivisable
    {
        public static void NumberDivise()
        {

            //If the number is divisible by 3, print “fizz
            //If divisible by 5 print “buzz”
            //  If divisible by 3 & 5, print “fizzbuzz

            int iMaxNumber = 100;
            for (int i = 0; i <= 100; i++)
            {
                if (i > iMaxNumber)
                    break;
                if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    continue;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    continue;
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
            }

            Console.ReadLine();
        }
    }
}
