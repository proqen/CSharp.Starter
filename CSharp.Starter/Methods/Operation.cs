namespace CSharp.Starter.Methods
{
    public class Operation
    {
        public string Add(long value1, long value2)
        {
            return $"Сумма чисел ={value1 + value2}";
        }
        public string Sub(long value1, long value2)
        {
            return $"Разность чисел ={value1 - value2}";
        }

        public string Mul(long value1, long value2)
        {
            return $"Прозведение чисел ={value1 * value2}";
        }

        public string Div(long value1, long value2)
        {
            if (value2 == 0)
            {
                return "На нуль делить нельзя";
            }
            else
            {
                return $"Частое чисел = {value1 / value2}";
            }
        }
    }
}