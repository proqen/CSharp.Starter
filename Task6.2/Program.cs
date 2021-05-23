using System;
using System.Linq;

int a = 1, b = 12;

foreach ( int i in Enumerable.Range(a, b))
    Console.WriteLine(i);

Console.WriteLine("все нечетные значения");

foreach (int i in Enumerable.Range(a, b).Where(x => (x & 1) != 0))
    Console.WriteLine(i);