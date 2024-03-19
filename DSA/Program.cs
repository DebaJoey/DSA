// See https://aka.ms/new-console-template for more information

using DSA.AbstractDataType;

//Abstract Data Type

Pokemon squirtle = new Pokemon();

Console.WriteLine(squirtle.isPokemon());

//Array Insertions And Deletions

//Inserting at the end of an array

int[] intArray = new int[6];


int length = 0;

for(int i = 0; i < 3; i++)
{
    intArray[length] = i;
    length++;
}

intArray[length] = 8;
length++;
