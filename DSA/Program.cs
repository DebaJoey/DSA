﻿// See https://aka.ms/new-console-template for more information

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

Regex reg = new Regex("the");
//string str1 = "the quick brown fox jumped over the lazy dog";

//Match matchSet;
//int matchPos;
//matchSet = reg.Match(str1);

//if (matchSet.Success)
//{
//    matchPos = matchSet.Index;
//    Console.WriteLine("found mtch at position :" + matchPos);
//}


//Regex Multiple Matches

//string str3 = "I am the Prince Of the kingdom of Zamunda;";
//MatchCollection matches;
//matches = reg.Matches(str3);

//foreach(Match match in matches)
//{
//    Console.WriteLine("Match found at position :" + match.Index);
//}

//string str4 = "what is going on here. Huh?? I said what is going on here.";
//str4 = Regex.Replace(str4, "what", "who");
//Console.WriteLine(str4);

//Regex Quantifiers
string[] words = new string[] { "bad", "bd", "bong", "baag", "bend", "baaad","caad" };

//foreach(string word in words)
//{
//    if(Regex.IsMatch(word, "ba+"))
//    {
//        Console.WriteLine(word);
//    }
//}

//foreach (string word in words)
//{
//    if (Regex.IsMatch(word, "ba*"))
//    {
//        Console.WriteLine(word);
//    }
//}

//foreach (string word in words)
//{
//    if (Regex.IsMatch(word, "ba?d"))
//    {
//        Console.WriteLine(word);
//    }
//}

//foreach (string word in words)
//{
//    if (Regex.IsMatch(word, "ba{2}"))
//    {
//        Console.WriteLine(word);
//    }
//}

//foreach (string word in words)
//{
//    if (Regex.IsMatch(word, "ba{2,4}"))
//    {
//        Console.WriteLine(word);
//    }
//}


//Lazy Quantifiers

//string[] wordz = new string[] { "board", "<b>Boarder Patrol</b>", "Quotation", "<p>Oh Dear, Whats happening</p>" };
//string regEx = "<.+>";
//string regEx1 = "<.*>";
//string regEx2 = "<.+?>";

//MatchCollection matchez;

//foreach(string word in wordz)
//{
//    matchez = Regex.Matches(word, regEx2);

//    foreach(Match match in matchez)
//    {
//      var mat =  match.Value;
//        Console.WriteLine(mat);
//    }

//    //for(int i = 0; i < matchez.Count; i++)
//    //{
//    //    Console.WriteLine(matchez[i]);
//    //};

//}

//Character Classes

string str6 = "THE boy faith Is hoy tHe BOY'S father kol 24 moh";
string[] str8 = new string[] { "foth", "cofuuhurde", "ffff", "fpoi" };
//MatchCollection matchezz = Regex.Matches(str6, "t.e");
//foreach (Match match in matchezz)
//{
//    Console.WriteLine("position" + match.Index);
//}


//foreach (string match in str8)
//{
//    if (Regex.IsMatch(match, "\\bf\\w*h\\b"))
//    {
//        Console.WriteLine(match);
//    }
//}

//Console.WriteLine(Regex.IsMatch("father", "r\\b"));
//Console.WriteLine(Regex.IsMatch("soc5cer", "\\bs\\w*r\\b"));

//Anonymous Groups

string dates = "08/14/57 46 02/25/59 45 06/05/85 18 03/12/88 16 09/09/90 13";
//string regExp1 = "(\\s\\d{2}\\s)";
//string regExp2 = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s";
//MatchCollection matchSet = Regex.Matches(dates, regExp2);

//foreach(Match match in matchSet)
//{
//    Console.WriteLine(match.Groups["dates"]);
//}

string wordsz = "123routine Koko25 routine2 procedure8 45procedure";
string regExp1 = "\\b(?!\\d)\\w+\\b";
string lookAheadAssertion = "\\w+(?=\\d)";
string lookBehindAssertion = "(?<=\\d)\\w+";
string groupNames = "(?<dates>(\\d{2}/\\d{2}/\\d{2}))\\s(?<ages>(\\d{2}))\\s";

//MatchCollection matchezzz = Regex.Matches(wordsz, lookBehindAssertion);
//foreach(Match match in matchezzz)
//{
//    Console.WriteLine(match.Value);
//}

MatchCollection matchezzz = Regex.Matches(dates, groupNames);

foreach (Match date in matchezzz)
{
    foreach (Capture dat in date.Groups["dates"].Captures)
    {
        Console.WriteLine("\n");
        Console.WriteLine(dat.Value);
    }
       
    
}

foreach (Match date in matchezzz)
{
    foreach (Capture dat in date.Groups["ages"].Captures)
    {
        Console.WriteLine("\n");
        Console.WriteLine(dat.Value);
    }
}

