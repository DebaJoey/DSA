// See https://aka.ms/new-console-template for more information

using DSA.AbstractDataType;

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

Console.WriteLine(HackerRankSpace.marsExploration("SOSSPSROSPOS"));


int[] delArray = new int[9];

int length1 = 0;

for(int i = 0; i < 6; i++)
{
    delArray[length1] = i;
    length1++;
}

length1--;

for(int i = 0; i < length1; i++)
{
    Console.WriteLine(delArray[i]);
}

