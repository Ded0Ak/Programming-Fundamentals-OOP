using System;

namespace FiguresLib
{
    public class Figure
    {
        protected (double x, double y) a, b, c, d;

        public Figure() { }

        public Figure((double, double) a, (double, double) b, (double, double) c, (double, double) d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double SideLength => Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
    }
}