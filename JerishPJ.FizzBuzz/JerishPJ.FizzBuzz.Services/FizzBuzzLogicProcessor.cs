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

        // refactor: GenerateFizzBuzzSeries method
        public IEnumerable<string> GenerateFizzBuzzSeries(int limit)
        {
            var fizzbuzzList = new List<string>();

            for (int index = 1; index <= limit; index++)
            {
                var resultBuilder = new System.Text.StringBuilder();

                foreach (var calculateItem in _calculateItems)
                {
                    resultBuilder.Append(calculateItem.Calculate(index));
                }

                var result = resultBuilder.ToString();
                fizzbuzzList.Add(string.IsNullOrEmpty(result) ? index.ToString() : result);
            }

            return fizzbuzzList;
        }
    }
}
