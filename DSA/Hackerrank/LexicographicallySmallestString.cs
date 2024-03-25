using System;
using System.Text;

namespace DSA.Hackerrank
{
	public class LexicographicallySmallestString
	{
		public static string smallestString(string word)
		{
			string c1;
			string c2;

			string freshNewWord = word;

			for(int i = 0; i < word.Length - 1; i++)
			{
				if (word[i].ToString() != word[i + 1].ToString())
				{
					c1 = word[i].ToString();
				    c2 = word[i + 1].ToString();

					string newWord = word.Replace(c1, "*").Replace(c2, c1).Replace("*",c2);
					Console.WriteLine(newWord);

					int j = 0;
                    while (j < newWord.Length && j < freshNewWord.Length && newWord[j] == freshNewWord[j])
                    {
                        j++;
                    }


                    if (j < newWord.Length && j < freshNewWord.Length)
                    {
                        if (string.Compare(newWord[j].ToString(), freshNewWord[j].ToString()) < 0)
                        {
                            freshNewWord = newWord;
                        }
                    }
                }
				


            }


			Console.WriteLine(freshNewWord);

            return freshNewWord;

        }

		public static string insertAnywhere(string c1, string c2, string word)
		{

            StringBuilder newWord = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
			{
				

				if (word[i].ToString() == c1)
				{
					newWord.Append(c2);
				}
				else if (word[i].ToString() == c2)
				{
					newWord.Append(c1);
				}
				else
				{
					newWord.Append(word[i].ToString());
				}

				
			}
			Console.WriteLine(newWord);

            return newWord.ToString();
        }
	}
}

