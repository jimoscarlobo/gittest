using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gittest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public List<string> GetMYUrl()
        {
            List<string> terms = new List<string>();
            terms.Add("https://www.google.com");
            terms.Add("https://facebook.com");

            return terms;
        }
        [HttpGet]
        public List<string> GetYourUrl()
        {
            List<string> terms = new List<string>();
            terms.Add("https://www.donedeal.com");
            terms.Add("https://daft.com");

            return terms;
        }
    }
}
