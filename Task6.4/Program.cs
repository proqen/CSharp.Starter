using System;

int num = int.Parse(Console.ReadLine());
int i = 1, numF = 1;

do
{
    numF *=i++;
} while (num >= i);

Console.WriteLine(numF);