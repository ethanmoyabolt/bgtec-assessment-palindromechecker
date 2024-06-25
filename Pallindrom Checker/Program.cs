using System;

namespace PalindromeChecker
{
    public class Program
    {


        public static void Main(string[] args)
        {
            bool again = true;

            while (again) {

                //Request input from user and gather it, x closes the application
                Console.WriteLine("Please enter a Palindrome, enter x to exit ");
                Console.WriteLine();

                string palindrome = Console.ReadLine();

                if (palindrome == "x")
                {
                    again = false;
                }

                // Catch if a null value is inputted
                else if(palindrome == "")
                {
                    Console.WriteLine("Error no value entered");
                }

                // write result of test
                else
                {
                    CheckPalindromeFunction checkPalindromeFunction = new CheckPalindromeFunction();
                    bool pallindromeChecker = checkPalindromeFunction.IsPalindrome(palindrome);

                    if (pallindromeChecker)
                    {
                        Console.WriteLine("This is a palindrome");
                    }
                    else
                    {
                        Console.WriteLine("This is not a palindrome");

                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
