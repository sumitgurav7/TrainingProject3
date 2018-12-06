using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject3
{
    

    
    class CheckingWord
    {

        public delegate void PalindromeChecker(string ResultMessage);//delegate for Palindrome raising
        public event PalindromeChecker PalindromeEvent;//event based upon above mentioned delegate

        public void CheckIfPalindrome(string word)
        {
            if(word == ReversedString(word)) {
                OnPalindrome(word + " is palindrome");
            }

            else
            {
                OnPalindrome(word + " is not palindrome");
            }
        }

        private string ReversedString(string word)
        {
            char[] arrayOfChar = word.ToCharArray();
            Array.Reverse(arrayOfChar);
            return new string(arrayOfChar);
        }

        public void OnPalindrome(string ResultMessage)
        {
            if(PalindromeEvent != null)
            {
                PalindromeEvent(ResultMessage);
            }
        }
    }
}
