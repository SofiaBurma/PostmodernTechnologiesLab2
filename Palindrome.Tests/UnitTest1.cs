namespace Palindrome.Tests
{
    public class Tests
    {
       
        [Test]
        public void Test1()
        {
            // Arrange
            var palindrome = new Palindrome();
            string input = "radar";

            // Act
            int result = palindrome.CheckPalindrome(input);

            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Test2()
        {
            var palindrome = new Palindrome();
            string input = "ra dar";

            int result = palindrome.CheckPalindrome(input);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test3()
        {
            var palindrome = new Palindrome();
            string input = "rad";

            int result = palindrome.CheckPalindrome(input);

            Assert.That(result, Is.EqualTo(0));
        }
    }
}
