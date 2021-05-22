using System;

int Factorial(int num) => num < 2 ? 1 : num-- * Factorial(num);
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Factorial(num));

