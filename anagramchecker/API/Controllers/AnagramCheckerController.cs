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
    [Route("anagram")]
    public class AnagramCheckerController : ControllerBase
    {
        private static readonly List<string> words = new List<string>(); 

        [HttpGet]
        public IActionResult GetAllKnownWords()
        {
            return Ok(words);
        }

        [HttpPost]
        [Route("checkAnagram")]
        public IActionResult CheckWords(string w1, string w2)
        {
            if ( w1 != null || w1 != "" || w2 != null || w2 != "")
            {
                var result = CheckWords(w1, w2);
                return Ok(result);
            }
            return BadRequest("missing word!");
        }

        [HttpPost]
        [Route("{w1}")]
        public IActionResult CheckDictionary(string w1)
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
