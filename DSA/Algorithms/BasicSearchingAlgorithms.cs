using System;
namespace DSA.Algorithms
{
	public class BasicSearchingAlgorithms
	{

		public static int SequentialSearching(int[] arr, int searchValue)
		{
			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] == searchValue)
				{
					Console.WriteLine(i);
					return i;
				}

			}

			Console.WriteLine(-1);
            return -1;
        }


	}
}

