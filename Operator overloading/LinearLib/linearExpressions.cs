using System;

namespace LinearLib
{
    public class linearExpressions
    {
        public int a;
        public int b;
        public static string str = "";

        public void Get()
        {
            str = Console.ReadLine();
            Parse();
        }


        private void Parse()
        {

                string a_str = "", b_str = "";
                bool key = true;

                foreach (var i in str)
                {

                    if (i != ',' && i != ' ')
                {

                        if (key == true)
                        {
                            a_str += Convert.ToString(i);
                        }
                        else
                        {
                            b_str += Convert.ToString(i);
                        }

                    }

                    else

                    {
                        key = false;
                    }
               
                }
            a = Convert.ToInt32(a_str);
            b = Convert.ToInt32(b_str);
        }

        public void Print()
        {
            Console.WriteLine($"{a} * X + {b} * Y = 0");
        }

        public static int operator +(linearExpressions fistLine, linearExpressions secondLine)
        {
            int delta, delta1, delta2;
            delta = fistLine.a * secondLine.b - secondLine.a * fistLine.b;
            return delta;

        }
    }
}
