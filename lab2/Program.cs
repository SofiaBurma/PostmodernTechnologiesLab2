namespace lab2
{
     public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            Console.Write("Введіть слово для перевірки: ");
            input = Console.ReadLine();

            var palindrome = new Palindrome.Palindrome();
            var result = palindrome.CheckPalindrome(input);
            Console.WriteLine(result);

        }
    }
}
