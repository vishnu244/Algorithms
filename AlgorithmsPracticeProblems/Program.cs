// See https://aka.ms/new-console-template for more information
using AlgorithmsPracticeProblems;

Console.WriteLine("Welcome to Algorithms practice problems!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Anagram\n2)Binary Search");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            AnagramPractice anagram = new();
            Console.WriteLine("Please enter the two strings to find if they are anagrams or not. :");
            string firstword = Console.ReadLine();
            string secondword = Console.ReadLine();

            if (anagram.AnagramDetector(firstword, secondword))
            {
                Console.WriteLine("Given words are Anagrams!");
            }
            else
            {
                Console.WriteLine("No! Given words are not Anagrams!");
            }
            break;
        case 2:
            
            BinarySearchWord bs = new ();
            string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            foreach (string s in arr)
            {
                Console.WriteLine(s);
            }
            Array.Sort(arr);
            Console.WriteLine("Please enter a string to be searched :");
            string key = Console.ReadLine();
            int result = bs.binary_search_iterative(arr, key);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
            Console.WriteLine(result);
            break;
    }
}

