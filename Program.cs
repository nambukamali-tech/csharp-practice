using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Word:");
            string word = Console.ReadLine();
            string rev = "";
            for(int i = word.Length-1; i>=0; i--)
            {
                rev += word[i];
            }
            if(word == rev)
            {
                Console.WriteLine($"The word {word} is palindrome {rev}");
            }
            else
            {
                Console.WriteLine("Not palindrome");
            }
                Console.ReadKey();

        }
    }
}
