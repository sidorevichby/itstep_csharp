using System;

namespace Homework_4_RightToLeft
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int length, output, inputInt;
            input = Console.ReadLine();
            length = input.Length;
            inputInt = Convert.ToInt32(input);
            while (length>0)
            {
                output = inputInt % 10;
                inputInt /= 10;
                length--;
                Console.Write(output);
            }
            Console.WriteLine();
        }
    }
}
