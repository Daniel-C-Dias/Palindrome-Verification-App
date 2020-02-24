namespace PalindromeVerificationApp
{
    public class PalindromeVerificator
    {
        public bool IsPalindrome(string input)
        {

            var length = input.Length;
            var halfLength = length / 2;

            for (var i = 0; i < halfLength; i++)
            {
                if (input[i] != input[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
