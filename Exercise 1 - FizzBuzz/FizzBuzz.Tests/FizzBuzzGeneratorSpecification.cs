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
        public void returns_upperLimit_items()
        {
            var fizzbuzz = new FizzBuzzGenerator();

            Assert.That(fizzbuzz.FizzBuzz(10).Count(), Is.EqualTo(10), "Expected FizzBuzz( 10 ) to return 10 items"); 
        }

        [Test]
        public void returns_no_items_for_zero()
        {
            Assert.That(GenerateFizzBuzz(0), Is.Empty, "Expected FizzBuzz( 0 ) to return empty enumeration");
        }

        [Test]
        public void returns_no_items_for_negative_upperLimit()
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
