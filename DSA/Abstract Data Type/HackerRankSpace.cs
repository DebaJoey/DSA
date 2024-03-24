using System;
namespace DSA.AbstractDataType
{
	public class HackerRankSpace
	{

        public static int marsExploration(string s)
        {

            string message = "SOS";
            int messageLength = s.Length / 3;

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


            //         int changed = 0;
            //for (int i=0; i < s.Length; i++)
            //{
            //    if((i+1)%3 == 0 || (i+1)%3 == 1)
            //    {
            //        if(s.Substring(i,1) != "S")
            //        {
            //            changed++;
            //        }
            //    }
            //    else if ((i+1)%3 == 2)
            //    {
            //        if(s.Substring(i,1) != "O")
            //        {
            //            changed++;
            //        }
            //    }
            //}
            //return changed;

              }

        }
}

