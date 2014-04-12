using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzGenerator
    {
        public IEnumerable<string> FizzBuzz(int upperLimit)
        {
            return Enumerable.Range(1, upperLimit).Select(i => i.ToString());
        }
    }
}
