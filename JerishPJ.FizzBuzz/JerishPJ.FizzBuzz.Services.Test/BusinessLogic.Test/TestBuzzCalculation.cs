using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;
using JerishPJ.FizzBuzz.Services.BusinessLogic;
using Xunit;

namespace JerishPJ.FizzBuzz.Services.Test.BusinessLogic.Test
{
    public class TestBuzzCalculation
    {
        private readonly ICalculateItem _calculateItem;

        public TestBuzzCalculation()
        {
            _calculateItem = new BuzzCalculation();
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(5, "buzz")]
        [InlineData(9, "")]
        [InlineData(15, "buzz")]
        public void TestCalulateReturnsResult(int inputNumber, string expectedResult)
        {
            Assert.Equal(expectedResult, _calculateItem.Calculate(inputNumber));
        }
    }
}
