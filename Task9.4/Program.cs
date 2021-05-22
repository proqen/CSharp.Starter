using System;

int [] NewArray(int [] array, int value)
{
    int[] newArray = new int[array.Length+1];
    array.CopyTo(newArray, 1);
    newArray[0] = value;
    return newArray;
}

Console.WriteLine(string.Join(" ", NewArray(new int[] { 1, 2, 3, 4 }, 11)));
