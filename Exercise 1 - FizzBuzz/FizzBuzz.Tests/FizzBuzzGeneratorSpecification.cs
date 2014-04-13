using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FizzBuzz;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class When_using_FizzBuzzGenerator
    {
        [Test]
        public void FizzBuzz_returns_upperLimit_items()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            Assert.That(fizzbuzz.FizzBuzz(10).Count(), Is.EqualTo(10), "Expected FizzBuzz( 10 ) to return 10 items"); 
        }

        [Test]
        public void FizzBuzz_returns_no_items_for_zero()
        {
            Assert.That(GenerateFizzBuzz(0), Is.Empty, "Expected FizzBuzz( 0 ) to return empty enumeration");
        }

        [Test]
        public void FizzBuzz_returns_no_items_for_negative_upperLimit()
        {
            Assert.That(GenerateFizzBuzz(-1), Is.Empty, "Expected FizzBuzz( -1 ) to return empty enumeration");
        }

        [Test]
        public void ToFizzBuzz_returns_Fizz_for_3()
        {
            Assert.That(ToFizzBuzz(3), Is.EqualTo("Fizz"), "Expected 3 to return \"Fizz\"");
        }

        [Test]
        public void ToFizzBuzz_returns_Fizz_for_multiple_of_3()
        {
            Assert.That(ToFizzBuzz(6), Is.EqualTo("Fizz"), "Expected 6 to return \"Fizz\"");
        }

        [Test]
        public void ToFizzBuzz_returns_Buzz_for_5()
        {
            Assert.That(ToFizzBuzz(5), Is.EqualTo("Buzz"), "Expected 5 to return \"Buzz\"");
        }

        [Test]
        public void ToFizzBuzz_returns_Buzz_for_multiple_of5()
        {
            Assert.That(ToFizzBuzz(10), Is.EqualTo("Buzz"), "Expected 10 to return \"Buzz\"");
        }

        [Test]
        public void ToFizzBuzz_returns_FizzBuzz_for_15()
        {
            Assert.That(ToFizzBuzz(15), Is.EqualTo("FizzBuzz"), "Expected 15 to return \"FizzBuzz\"");
        }

        [Test]
        public void ToFizzBuzz_returns_FizzBuzz_for_multiple_of_15()
        {
            Assert.That(ToFizzBuzz(30), Is.EqualTo("FizzBuzz"), "Expected 30 to return \"FizzBuzz\"");
        }

        [Test]
        public void FizzBuzz_generates_correct_sequence()
        {
            var expected = new[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz", "16", "17", "Fizz", "19", "Buzz", "Fizz", "22" };
            Assert.That(GenerateFizzBuzz(22), Is.EquivalentTo(expected), "Expected FizzBuzz to generate the correct sequence up to 22" );
        }

        private IEnumerable<string> GenerateFizzBuzz(int upperLimit)
        {
            var fizzBuzz = new FizzBuzzGenerator();
            return fizzBuzz.FizzBuzz(upperLimit);
        }

        private string ToFizzBuzz(int value)
        {
            var fizzBuzz = new FizzBuzzGenerator();
            return fizzBuzz.ToFizzBuzz(value);
        }
    }
}
