using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class T34 : Tank
    {
        Random rnd = new Random();

        public T34(string model = "T34") : base(model)
        {
            this.ammunitions = rnd.Next(4, 100);
            this.armor = rnd.Next(4, 100);
            this.mobility = rnd.Next(4, 100);
        }
        public void parameters()
            {
            Console.WriteLine($"{model}, ammu={ammunitions}, armo = {armor}, mobi = {mobility}");
               }
    }
}
