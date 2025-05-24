//using NUnit.Framework;
//using System;
//using System.IO;
using lab2;
namespace Palindrome.Tests
{
    public class Tests
    {
        private StringWriter _consoleError;
        private StringReader _consoleInput;

        [SetUp]
        public void Setup()
        {
            _consoleError = new StringWriter();
            Console.SetError(_consoleError);
        }

        [TearDown]
        public void TearDown()
        {
            _consoleError.Dispose();
        }

        [Test]
        public void ValidPalindrome()
        {
            var palindrome = new Palindrome();
            string input = "radar";

            int result = palindrome.CheckPalindrome(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void InputWithSpace()
        {
            var palindrome = new Palindrome();
            string input = "ra dar";

            int result = palindrome.CheckPalindrome(input);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void NonPalindrome()
        {
            var palindrome = new Palindrome();
            string input = "rad";

            int result = palindrome.CheckPalindrome(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void ValidInput_True()
        {
            _consoleInput = new StringReader("radar\n");
            Console.SetIn(_consoleInput);

            int exitCode = Program.Main(new string[] { });

            Assert.That(exitCode, Is.EqualTo(0));
        }

        [Test]
        public void InputWithSpace_Error()
        {
            _consoleInput = new StringReader("ra dar\n");
            Console.SetIn(_consoleInput);

            int exitCode = Program.Main(new string[] { });
            string error = _consoleError.ToString();

            Assert.That(exitCode, Is.EqualTo(1));
            Assert.That(error, Does.Contain("Input contains spaces."));
        }

        [Test]
        public void NotPalindrome_False()
        {
            _consoleInput = new StringReader("hello\n");
            Console.SetIn(_consoleInput);

            int exitCode = Program.Main(new string[] { });

            Assert.That(exitCode, Is.EqualTo(0));
        }
    }
}

