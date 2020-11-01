using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace JerishPJ.FizzBuzz.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get(int limit = 50)
        {
            IList<string> fizzbuzzList = new List<string>();

            string fizzBuzzNumber = string.Empty;

            for(int index = 1; index <= limit; index++)
            {
                if (index % 3 == 0)
                    fizzBuzzNumber += "fizz";
                if (index % 5 == 0)
                    fizzBuzzNumber += "buzz";
                if (string.IsNullOrWhiteSpace(fizzBuzzNumber))
                    fizzBuzzNumber = index.ToString();
                
                fizzbuzzList.Add(fizzBuzzNumber);
                fizzBuzzNumber = string.Empty;
            }

            return fizzbuzzList;
        }
    }
}
