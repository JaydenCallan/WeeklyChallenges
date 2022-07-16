using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            double? max = null;
            double? min = null;
            foreach (var i in numbers)
            {
                if (max == null) { max = i; }
                if (min == null) { min = i; }

                if (max < i)
                {
                    max = i;
                }
                if (min > i)
                {
                    min = i;
                }
            }
            if (min == null || max == null)
            {
                return 0;
            }
            
            // Since double? can't be converted to double, turn both vars into strings and then back into doubles but non nullable
            return double.Parse(min.ToString()) + double.Parse(max.ToString());
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length)? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return (numbers == null) ? 0 : numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var sum = 0;
            foreach (int i in numbers)
            {
                sum += (i % 2 == 0) ? i : 0;
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers == null) ? false : numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }
        }
    }
}
