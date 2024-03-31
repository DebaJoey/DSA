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
            int min, temp;   //min = minimium, temp=temporal;
            for (int outer = 0; outer <= n - 1; outer++)
            {
                min = outer;
                for(int inner = outer + 1; inner < n; inner++)
                {
                    if (arr[inner] < arr[min])
                    {
                        min = inner;
                    }

                }


                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;
            }

            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + ",");
            }
        }
	}

}

