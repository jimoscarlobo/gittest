using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gittest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfileController : ControllerBase
    {
     

        [HttpGet]
        public List<string> GetTermsUrl()
        {
            List<string> terms = new List<string>();
            terms.Add("https://www.nbg.gov.ge/index.php?m=2");
            terms.Add("https://www.fms.gov.ge/");

            return terms;
        }
    }
}
