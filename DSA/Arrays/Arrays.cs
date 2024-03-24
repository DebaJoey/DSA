using System;
namespace DSA.Arrays
{
	public class Arrays
	{
		public static int[] InsertStart(int[] array, int newValue)
		{
			int[] newArray = new int[array.Length + 1];

			newArray[0] = newValue;

			for(var i = 0; i < array.Length; i++)
			{
				newArray[i + 1] = array[i];

				
			}

			foreach(int element in newArray)
			{
                Console.Write(element + ",");
            }

			return newArray;
		}
	}
}

