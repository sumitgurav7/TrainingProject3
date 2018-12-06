using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 words which we need to check if it is palindrome");
            WordCollection words = new WordCollection();
            Console.WriteLine("enter first word");
            words[0] = Console.ReadLine();
            Console.WriteLine("enter second word");
            words[1] = Console.ReadLine();
            Console.WriteLine("enter third word");
            words[2] = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("check words which you have entered");
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine("index : " + i + " value: "+words[i]);
            }







            CheckingWord checkingWord = new CheckingWord();
            DisplayEvent displayEvent = new DisplayEvent();

            checkingWord.PalindromeEvent += new CheckingWord.PalindromeChecker(displayEvent.DisplayResult);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int checker = 0;
            while (checker < 3 & checker > -1)
            {
                Console.WriteLine("Enter Index no of word to be checked as palindrome");
                checker = int.Parse(Console.ReadLine());
                if (checker < 3)
                { checkingWord.CheckIfPalindrome(words[checker]); }
                else
                {
                    Console.WriteLine("wrong index !!! press any key to exit");
                }
                
            }
            Console.ReadKey();
        }
    }
}


