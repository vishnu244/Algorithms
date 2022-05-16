using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblems
{
    public class GuesstheNumber
    {
        public void Guess()
        {
            Console.WriteLine("Please enter the high value:");
            int high = Convert.ToInt32(Console.ReadLine());
            int low = 0;
            int mid;
            while (low != high)
            {
                mid = (high + low) / 2;
                Console.WriteLine("Enter 1 if number is between {0} and {1}", low, mid);
                Console.WriteLine("Enter 2 if number is between {0} and {1}", (mid + 1), high);
                int option = Convert.ToInt32(Console.ReadLine());
                mid = (low + high) / 2;
                if (option == 1)
                {
                    high = mid;
                }
                else if (option == 2)
                {
                    low = mid + 1;
                }
            }
            Console.WriteLine("The number you guessed is {0}", low);

        }

    }
}
