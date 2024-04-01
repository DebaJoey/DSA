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

		public static int FindMin(int[] arr)
		{
			int min = arr[0];

			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] < min)
				{
					min = arr[i];
				}
			}

			Console.WriteLine(min);
			return min;
		}

		public static int FindMax(int[] arr)
		{

			int max = arr[0];

			for(int i = 0; i < arr.Length; i++)
			{
				if (arr[i] > max)
				{
					max = arr[i];
				}
			}

			Console.WriteLine(max);
			return max;
		}


	}
}

