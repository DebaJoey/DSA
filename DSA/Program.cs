// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics;
using DSA;
using DSA.AbstractDataType;
using DSA.Algorithms;
using DSA.Arrays;
using DSA.Hackerrank;

//Abstract Data Type

//Pokemon squirtle = new Pokemon();

//Console.WriteLine(squirtle.isPokemon());

//Array Insertions And Deletions

//Inserting at the end of an array

//int[] intArray = new int[10];


//int length = 0;

//for(int i = 0; i < 8; i++)
//{
//intArray[length] = i;
// length++;
//}

//intArray[length] = 8;
//length++;

//Inserting At The Start Of An Array

//for(int i = 3; i >= 0; i--)
//{
//this is moving all the values by one index
//intArray[i + 1] = intArray[i];
//}

//intArray[0] = 20;


//Inserting Anywhere In The Array

//for(int i = 4; i >= 2; i-- )
//{
//Shift each element one position to the right
//   intArray[i + 1] = intArray[i];
//}

//intArray[2] = 8;

//int sln = HackerRankSpace.marsExploration("SOSJPSSOSSOSSOS");


//Console.WriteLine(sln);

//Array to Work With
//int[] delArray = {2, 3, 4, 5, 6, 7, 8, 9};

//Insert At Start
//Arrays.InsertStart(delArray, 15);

//Console.WriteLine("\n");

//Insert Anywhere in Array
//Arrays.InsertAnywhere(delArray, 4, 2000);

//Insert At Array End
//Arrays.InsertAtEnd(delArray, 2000);

//Delete At Array Start
//Arrays.DeleteAtStart(delArray);

//Delete At Array End
//Arrays.DeleteAtEnd(delArray);

//Delete Anywhere in Array
//Arrays.DeleteAnywhere(delArray, 3);

//Console.WriteLine("\n");

//Console.WriteLine(String.Compare("C","E"));

//LexicographicallySmallestString.smallestString("bbcacad");

//LexicographicallySmallestString.insertAnywhere("b", "c", "bbcacad");

//int[] nums = new int[20];
//Arrays.BuildArray(nums);
//Timing tObj = new Timing();
//tObj.startTime();
//Arrays.DisplayNums(nums);
//tObj.StopTime();
//Console.WriteLine("time (.NET):" + tObj.Result().TotalSeconds);

//int[,] grades = new int[,] { { 1, 82, 74, 89, 100 },
//                             { 2, 93, 96, 85, 86 },
//                             { 3, 83, 72, 95, 89 },
//                             { 4, 91, 98, 79, 88 } };
//int nasem = grades[3, 4];

//Arrays.AverageGrades(grades);

//Arrays.Sum(99, 33, 1000);

//Jagged Arrays

//int[][] jagged = new int[2][];
//jagged[0] = new int[] { 1, 2, 3 };
//jagged[1] = new int[] { 45, 6, 89 };

//int[] jan = new int[30];
//int[] feb = new int[29];

//int[][] sales;

//sales = new int[][] { jan, feb };
//sales[0][0] = 2000;
//sales[0][1] = 1080;


CArray nums = new CArray(10);
Random rnd = new Random(100);
int[] aL = new int[] { 57, 90, 22, 2, 45, 6 };

for(int i = 0; i < 10; i++)
{
    nums.Insert((int)(rnd.NextDouble() * 100));
}

//nums.DisplayElements();

//SortingAlgorithms.BubbleSortAscending(aL);
//SortingAlgorithms.SelectionSort(aL);
//SortingAlgorithms.InsertionSort(aL);
//BasicSearchingAlgorithms.SequentialSearching(aL, 6);
//BasicSearchingAlgorithms.FindMin(aL);
BasicSearchingAlgorithms.FindMax(aL);