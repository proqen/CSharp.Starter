using System;
using System.Collections;
using CSharp.Starter.Methods;
using CSharp.Starter.Methods.Contracts;


namespace CSharp.Starter
{
    class Program
    {
        public static IMethod _method;
        static void Main(string[] args)
        {
            _method = new Method();
            _method.Calculator();
        }
    }
}
