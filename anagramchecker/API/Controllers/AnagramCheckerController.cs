using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dictionary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("api")]
    public class AnagramCheckerController : ControllerBase
    {
        private static readonly List<string> words = new List<string>();
        public ILogger<AnagramCheckerController> logger;

        public AnagramCheckerController(ILogger<AnagramCheckerController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllKnownWords()
        {
            return Ok(words);
        }

        [HttpPost]
        [Route("checkWords")]
        public IActionResult CheckWords([FromBody]string w1, string w2)
        {
            if ( w1 != null || w1 != "" || w2 != null || w2 != "")
            {
                var result = CheckWords(w1, w2);
                return Ok(result);
            }
            return BadRequest("missing word!");
        }

        [HttpPost]
        [Route("checkDictionary")]
        public IActionResult CheckDictionary([FromQuery]string w1)
        {
            if (w1 != null || w1 != "")
            {
                var result = CheckDictionary(w1);
                return Ok(result);
            }
            return BadRequest("missing word!");
        }
    }
}
