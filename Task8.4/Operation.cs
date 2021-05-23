using System;

namespace Task8._4
{
    public class Operation
    {
        public string Concat(string value1,string value2)
        {
            if (value2 == String.Empty || value1 == String.Empty)
            {
                return $"неверно введены значения!";
            }
            return String.Concat(value1,value2);
        }

        public string Exponentiation(string value1, string value2)
        {
            if (value1 == String.Empty || value2 == String.Empty)
            {
                return $"Заполните все поля!";
            }
            try
            {
                double num1 = Double.Parse(value1);
                double num2 = Double.Parse(value2);

                return $"{Math.Pow(num1, num2)}";
            }
            catch (Exception e)
            {
                return $"Неверно введены значения!";
            }
        }

        public string Division(string value1, string value2)
        {
            if (value1 == String.Empty || value2 == String.Empty)
            {
                return $"Заполните поля!";
            }
            try
            {
                double num1 = Double.Parse(value1);
                double num2 = Double.Parse(value2);
                if (num2 == 0)
                {
                    return "Деление на нуль!";
                }
                return $"{num1/num2}";
            }
            catch (Exception e)
            {
                return $"Неверно введены значения!";
            }
        }

        public string RemindOfDivision(string value1, string value2)
        {
            if (value1 == String.Empty || value2 == String.Empty)
            {
                return $"Заполните поля!";
            }
            try
            {
                double num1 = Double.Parse(value1);
                double num2 = Double.Parse(value2);
                if (num2 == 0)
                {
                    return "Деление на нуль!";
                }
                return $"{num1 % num2}";
            }
            catch (Exception e)
            {
                return $"Неверно введены значения!";
            }
        }
    }
    
}