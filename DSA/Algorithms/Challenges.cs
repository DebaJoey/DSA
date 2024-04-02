using System;
using System.Collections;

namespace DSA.Algorithms
{
	public class Challenges
	{
		public static void isPalindrome(string word)
		{
            Stack stack = new Stack();
            string ch;
            bool isPalindrome = true;
            string wordUpper = word.ToUpper();

            for (int x = 0; x < word.Length; x++)
            {
                stack.Push(wordUpper.Substring(x, 1));

            }


            int pos = 0;

            while (stack.Count > 0)
            {
                ch = stack.Pop().ToString();

                if (wordUpper.Substring(pos, 1) != ch)
                {
                    isPalindrome = false;
                    Console.WriteLine("word is not a palindrome");
                    break;
                }
                pos++;
            }

            if (isPalindrome)
            {
                Console.WriteLine("word is a palindrome");
            }

        }

        public static bool isAdjacent(string adj)
        {

            int falsy = 0;

            for(int i = 0; i < adj.Length; i++)
            {
                if(i == 0 || i%2 == 0 && adj.Length > 1)
                {
                    if(adj.Substring(i,1) == "(")
                    {
                        if (adj.Substring(i + 1, 1) != ")")
                        {
                            falsy++;
                        }
                    }

                    else if(adj.Substring(i, 1) == "{" && i + 1 < adj.Length)
                    {
                        if(adj.Substring(i+1, 1) != "}")
                        {
                           falsy++;
                        }
                    }

                    else if(adj.Substring(i, 1) == "[" && i + 1 < adj.Length)
                    {
                        if(adj.Substring(i + 1, 1) != "]")
                        {
                           falsy++;
                        }
                    }

                    else
                    {
                        falsy++;
                    }

                }
            }

            if (falsy <= 0 && adj.Length > 1)
            {
                return true;
            }

            return false;
        }
    }
}

