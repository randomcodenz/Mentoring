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
            if (upperLimit < 1)
                return Enumerable.Empty<string>();

            return Enumerable.Range(1, upperLimit).Select(i => i.ToString());
        }
    }
}
