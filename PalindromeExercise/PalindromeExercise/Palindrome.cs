using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class Palindrome
    {
        public bool IsAPalindrome(string word)
        {
            //iteration of word
            //reverse the word - hello - olleh
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                //reversed = reversed + word[i]
                reversed += word[i];
            }
            //compare original with reverse word
            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return palindrome
            
        }
    }
}
