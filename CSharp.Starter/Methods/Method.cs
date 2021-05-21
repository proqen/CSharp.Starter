using System;
using System.Runtime.InteropServices.ComTypes;
using CSharp.Starter.Methods.Contracts;

namespace CSharp.Starter.Methods
{
    public class Method : IMethod
    {
        Operation operation = new Operation();
        public void Calculator()
        {
            Console.WriteLine("Введите первое значение");
            bool a = long.TryParse(Console.ReadLine(), out long value1);
            Console.WriteLine("Введите второе значение");
            bool b = long.TryParse(Console.ReadLine(), out long value2);
            if (a && b)
            {
                Console.WriteLine("Выберите операцию +,-,*,/");
                var reply = Console.ReadLine().Trim();
                switch (reply)
                {
                    case "+": 
                        Console.WriteLine(operation.Add(value1, value2));
                        break;
                    case "-": 
                        Console.WriteLine(operation.Sub(value1,value2));
                        break;
                    case "*": 
                        Console.WriteLine(operation.Mul(value1,value2));
                        break;
                    case "/": 
                        Console.WriteLine(operation.Div(value1,value2));
                        break;
                    default:
                        Console.WriteLine("Ошибка при вводе!"); 
                        break;
                }
            }
            else
            {
                Console.WriteLine("Вы ввели некорректные значения. \n " +
                                  "Хотите повторить? \n" +
                                  "1 - да \n" +
                                  "2- нет");
                var reply = Console.ReadLine().Trim();
                if (reply == "1")
                {
                    Calculator();
                }
                else if(reply == "2")
                {
                    Console.WriteLine("Пока");
                }
                else
                {
                    Console.WriteLine("Ошибка!");
                    Console.ReadKey();
                }
            }
        }

    }
}