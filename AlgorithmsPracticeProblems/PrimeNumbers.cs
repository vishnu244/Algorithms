using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblems
{
    public class PrimeNumbers
    {
        public void primeNumber()
        {
            int num, i, count, start, end;


            Console.Write("Input starting number of range: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", start, end);

            for (num = start; num <= end; num++)
            {
                count = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                        break;
                    }
                    
                }
                if (count == 0 && num != 1)

                    Console.Write("{0} ", num);

            }
            Console.WriteLine("\n");
        }
    }
}
