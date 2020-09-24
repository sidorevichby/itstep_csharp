using System;

namespace Homework_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double input;
            input = Convert.ToDouble(Console.ReadLine());
            int[] input_arr = new int[4];
            input *= 10000;
            for (int i = 0; i < 4; i++)
            {
                input_arr[i] = (int)input % 10;
                if (input_arr[i] == 5)
                {
                    Console.WriteLine("Number have figure 5");
                    return;
                }
                input /= 10;
            }

            Console.WriteLine("Number does not have a figure 5");

        }
    }
}
