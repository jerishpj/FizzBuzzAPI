using JerishPJ.FizzBuzz.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace JerishPJ.FizzBuzz.Services
{
    public class FizzBuzzLogicProcessor : IFizzBuzzLogicProcessor
    {
        public IEnumerable<string> GetFizzBuzzSeries(int limit)
        {
            IList<string> fizzbuzzList = new List<string>();

            string fizzBuzzNumber = string.Empty;

            for (int index = 1; index <= limit; index++)
            {
                if (index % 3 == 0)
                    fizzBuzzNumber += "fizz";
                if (index % 5 == 0)
                    fizzBuzzNumber += "buzz";
                if (string.IsNullOrWhiteSpace(fizzBuzzNumber))
                    fizzBuzzNumber = index.ToString();

                fizzbuzzList.Add(fizzBuzzNumber);
                fizzBuzzNumber = string.Empty;
            }

            return fizzbuzzList;
        }
    }
}
