using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            do
            {
                startNumber++;
                if (startNumber % n == 0) { return startNumber; }
            }
            while (true);
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Count() == 0) { return false; }
            var prev = numbers[0];
            foreach (var num in numbers)
            {
                if (prev > num) { return false; }
                prev = num;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var tot = 0;
            for (int i = 0; i < numbers.Count()-1; i++)
            {
                if (numbers[i] % 2 == 0) { tot += numbers[i + 1]; }
            }
            return tot;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) { return ""; }
            var res = "";
            foreach (var word in words)
            {
                var wordSpaceless = Regex.Replace(word, " ", "");
                if (wordSpaceless.Length > 0) { res += wordSpaceless + " "; }
            }
            return (res.Length > 0)? res.Remove(res.Length-1)+"." : "";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) { return new double[] {}; }
            var result = new List<double> { };
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i+1) % 4 == 0) { result.Add(elements[i]); }
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int num1 = 0; num1 < nums.Count(); num1++)
            {
                for (int num2 = 0; num2 < nums.Count(); num2++)
                {
                    if (nums[num1]+nums[num2] == targetNumber && num1 != num2) { return true; }
                }
            }
            return false;
        }
    }
}
