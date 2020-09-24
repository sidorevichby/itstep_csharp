using System;

namespace Homework_3_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber, secondnumber;
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber = Convert.ToInt32(Console.ReadLine());
            do
            {
                for (int i = 0; i < firstnumber; i++)
                {
                    Console.Write("{0} ", firstnumber);
                }
                Console.WriteLine();
                firstnumber++;
            }
            while (firstnumber <= secondnumber);
        }
    }
}
