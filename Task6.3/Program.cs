using System;
using System.Linq;

int a = 10, b = 6; // Size a < 1 : a = 2, a = 3 ; b > 1;

Console.WriteLine("прямоугольник");
Console.Write("\n");

foreach (int i in Enumerable.Range(1, a))
    Console.Write(" *");
foreach (int j in Enumerable.Range(1, b-1))
{
    Console.Write("\n");
    foreach (int i in Enumerable.Range(1, a))
            if (i == 1 || i == a) Console.Write(" *"); else Console.Write("  ");
}
Console.Write("\n");
foreach (int i in Enumerable.Range(1, a))
    Console.Write(" *");
/////////////////////////////////////////////
Console.Write("\n");
Console.WriteLine("прямоугольный треугольник");

foreach (int j in Enumerable.Range(1, a - 1))
{
    Console.Write("\n");
    foreach (int i in Enumerable.Range(1, j))
        if (i == 1 || i == j) Console.Write(" *"); else Console.Write("  ");
}
Console.Write("\n");
foreach (int i in Enumerable.Range(1, a))
    Console.Write(" *");
//////////////////////////////////////////////
Console.Write("\n");
Console.WriteLine("равносторонний треугольник");
Console.Write("\n");

Console.Write(String.Concat(Enumerable.Repeat(" ", a)) + "*");
foreach (int j in Enumerable.Range(2, a - 2).Reverse())
{
    Console.Write("\n");
        Console.Write(String.Concat(Enumerable.Repeat(" ", j))+"*");    
        Console.Write(String.Concat(Enumerable.Repeat(" ", a-j-1))+String.Concat(Enumerable.Repeat(" ", (a-j)-1))+" *");    
}
Console.Write("\n");
foreach (int i in Enumerable.Range(1, a))
    Console.Write(" *");

///////
Console.Write("\n");
Console.WriteLine("ромб");
Console.Write("\n");

Console.Write(String.Concat(Enumerable.Repeat(" ", a)) + "*");
foreach (int j in Enumerable.Range(2, a - 2).Reverse())
{
    Console.Write("\n");
    Console.Write(String.Concat(Enumerable.Repeat(" ", j)) + "*");
    Console.Write(String.Concat(Enumerable.Repeat(" ", a - j - 1)) + String.Concat(Enumerable.Repeat(" ", (a - j) - 1)) + " *");
}
Console.Write("\n");
Console.Write(" *");
Console.Write(String.Concat(Enumerable.Repeat(" ",a*2-3)) + "*");

foreach (int j in Enumerable.Range(2, a - 2))
{
    Console.Write("\n");
    Console.Write(String.Concat(Enumerable.Repeat(" ", j)) + "*");
    Console.Write(String.Concat(Enumerable.Repeat(" ", a - j - 1)) + String.Concat(Enumerable.Repeat(" ", (a - j) - 1)) + " *");
}
Console.Write("\n");
Console.Write(String.Concat(Enumerable.Repeat(" ", a)) + "*");


