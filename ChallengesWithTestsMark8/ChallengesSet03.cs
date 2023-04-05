using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return vals.Contains(false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return (numbers == null) ? false : numbers.Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsDigit) && password.Any(char.IsUpper) && password.Any(char.IsLower);
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0)? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return (nums.Count() == 0)? 0 : nums[nums.Count() - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(0, 100).Where(n=> n % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Count(); i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
