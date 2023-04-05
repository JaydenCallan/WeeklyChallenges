using System;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var tot = 0;
            foreach (var i in numbers)
            {
                tot += (i % 2 == 0) ? i : -i;
            }
            return tot;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            return new string[] { str1, str2, str3, str4}.Min(y => y.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] { number1, number2, number3, number4 }.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 == 0 || sideLength2 == 0 || sideLength3 == 0) { return false; }
            var sides = new int[] { sideLength1, sideLength2, sideLength3 };
            Array.Sort(sides);
            return (sides[0] + sides[1] > sides[2]);
        }

        public bool IsStringANumber(string input)
        {
            double num;
            return double.TryParse(input, out num);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Count(s => s == null) > objs.Count()/2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var tot = 0.0;
            var added = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0) { tot += num; added++; }
            }
            return (added == 0)? 0 : tot / added;
        }

        public int Factorial(int number)
        {
            return Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item);
        }
    }
}
