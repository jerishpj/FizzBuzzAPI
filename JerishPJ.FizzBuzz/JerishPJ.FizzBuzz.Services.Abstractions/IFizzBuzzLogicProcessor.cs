using System;
using System.Collections.Generic;
using System.Text;

namespace JerishPJ.FizzBuzz.Services.Abstractions
{
    public interface IFizzBuzzLogicProcessor
    {
        IEnumerable<string> GetFizzBuzzSeries(int limit);
    }
}
