using System;

bool CheckNum(string num) =>
    num[^1] switch
    {
        '1' => false,
        '3' => false,
        '5' => false,
        '7' => false,
        '9' => false,
        _ => true
    };

var res = "нечетный";
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0 && Convert.ToString(num, 2)[^1] == '0' &&  (num & 1) == 0 && CheckNum(num.ToString()))
    res = "четный";

Console.WriteLine(res);
