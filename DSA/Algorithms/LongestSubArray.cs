using System;
namespace DSA.Algorithms
{
	public class LongestSubArray
	{
        public static int LengthOfLongestSubstringList(string s)
        {

            List<string> testArray = new List<string>();
            List<int> resultList = new List<int>();

            if (s.Length > 0)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    testArray.Add(s[i].ToString());


                    for (int y = i + 1; y < s.Length; y++)
                    {
                        if (testArray.Contains(s[y].ToString()))
                        {
                            resultList.Add(testArray.Count);
                            break;
                        }
                        else
                        {
                            testArray.Add(s[y].ToString());
                            resultList.Add(testArray.Count);
                        }
                    }

                    testArray.Clear();


                }
                if (resultList.Count > 1)
                {
                    Console.WriteLine(resultList.Max());
                    return resultList.Max();
                }
                else if (resultList.Count == 1)
                {
                    Console.WriteLine(resultList[0]);
                    return resultList[0];
                }


            }

            Console.WriteLine(s.Length);
            return s.Length;
        }

        public static int LengthOfLongestSubstringHashSet(string s)
        {
            HashSet<char> set = new HashSet<char>();
            int maxLength = 0;
            int left = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
    }
}
}

