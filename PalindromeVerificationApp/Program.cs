namespace PalindromeVerificationApp
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Insert String: ");

            var palindromeVerificator = new PalindromeVerificator();

            var consoleInput = Console.ReadLine();

            var isStringPalindrome = palindromeVerificator.IsPalindrome(consoleInput);

            Console.WriteLine(isStringPalindrome
                ? $"{consoleInput} is a Palindrome"
                : $"{consoleInput} is not a Palindrome");

            Console.ReadKey(true);
        }
    }
}
