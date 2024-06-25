using System.Text.RegularExpressions;

namespace PalindromeChecker
{
    public class CheckPalindromeFunction
    {
        public bool IsPalindrome(string palindrome)
        {
            bool palindromeChecker = true;

            // First checks value is not null
            if (palindrome == "" || palindrome == null)
            {
                return palindromeChecker = false;
            }

            // Then remove any whitespaces
            palindrome = palindrome.Replace(" ", "");

            // Then remove all punctuation and special characters using Regex
            // [^a-zA-Z0-9] this refers to any characters that are not letters or digits
            palindrome = Regex.Replace(palindrome, @"[^a-zA-Z0-9]", "");


            // Then change string to lowercase to disregard case
            palindrome = palindrome.ToLower();


            // By default all strings of length 1 are pallindromes
            if (palindrome.Length == 1)
            {
                return palindromeChecker;
            }


            // Palindromes of odd and even lengths are considered seperately as they will have slightly different properties
            if (palindrome.Length % 2 == 0)
            {
                // Palindromes of even length must have the middle 2 letters be identical so this is checked first
                if (palindrome[palindrome.Length / 2] != palindrome[(palindrome.Length / 2) - 1])
                {
                    palindromeChecker = false;
                }
                else
                {
                    for (int i = 0; i < palindrome.Length / 2; i++)
                    {
                        //Each character on each side of the palindrome is compared to determine if they are equal.
                        if (palindrome[i] != palindrome[(palindrome.Length - 1) - i])
                        {
                            palindromeChecker = false;
                            // breaks  as soon as 2 characters do not match in order to leave the for loop
                            break;
                        }
                    }
                }

            }
            else
            {
                //Palindromes of equal length must disregard the middle letter and consider the letters on both sides.
                for (int i = 0; i < ((palindrome.Length - 1) / 2); i++)
                {
                    if (palindrome[i] != palindrome[(palindrome.Length - 1) - i])
                    {
                        palindromeChecker = false;
                        break;
                    }
                }
            }

            return palindromeChecker;
        }

    }
}
