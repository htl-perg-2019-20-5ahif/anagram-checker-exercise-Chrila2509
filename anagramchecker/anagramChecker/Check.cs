using System;
using System.Collections.Generic;
using Backend;
using Dictionary;

namespace AnagramChecker
{
    class Check
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the words you want to check");

            if ( args.Length != 0)
            {
                switch (args[0])
                {
                    case "check":
                        if (string.IsNullOrEmpty(args[1]) || string.IsNullOrEmpty(args[2]))
                        {
                            Console.WriteLine("Please mind the Syntax: AnagramChecker.exe getKnown <word>");
                            break;
                        }
                        else
                        {
                            CheckIfAnagram(args[1], args[2]);
                        }
                        break;
                    case "getKnown":
                        if (string.IsNullOrEmpty(args[1]))
                        {
                            Console.WriteLine("Please mind the Syntax: AnagramChecker.exe getKnown <word>");
                            break;
                        }
                        else
                        {
                            GetKnown(args[1]);
                        }
                        break;
                }
            }
        }

        public static void CheckIfAnagram(string w1, string w2)
        {
            var checker = new CheckWords();

            if (checker.IsAnagram(w1, w2))
            {
                Console.WriteLine(w1 + " and " + w2 + " are anagrams.");
            }
            else
            {
                Console.WriteLine(w1 + " and " + w2 + " are not anagrams.");
            }
        }
        
        public static void GetKnown(string word)
        {
            var checker = new CheckDictionary();
            var reader = new Reader();

            var dictText = reader.Reader();
            List<string> knownWords = checker.GetAnagrams(dictText, word);

            if (knownWords.Count != 0)
            {
                for (int i = 0; i < knownWords.Count; i++)
                {
                    Console.WriteLine(knownWords[i]);

                }
            }
            else
            {
                Console.WriteLine("No known anagrams found.");
            }
        }
    }
}
