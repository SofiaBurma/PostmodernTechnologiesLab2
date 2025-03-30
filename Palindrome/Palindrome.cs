namespace Palindrome
{
    public class Palindrome
    {
        public int CheckPalindrome(string input)
        {
            if (input.Contains(" "))
            {
                Console.Error.WriteLine("Input contains spaces.");
                return 1;
            }

            string reversed = new string(input.Reverse().ToArray());
            if (input == reversed)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            return 0;
        }

    }
}
