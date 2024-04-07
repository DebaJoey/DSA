// See https://aka.ms/new-console-template for more information

using System.Collections;
using System.Diagnostics;
using DSA;
using DSA.AbstractDataType;
using DSA.Algorithms;
using DSA.Arrays;
using DSA.Hackerrank;
using DSA.CStack;
using static DSA.Algorithms.Challenges;
using DSA.CQueue;
using System.Text;
using System.Text.RegularExpressions;

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
int[] sortedArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

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
//BasicSearchingAlgorithms.FindMax(aL);
//BasicSearchingAlgorithms.BinarySearch(sortedArray,9);
//BasicSearchingAlgorithms.RecursiveBinarySearch(sortedArray, 8, sortedArray.Length, 0);
//int index = Array.BinarySearch(sortedArray, 8);

//Palindrome

//Challenges.isPalindrome("spops");

//Console.WriteLine(Challenges.isAdjacent(""));

//Challenges.decimalToBase(10, 2);

//int[] array = new int[] { 21, 30, 73, 46, 10, 65, 99,43,92,50 };
//Queue[] que = new Queue[10];

//Challenges.initializeQueues(ref que);
//Challenges.sortNumbers(ref que,array,DigitType.ones);
//Challenges.BuildArray(ref que, ref array);
//Challenges.displayArray(ref array);
//Challenges.sortNumbers(ref que, array, DigitType.tens);
//Challenges.BuildArray(ref que, ref array);
//Console.WriteLine();
//Challenges.displayArray(ref array);

//pqItem priorityQue = new pqItem
//{
//    Priority = 2,
//    Name = "Adwoa"
//};

//pqItem priorityQue1 = new pqItem
//{
//    Priority = 6,
//    Name = "Abena"
//};

//pqItem priorityQue2 = new pqItem
//{
//    Priority = 5,
//    Name = "Koo"
//};

//pqItem priorityQue3 = new pqItem
//{
//    Priority = 34,
//    Name = "Baaba"
//};

//PriorityQueue pQueue = new PriorityQueue();

//pQueue.Enqueue(priorityQue);
//pQueue.Enqueue(priorityQue1);
//pQueue.Enqueue(priorityQue2);
//pQueue.Enqueue(priorityQue3);

//Console.WriteLine(((pqItem)pQueue.Dequeue()).Name);

//int size = 100;
//CArray primes = new CArray(size - 1);

//for(int i = 0; i < size - 1; i++)
//{
//    primes.Insert(1);
//}

//primes.GenPrimes();
//primes.ShowPrimes();

//LongestSubArray.LengthOfLongestSubstringHashSet("pwwkew");

//string name = "Hello,World,me";
//char[] separator = new char[] { ',' };
//string[] strArray = name.Split(separator,2);
//string newArray = string.Join(' ', strArray);

//ASC Code of strings
//int charCode = (int)'d';
//Console.WriteLine(charCode);

//string str1 = "foocar";
//string str2 = "foobar";
//Console.WriteLine(String.Compare(str1,str2));
//Console.WriteLine(str1.CompareTo(str2));
//Console.WriteLine(str1.StartsWith("f"));
//Console.WriteLine(str1.StartsWith("d"));
//Console.WriteLine(str1.EndsWith("r"));
//Console.WriteLine(str1.EndsWith("d"));

//string str1 = "StubbornAcademy";
//string derivedString = str1.Remove(0, 8);
//Console.WriteLine(derivedString.Insert(0, "Good "));
//Console.WriteLine(str1.Replace("b", "c"));

//string[] words = new string[]{"recieve", "decieve","reciept"};
//for(int i = 0; i < words.Length; i++)
//{
//    words[i] = words[i].Replace("ie", "ei");
//    Console.WriteLine((i + 1) + words[i]);
//}

//string word = "Hello";
//string wrld = "World";
//Console.WriteLine(String.Concat(word," ",wrld));

//Trim

//string comments = "<--Well, Well, Well-->";
//char[] charac = new char[] { '<','-','>' };
//Console.WriteLine(comments.Trim(charac));

//StringBuilder

//StringBuilder stBuff = new StringBuilder("Ken Thompson");
//stBuff[0] = 'D';
//Console.WriteLine(stBuff.Capacity);
//Console.WriteLine(stBuff.Insert(0,"Patience",3));


//Regex

//Regex reg = new Regex("brown");
//string str1 = "the quick brown fox jumped over the lazy dog";

//Match matchSet;
//int matchPos;
//matchSet = reg.Match(str1);

//if (matchSet.Success)
//{
//    matchPos = matchSet.Index;
//    Console.WriteLine("found mtch at position :" + matchPos);
//}

string str2 = "Hello my friend. It's me again.";

if(Regex.IsMatch(str2, "friends"))
{
    Console.WriteLine("Match found");
}
else
{
    Console.WriteLine("Match not found");
}

