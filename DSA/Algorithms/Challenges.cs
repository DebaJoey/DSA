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
                            return false;
                        }
                    }

                    else if(adj.Substring(i, 1) == "{" && i + 1 < adj.Length)
                    {
                        if(adj.Substring(i+1, 1) != "}")
                        {
                            return false;
                        }
                    }

                    else if(adj.Substring(i, 1) == "[" && i + 1 < adj.Length)
                    {
                        if(adj.Substring(i + 1, 1) != "]")
                        {
                            return false;
                        }
                    }

                    else
                    {
                        return false;
                    }

                }
            }

            if(adj.Length < 1)
            {
                return false;
            }
            return true;
        }

        public static void decimalToBase(int number, int baseNumber )
        {
            Stack baseStack = new Stack();

            do
            {
                baseStack.Push(number % baseNumber);

                number /= baseNumber;
            } while (number != 0);

            while(baseStack.Count > 0)
            {
                Console.Write(baseStack.Pop());
            }
        }

        public enum DigitType {ones = 1, tens = 10};

        public static void sortNumbers( ref Queue[] queue, int[] n, DigitType digit)
        {
            int sNum;

            for(int x = 0; x < n.Length; x++)
            {
                if (digit == DigitType.ones)
                {
                    var tin = n[x];
                    sNum = n[x] % 10;
                 
                }
                else
                {
                    sNum = n[x] / 10;
                }

                queue[sNum].Enqueue(n[x]);
            }
        }

        public static void initializeQueues(ref Queue[] queue)
        {
            for(int i = 0; i < queue.Length; i++)
            {
                queue[i] = new Queue();
            }
        }

        public static void displayArray(ref int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if(i == 0)
                {
                    Console.Write("[" + array[i] + ",");
                }
                else if( i == array.Length - 1)
                {
                    Console.Write(array[i] + "]");
                }
                else
                {
                    Console.Write(array[i] + ",");
                }
                
            }    
        }

        public static void BuildArray(ref Queue[] queue, ref int[] array)
        {
            int y = 0;

            for(int i = 0; i < queue.Length; i++ )
            {
                while (queue[i].Count > 0)
                {
                    array[y] = Int32.Parse(queue[i].Dequeue().ToString());
                    y++;
                }
            }
        }
    }
}

