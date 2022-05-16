using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsPracticeProblems
{
    public class BinarySearchUsingGenerics<T> where T : IComparable
    {
        public int binary_search_iterative(T[] arr, T key)
        {
            int left = 0, right = (arr.Length - 1);

            while (left <= right)
            {
                int mid = Math.Abs((left + right) / 2);
                if (arr[mid].Equals(key))
                    return mid;
                else if (key.CompareTo(arr[mid]) > 0)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
