using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<string> Wins = new List<string>();
            int warresult = 0;
            bool result;

            for (int i = 1; i < 6; i++)
            {
                T34 t1 = new T34 { };
                Pantera t2 = new Pantera { };
                result = t1 ^ t2;

                if (result)
                {
                    Wins.Add(t1.model);
                    warresult++;
                }
                else
                    Wins.Add(t2.model);

            }

            Wins.Sort();
            foreach (string i in Wins)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            if (warresult>=3)
                Console.WriteLine($"First tank win in war");
            else
                Console.WriteLine($"Second tank win in war");
        }
    }
}
