using System.Collections.Generic;
using JerishPJ.FizzBuzz.Services.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace JerishPJ.FizzBuzz.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzLogicProcessor _fizzBuzzLogicProcessor;
        private readonly FizzBuzzSettings _settings;

        public FizzBuzzController(IFizzBuzzLogicProcessor fizzBuzzLogicProcessor, IOptions<FizzBuzzSettings> options)
        {
            _fizzBuzzLogicProcessor = fizzBuzzLogicProcessor;
            _settings = options.Value;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            IList<string> fizzbuzzList = (IList<string>)_fizzBuzzLogicProcessor.GenerateFizzBuzzSeries(_settings.MaxNumber);

            return fizzbuzzList;
        }

        [HttpGet("max-number")]
        public IActionResult GetMaxNumber()
        {
            return Ok(_settings.MaxNumber);
        }
    }
}
