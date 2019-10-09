using System;
using System.Collections.Generic;
using System.Text;

namespace AnagramChecker
{
    interface ICheck
    {
        void CheckIfAnagram(string w1, string w2);

        void GetKnown(string word);
    }
}
