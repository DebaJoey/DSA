// See https://aka.ms/new-console-template for more information

using DSA.AbstractDataType;
using DSA.Arrays;

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

int sln = HackerRankSpace.marsExploration("SOSJPSSOSSOSSOS");


Console.WriteLine(sln);

//Array to Work With
int[] delArray = {2, 3, 4, 5, 6, 7, 8, 9};

//Insert At Start
Arrays.InsertStart(delArray, 15);

Console.WriteLine("\n");

//Insert Anywhere in Array
Arrays.InsertAnywhere(delArray, 4, 2000);

//Insert At Array End
Arrays.InsertAtEnd(delArray, 2000);




