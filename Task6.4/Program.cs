using System;

int num = int.Parse(Console.ReadLine());
int res = 1;

do
{
    res *=num;
} while (num-- > 1);

Console.WriteLine(res);