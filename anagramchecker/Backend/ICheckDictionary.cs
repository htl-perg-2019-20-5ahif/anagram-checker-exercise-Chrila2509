using System;
using System.Collections.Generic;
using System.Text;

namespace Backend
{
    interface ICheckDictionary
    {
        IEnumerable<string> GetAnagrams(String wordToCheck, IEnumerable<string> dictionaryWords);
    }
}
