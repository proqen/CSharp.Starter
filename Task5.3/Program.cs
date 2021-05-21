using System;
using Task5._3.LogicalAndBitwiseOperations.Contracts;

namespace Task5._3
{
    class Program
    {
        private static ILogicalAndBitwiseOperations _logicalAndBitwiseOperations;
        static void Main(string[] args)
        {
            _logicalAndBitwiseOperations = new LogicalAndBitwiseOperations.LogicalAndBitwiseOperations();
            _logicalAndBitwiseOperations.ThirdTask();
        }
    }
}
