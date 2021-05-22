using System;

var res = "нечетный";
int num = int.Parse(Console.ReadLine());
if (Convert.ToString(num, 2)[^1] == '0' && num % 2 == 0)
    res = "четный";

Console.WriteLine(res);
