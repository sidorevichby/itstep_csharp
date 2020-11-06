using System;
using System.ComponentModel.Design;
using LinearLib;

namespace Linear_expressions
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            int result;
            linearExpressions one = new linearExpressions();
            one.Get();
            one.Print();
            linearExpressions two = new linearExpressions();
            two.Get();
            two.Print();
            result= one + two;
            Console.WriteLine(result);

        }
    }
}
