﻿using System;
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

            return Enumerable.Range(1, upperLimit).Select( ToFizzBuzz );
        }

        public string ToFizzBuzz(int value)
        {
            if (value % 15 == 0)
                return "FizzBuzz";

            if (value % 3 == 0)
                return "Fizz";

            if (value % 5 == 0)
                return "Buzz";

            return value.ToString();
        }
    }
}
