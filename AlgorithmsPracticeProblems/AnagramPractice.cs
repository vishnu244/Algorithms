using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblems
{
    public class AnagramPractice
    {
        public bool AnagramDetector(string FirstWord, string SecondWord)
        {

            if (FirstWord.Length != SecondWord.Length)
            {
                Console.WriteLine("Please enter two strings of same length!");
                return false;
            }
            char[] FirstCharArray = FirstWord.ToLower().ToCharArray();
            char[] SecondCharArray = SecondWord.ToLower().ToCharArray();
            Array.Sort(FirstCharArray);
            Array.Sort(SecondCharArray);
            for (int i = 0; i < FirstCharArray.Length; i++)
            {
                if (FirstCharArray[i] != SecondCharArray[i])
                    return false;
            }
            return true;
        }
    }
}
