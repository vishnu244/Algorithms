using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblems
{
    public class BubbleSorting
    {
        public void BSort()
        {
            int[] List = { 78, 43, 22, 67, 90, 34 };//Declare List
            int len = List.Length;//calculate Length of List

            Console.Write("Given List:");
            foreach (int data in List)
            {
                Console.Write("{0} ", data);

            }
            Console.WriteLine();


            int i, j, temp;
            for (i = 0; i < len; i++)
            {
                for (j = i + 1; j < len; j++)
                {
                    if (List[j] < List[i])
                    {
                        temp = List[i];
                        List[i] = List[j];
                        List[j] = temp;                       
                    }
                }               
            }

            Console.Write("Sorted List:");
            foreach (int sortdata in List)
            {
                Console.Write("{0} " , sortdata);
            }
            Console.WriteLine();

        }

    }
}
