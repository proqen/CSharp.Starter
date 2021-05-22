using System;

string IsEvenNumber(int num) => num < 0 ? "отрицательный" : "положительный";

string IsPrimeNumber(int num)
{
    if (num == 1 || num == 2 || num == 3 || num == 5 || num == 7)
        return "простой";
    if (num % 2 == 0)
        return "не простой";
    for (int i = 3; i <= Math.Sqrt(num); i+=2)
    {
        if (num % i == 0)
            return "не простой";
    }
    return "простой";
}

int num = int.Parse(Console.ReadLine());
Console.WriteLine(IsEvenNumber(num));
Console.WriteLine(IsPrimeNumber(num));

