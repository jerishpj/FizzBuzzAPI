using JerishPJ.FizzBuzz.Services.Abstractions;
using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;
using System.Collections.Generic;

namespace JerishPJ.FizzBuzz.Services
{
    public class FizzBuzzLogicProcessor : IFizzBuzzLogicProcessor
    {
        private readonly IEnumerable<ICalculateItem> _calculateItems;

        public FizzBuzzLogicProcessor(IEnumerable<ICalculateItem> calculateItems)
        {
            _calculateItems = calculateItems;
        }

        public IEnumerable<string> GenerateFizzBuzzSeries(int limit)
        {
            IList<string> fizzbuzzList = new List<string>();

            string fizzBuzzNumber = string.Empty;

            for (int index = 1; index <= limit; index++)
            {
               foreach(var calculateItem in _calculateItems)
                {
                    fizzBuzzNumber += calculateItem.Calculate(index);
                }

                if (string.IsNullOrEmpty(fizzBuzzNumber)) fizzBuzzNumber = index.ToString();

                fizzbuzzList.Add(fizzBuzzNumber);
                fizzBuzzNumber = string.Empty;
            }

            return fizzbuzzList;
        }
    }
}
