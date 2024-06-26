﻿using System;
namespace DSA.Arrays
{
	public class CArray
	{
		private int[] arr;
		public int upper;
		private int numElements;


		public CArray(int size)
		{
			arr = new int[size];
			upper = size - 1;
			numElements = 0;
		}


		public void Insert(int item)
		{
			arr[numElements] = item;
			numElements++;
		}

		public void DisplayElements()
		{
			for (int i = 0; i <= upper; i++)
			{
				Console.WriteLine(arr[i] + " ");
			}
		}

		public void Clear()
		{
			for (int i = 0; i <= upper; i++)
			{
				arr[i] = 0;
				numElements = 0;
			}
		}

		public void GenPrimes()
		{
			for (int outer = 1; outer < arr.Length; outer++)
			{
				for (int inner = outer + 1; inner < arr.Length; inner++)
				{
					if (arr[inner] == 1)
					{
						if (inner % outer == 0)
						{
							arr[inner] = 0;
						}
					}
				}
			}
		}

		public void ShowPrimes()

		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + ",");
			}
		} 

    }
}

