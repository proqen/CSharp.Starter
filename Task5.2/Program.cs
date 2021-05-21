using System;

int num = int.Parse(Console.ReadLine());

if (Convert.ToString(num, 2)[^1] == '0' && num % 2 == 0)
    Console.WriteLine("YES"); //чет
else
    Console.WriteLine("NO");
