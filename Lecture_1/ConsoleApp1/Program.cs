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
            int warresult = 0;
            bool result;
            for (int i = 0; i < 5; i++)
            {
                T34 t1 = new T34 { };
                Pantera t2 = new Pantera { };

                result = t1 ^ t2;
                //t1.parameters();
                //t2.parameters();
                if (result)
                    warresult++;
                Console.WriteLine($"First tank win? {result}");
            }
            Console.WriteLine();
            if (warresult>=3)
                Console.WriteLine($"First tank win in war");
            else
                Console.WriteLine($"Second tank win in war");
        }
    }
}
