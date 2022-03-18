using System;

namespace C_sharp_fundamentals
{
    class Program
    {
        // y = I - (f ^ n[(s.l) / f + (20 / f) ^ w]) / 20 ^ n
        static void Main(string[] args)
        {
            double y = 0.0;
            double f = 0.0;
            double n = 0.0;
            double I = 0.0;
            double w = 0.0;
            double l = 0.0;
            double b = Math.Pow(f, n);
            double r = Math.Pow(20, n);
            double q = 20 / f;
            double s = Math.Pow(q, w);

            y = I - b((s * l) / f + r * s);) / r;

        }
    }
}
