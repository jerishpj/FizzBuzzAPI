using JerishPJ.FizzBuzz.Services.Abstractions.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace JerishPJ.FizzBuzz.Services.BusinessLogic
{
    public class WizzCalculation : ICalculateItem
    {
        const int divisorForCalculation = 2;

        const string fizzDisplay = "wizz";
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
