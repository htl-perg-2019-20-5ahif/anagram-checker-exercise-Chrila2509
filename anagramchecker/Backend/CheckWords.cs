using Backend;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public class CheckWords : ICheckWords
    {
        private readonly ILogger logger;
        private IEnumerable<object> wordsToCheck;

        public CheckWords()
        {
        }

        public Boolean IsAnagram(String w1, String w2)
        {
            w1 = String.Concat(w1.ToLower().OrderBy(c => c));
            w2 = String.Concat(w2.ToLower().OrderBy(c => c));
            return w1.Equals(w2);
        }
    }
}
