using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Web.Http.Cors;

namespace CodeTestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class TestController : ControllerBase
    {
        [HttpGet("SumAndCheckPrimeNumbers/{numbers}")]
        public IActionResult GetSumAndPrimeNumber([System.Web.Http.FromUri] int [] numbers)
        {
            int count = 0;
            int sum = numbers.Sum(x => x);
            for ( int i = 1; i <= sum; i++)
            {
                if (sum % i == 0)
                {
                    count++;
                }
            }

            if (count == 2)
            {
                return Ok(new { result=sum, isprime = true });

            }

            return Ok(new { result = sum, isprime = false});
        }

        [HttpGet ("check_prime_number/{num}")]
        public IActionResult GetPrimeNumber(int num)
        {
            
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count== 2)
            {
                return Ok(new { isprime = true });
            }

            return Ok(new { isprime = false });
        }

    }
}
