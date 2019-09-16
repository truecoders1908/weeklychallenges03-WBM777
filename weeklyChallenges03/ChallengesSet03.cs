using System;
using System.Collections.Generic;
using System.Linq;



namespace weeklyChallenges03
{

    public class ChallengesSet03
    {
            public bool ArrayContainsAFalse(bool[] vals)
            {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
            }

            public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
            {
            if (numbers == null)
            {
                return false;
            }
            int x = numbers.Sum();
            if (x % 2 == 0)
                {
                    return false;
                }
            return true;
            }

            public bool PasswordContainsUpperLowerAndNumber(string password)
            {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
            }

            public char GetFirstLetterOfString(string val)
            {
            return val[0];           
            }

            public char GetLastLetterOfString(string val)
            {
            return val.Last();
            }

            public decimal Divide(decimal dividend, decimal divisor)
            {
            if (divisor == 0)
            {
                return 0;
            }
            decimal x = dividend / divisor;
            return x;
            }

            public int LastMinusFirst(int[] nums)
            {
            
            int x = nums.Last() - nums[0];
            return x;
            }

            public int[] GetOddsBelow100()
            {
            List<int> george = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    george.Add(i);
                }
                else
                {
                    continue;
                }
            }
            int[] paul = george.ToArray();
            return paul;
                ;

            }

            public void ChangeAllElementsToUppercase(string[] words)
            {
            for (int i = 0; i < words.Length; i++)
            {
                words[i]=words[i].ToUpper();
            }
            }
    }
}
