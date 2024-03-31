using System;
namespace DSA.Algorithms
{
	public class SortingAlgorithms
	{
		public static void BubbleSortAscending(int[] arr)
		{
            for (int outer = arr.Length - 1; outer >= 1; outer--)
            {
                int temp;
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    if (arr[inner] > arr[inner + 1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }

                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            int minIndex, temp;

            for(int outter = 0; outter < n-1; outter++)
            {
                minIndex = outter;

                for(int inner = outter + 1; inner < n; inner++)
                {
                    if(arr[inner] < arr[minIndex])
                    {
                        minIndex = inner;
                    }
                }

                temp = arr[minIndex];
                arr[minIndex] = arr[outter];
                arr[outter] = temp;

            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
	}

}

