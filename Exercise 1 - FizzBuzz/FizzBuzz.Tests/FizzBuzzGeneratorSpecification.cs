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

        private IEnumerable<string> GenerateFizzBuzz(int upperLimit)
        {
            var fizzBuzz = new FizzBuzzGenerator();
            return fizzBuzz.FizzBuzz(upperLimit);
        }
    }
}
