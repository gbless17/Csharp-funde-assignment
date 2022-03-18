using System;

namespace Number_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int c = 30;

            if( a == b && c > a + b - c)
            {
                a = c - b;
            }
           
            Console.WriteLine("a is {0}",a);
        }
    }
}
