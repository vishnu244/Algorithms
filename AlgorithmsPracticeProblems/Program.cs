// See https://aka.ms/new-console-template for more information
using AlgorithmsPracticeProblems;

Console.WriteLine("Welcome to Algorithms practice problems!");

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