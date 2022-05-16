// See https://aka.ms/new-console-template for more information
using AlgorithmsPracticeProblems;

Console.WriteLine("Welcome to Algorithms practice problems!");



while (true)
{
    Console.WriteLine("Please choose the option :\n1)Anagram\n2)Binary Search\n3)Prime Numbers ini range\n4)Bubble Sorting\n5)Insertion Sorting\n6)Merge Sorting\n7)Guess the Number\n8)BinarySearch using Generics");
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
        case 3:
            PrimeNumbers primeNumbers = new PrimeNumbers();
            primeNumbers.primeNumber();
            break;
        case 4:
            BubbleSorting b = new BubbleSorting();
            b.BSort();
            break;
        case 5:
            InsertionSorting insertionSorting = new InsertionSorting();
            insertionSorting.Insertion_Sort();
            break;
        case 6:
            MergeSort merge = new MergeSort();
            int n = 8;
            int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
            Console.WriteLine("Merge Sort");
            Console.Write("Initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            merge.MergeSort1(array, 0, n - 1);
            Console.Write("\nSorted Array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            break;
        case 7:
            GuesstheNumber guesstheNumber = new GuesstheNumber();
            guesstheNumber.Guess();
            break;
        case 8:

            BinarySearchUsingGenerics<int> bs1 = new();
            int[] arr1 = { 11,22,33,44,55,66};
            foreach (int s in arr1)
            {
                Console.WriteLine(s);
            }
            Array.Sort(arr1);
            Console.WriteLine("Please enter the Number to be searched :");
            int key1 = Convert.ToInt32(Console.ReadLine());
            int result1 = bs1.binary_search_iterative(arr1, key1);
            if (result1 == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index " + result1); 
            
            break;

    }
}

