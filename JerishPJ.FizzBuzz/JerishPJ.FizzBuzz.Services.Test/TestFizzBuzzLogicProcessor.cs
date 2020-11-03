using JerishPJ.FizzBuzz.Services.Abstractions;
using System.Collections.Generic;
using Xunit;

namespace JerishPJ.FizzBuzz.Services.Test
{
    public class TestFizzBuzzLogicProcessor
    {
        private readonly IFizzBuzzLogicProcessor fizzBuzzLogicProcessor;
        private readonly Dictionary<int, IEnumerable<string>> expectedResults;

        public TestFizzBuzzLogicProcessor()
        {
            fizzBuzzLogicProcessor = new FizzBuzzLogicProcessor();
            expectedResults = new Dictionary<int, IEnumerable<string>>();
            SetExpectedResults();
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        public void TestGetFizzBuzzSeriesShouldReturnsCorrectSeries(int limit)
        {
            var result = fizzBuzzLogicProcessor.GetFizzBuzzSeries(limit);
            Assert.Equal(expectedResults[limit], result);
        }

        private void SetExpectedResults()
        {
            expectedResults.Add(2, new List<string>() { "1", "2" });
            expectedResults.Add(5, new List<string>() { "1", "2", "fizz", "4", "buzz" });
        }
    }
}
