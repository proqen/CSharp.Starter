using System;
using Task5._3.LogicalAndBitwiseOperations.Contracts;

namespace Task5._3.LogicalAndBitwiseOperations
{
    public class LogicalAndBitwiseOperations : ILogicalAndBitwiseOperations
    {
        public void ThirdTask()
        {
            Console.WriteLine("Третье задание");
            int x = 10, y = 12, z = 3;
            Console.WriteLine(XF(x, y, z));
            Console.WriteLine(ZF(x, y, z));
            Console.WriteLine(Y(x, y, z));
            Console.WriteLine(ZS(x, y, z));
            Console.WriteLine(XS(x, y, z));
        }
        #region Operations

        private string XF(int x, int y, int z)
        {
            return $"1. {x += y - x++ * z}";
        }
        private string XS(int x, int y, int z)
        {
            return $"5. {x = y - x++ * z}";
        }

        private string ZF(int x, int y, int z)
        {
            return $"2. {z = --x - y * 5}";
        }
        private string ZS(int x, int y, int z)
        {
            return $"4. {z = x++ + y * 5}";
        }
        private string Y(int x, int y, int z)
        {
            return $"3. {y /= x + 5 % z}";
        }
        #endregion
    }
}