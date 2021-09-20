using System.Collections.Generic;

namespace JerishPJ.FizzBuzz.Services.Abstractions
{
    public interface IFizzBuzzLogicProcessor
    {
        IEnumerable<string> GenerateFizzBuzzSeries(int limit);
    }
}
