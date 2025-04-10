using System;

namespace FiguresLib
{
    public class Square : Figure
    {
        public Square() { }

        public Square((double, double) a, (double, double) b,
                      (double, double) c, (double, double) d)
            : base(a, b, c, d) { }

        public double Area => SideLength * SideLength;
        public double Perimeter => 4 * SideLength;
    }
}