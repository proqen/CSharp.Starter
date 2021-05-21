using System;
using System.Collections;
using CSharp.Starter._005;
using CSharp.Starter._005.Contracts;

namespace CSharp.Starter
{
    class Program
    {
        private static ILogicalAndBitwiseOperations _logicalAndBitwiseOperations;
        static void Main(string[] args)
        {
            _logicalAndBitwiseOperations = new LogicalAndBitwiseOperations();
            _logicalAndBitwiseOperations.ThirdTask();
        }
    }
}
