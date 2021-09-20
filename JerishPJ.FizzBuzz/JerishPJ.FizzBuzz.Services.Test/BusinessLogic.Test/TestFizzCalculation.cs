using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;
using JerishPJ.FizzBuzz.Services.BusinessLogic;
using Xunit;

namespace JerishPJ.FizzBuzz.Services.Test.BusinessLogic.Test
{
    public class TestFizzCalculation
    {
        private readonly ICalculateItem _calculateItem;

        public TestFizzCalculation()
        {
            _calculateItem = new FizzCalculation();
        }

        [Theory]
        [InlineData(1, "")]
        [InlineData(5, "")]
        [InlineData(9, "fizz")]
        [InlineData(15, "fizz")]
        public void TestCalulateReturnsResult(int inputNumber, string expectedResult)
        {
            Assert.Equal(expectedResult, _calculateItem.Calculate(inputNumber));
        }
    }
}
