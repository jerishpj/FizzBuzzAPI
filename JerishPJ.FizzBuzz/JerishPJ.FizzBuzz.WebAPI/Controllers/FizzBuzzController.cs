using System.Collections.Generic;
using JerishPJ.FizzBuzz.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace JerishPJ.FizzBuzz.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzLogicProcessor _fizzBuzzLogicProcessor;

        public FizzBuzzController(IFizzBuzzLogicProcessor fizzBuzzLogicProcessor)
        {
            _fizzBuzzLogicProcessor = fizzBuzzLogicProcessor;
        }

        [HttpGet]
        public IEnumerable<string> Get(int limit = 50)
        {
            IList<string> fizzbuzzList = (IList<string>)_fizzBuzzLogicProcessor.GetFizzBuzzSeries(limit);

            return fizzbuzzList;
        }
    }
}
