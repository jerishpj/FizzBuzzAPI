using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;

namespace JerishPJ.FizzBuzz.Services.BusinessLogic
{
    public class FizzCalculation : ICalculateItem
    {
        const int divisorForCalculation = 3;

        const string fizzDisplay = "fizz";
        public string Calculate(int inputNumber)
        {
            if (inputNumber % divisorForCalculation == 0)
            {
                return fizzDisplay;
            }

            return string.Empty;
        }
    }
}
