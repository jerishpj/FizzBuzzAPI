using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;

namespace JerishPJ.FizzBuzz.Services.BusinessLogic
{
    public class BuzzCalculation : ICalculateItem
    {
        const int divisorForCalculation = 5;

        const string fizzDisplay = "buzz";

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
