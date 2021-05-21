using System;

int NumF(int num, int i,int res)
{
    res *= i;
    i++;
    if (num < i)
        return res;
    else
        return NumF(num,i,res);
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(NumF(num, 1,1));

