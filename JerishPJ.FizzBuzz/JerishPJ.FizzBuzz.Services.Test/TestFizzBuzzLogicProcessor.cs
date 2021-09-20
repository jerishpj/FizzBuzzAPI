using JerishPJ.FizzBuzz.Services.Abstractions;
using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;
using JerishPJ.FizzBuzz.Services.BusinessLogic;
using System.Collections.Generic;
using Xunit;

namespace JerishPJ.FizzBuzz.Services.Test
{
    public class TestFizzBuzzLogicProcessor
    {
        private readonly IFizzBuzzLogicProcessor _fizzBuzzLogicProcessor;

        private readonly Dictionary<int, IEnumerable<string>> _expectedResults;

        public TestFizzBuzzLogicProcessor()
        {
            IEnumerable<ICalculateItem> calculateItems = new List<ICalculateItem>()
            {
                new FizzCalculation(),
                new BuzzCalculation()
            };
            _fizzBuzzLogicProcessor = new FizzBuzzLogicProcessor(calculateItems);
            _expectedResults = new Dictionary<int, IEnumerable<string>>();
            SetExpectedResults();
        }

        private void SetExpectedResults()
        {
            _expectedResults.Add(-1, new List<string>());
            _expectedResults.Add(0, new List<string>());
            _expectedResults.Add(2, new List<string>() { "1", "2" });
            _expectedResults.Add(5, new List<string>() { "1", "2", "fizz", "4", "buzz" });
            _expectedResults.Add(15, new List<string>() { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" });
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(15)]
        public void TestGetFizzBuzzSeriesShouldReturnsCorrectSeries(int limit)
        {
            var result = _fizzBuzzLogicProcessor.GenerateFizzBuzzSeries(limit);
            Assert.Equal(_expectedResults[limit], result);
        }
    }
}
