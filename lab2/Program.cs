namespace lab2
{
    public class Program
    {
        public static int Main(string[] args)
        {
            Console.Write("Введіть слово для перевірки: ");
            string input = Console.ReadLine();

            var palindrome = new Palindrome.Palindrome();
            int result = palindrome.CheckPalindrome(input);

            return result;
        }
    }
}
