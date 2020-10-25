using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Tank
    {
        public string model { get; set; }
        public int ammunitions;
        public int armor;
        public int mobility;

        public Tank(string model)
            { 
            this.model = model;

        }

        public static bool operator ^(Tank T1, Tank T2)
        {
            int count = 0;
            if (T1.ammunitions > T2.ammunitions)
                ++count;
            else
                --count;

            if (T1.armor > T2.armor)
                ++count;
            else
                --count;
            if (T1.mobility > T2.mobility)
                ++count;
            else
                --count;

            if (count >= 1)
                return true;
            else
                return false;
        }
    }

}
