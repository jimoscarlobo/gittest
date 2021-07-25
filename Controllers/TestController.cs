using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gittest
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        public List<string> GetTest()
        {
            List<string> terms = new List<string>();
            terms.Add("https://www.test.com");
            terms.Add("https://test.com");

            return terms;
        }
    }
}
