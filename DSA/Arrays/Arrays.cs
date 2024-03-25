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

		public static int[] InsertAnywhere(int[] array, int position, int value)
		{

			int[] newArray = new int[array.Length + 1];

			for(int i = 0; i < position; i++)
			{
				newArray[i] = array[i];
			}

			newArray[position] = value;

			for(int i = position; i < array.Length; i++)
			{
				newArray[i + 1] = array[i];
			}

			foreach(int element in newArray)
			{
				Console.Write(element + ",");
			}

			return newArray;
		}

		public static int[] InsertAtEnd(int[] array, int value)
		{
			int[] newArray = new int[array.Length + 1];

			for(int i = 0; i < array.Length; i++)
			{
				newArray[i] = array[i];
			}

			newArray[array.Length] = value;

			Console.WriteLine("\n");

			foreach(int element in newArray)
			{
				Console.Write(element + ",");
			}


			return newArray;
		}


		//Delete
		public static int[] DeleteAtStart(int[] array)
		{
			int[] newArray = new int[array.Length - 1];

			for(int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = array[i + 1];
			}

			return newArray;
		}

		public static int[] DeleteAtEnd(int[] array)
		{
			int[] newArray = new int[array.Length - 1];

			for(int i = 0; i < newArray.Length; i++)
			{
				newArray[i] = array[i];
			}

            return newArray;
        }

		public static int[] DeleteAnywhere(int[] array, int position)
		{
			int[] newArray = new int[array.Length - 1];

			for(int i = 0; i < position; i++)
			{
				newArray[i] = array[i];
			}

			newArray[position] = array[position + 1];

			for(int i = position + 1; i < newArray.Length; i++)
			{
				newArray[i] = array[i + 1];
			}


            return newArray;

        }
    
	}
}

