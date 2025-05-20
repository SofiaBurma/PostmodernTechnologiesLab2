//using NUnit.Framework;
//using System;
//using System.IO;
using lab2;
namespace Palindrome.Tests
{
    public class Tests
    {
        private StringWriter _consoleOutput;
        private StringWriter _consoleError;
        private StringReader _consoleInput;

        [SetUp]
        public void Setup()
        {
            _consoleOutput = new StringWriter();
            _consoleError = new StringWriter();
            Console.SetOut(_consoleOutput);
            Console.SetError(_consoleError);
        }

        [TearDown]
        public void TearDown()
        {
            _consoleOutput.Dispose();
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

            Program.Main(new string[] { });
            string output = _consoleOutput.ToString();
            string error = _consoleError.ToString();

            Assert.That(output, Does.Contain("Введіть слово для перевірки:"));
            Assert.That(output, Does.Contain("true"));
            Assert.That(error, Is.Empty);
        }

        [Test]
        public void InputWithSpace_Error()
        {
            _consoleInput = new StringReader("ra dar\n");
            Console.SetIn(_consoleInput);

            Program.Main(new string[] { });
            string output = _consoleOutput.ToString();
            string error = _consoleError.ToString();

            Assert.That(output, Does.Contain("Введіть слово для перевірки:"));
            Assert.That(output, Does.Not.Contain("true").And.Not.Contain("false"));
            Assert.That(error, Does.Contain("Input contains spaces."));
        }

        [Test]
        public void NotPalindrome_False()
        {
            _consoleInput = new StringReader("hello\n");
            Console.SetIn(_consoleInput);

            Program.Main(new string[] { });
            string output = _consoleOutput.ToString();
            string error = _consoleError.ToString();

            Assert.That(output, Does.Contain("false"));
            Assert.That(error, Is.Empty);
        }
    }
}

