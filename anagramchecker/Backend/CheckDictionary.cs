using Backend;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public class CheckDictionary : ICheckDictionary
    {
        IReader reader;
        private readonly ILogger logger;

        public CheckDictionary(IReader reader, ILogger<CheckDictionary> logger)
        {
            this.reader = reader;
            this.logger = logger;
        }

        public CheckDictionary()
        {
        }

        IEnumerable<string> ICheckDictionary.GetAnagrams(String wordToCheck, IEnumerable<string> dictionaryWords)
        {
            var result = new List<string>();
            var sortedWordToCheck = String.Concat(wordToCheck.ToLower().OrderBy(c => c));
            
            foreach ( var word in dictionaryWords )
            {
                var sortedWord = String.Concat(word.ToLower().OrderBy(c => c));
                if (sortedWordToCheck.Equals(sortedWord)){
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
