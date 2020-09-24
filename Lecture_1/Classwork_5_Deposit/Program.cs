using System;

namespace Classwork_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double deposit = 1000, finishdeposit = 1100;
            double P;
            int monthcounter = 0;
            P = Convert.ToDouble(Console.ReadLine());
            do
            {
                deposit = deposit + (deposit * P / 100);
                monthcounter++;
                Console.WriteLine(deposit);
            } while (deposit < finishdeposit);
            Console.WriteLine("Finish deposit {0} at percent = {1}. Month = {2}", deposit, P, monthcounter);
        }
    }
}
