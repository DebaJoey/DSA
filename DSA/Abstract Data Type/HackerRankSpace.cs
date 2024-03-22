using System;
namespace DSA.AbstractDataType
{
	public class HackerRankSpace
	{

        public static int marsExploration(string s)
        {

            string message = "SOS";
            int messageLength = s.Length/3;

            string expectedMessage = string.Concat(Enumerable.Repeat(message, messageLength));



            int finalLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != expectedMessage[i])
                {
                    finalLength++;
                }
            }

            return finalLength;

        }

    }
}

