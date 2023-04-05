using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            if (ignoreCase) { word = word.ToLower(); }
            foreach (var w in words)
            {
                if (w == null) { continue; }
                else if (w.ToLower() == word && ignoreCase) { return true; }
                else if (w == word && ignoreCase == false) { return true; }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num > 1)
            {
                return Enumerable.Range(1, num).Where(x => num % x == 0).SequenceEqual(new[] { 1, num });
            }

            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
            {
                var letter = str[i];
                if (str.Count(f => (f == letter)) == 1)
                {
                    return i;
                }
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var max = 0;
            var current = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1]) { current++; }
                else
                {
                    current = 1;
                }
                if (max < current) { max = current; }
            }
            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 1) { return new double[] { }; }
            var result = new List<double> { };
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0) { result.Add(elements[i]); }
            }
            return result.ToArray();
        }
    }
}
