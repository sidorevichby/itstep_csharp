using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Pantera :Tank
    {
        Random rnd = new Random();

        public Pantera(string model = "Pantera") : base(model)
        {
            this.ammunitions = rnd.Next(0, 100);
            this.armor = rnd.Next(0, 100);
            this.mobility = rnd.Next(0, 100);
        }
        public void parameters()
        {
            Console.WriteLine($"{model}, ammu={ammunitions}, armo = {armor}, mobi = {mobility}");
        }
    }
}
