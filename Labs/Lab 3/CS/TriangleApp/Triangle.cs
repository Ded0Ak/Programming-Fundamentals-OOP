using System;

namespace TriangleLibrary
{
    public class Triangle
    {
        private double x1, y1, x2, y2, x3, y3;

        public Triangle()
        {
            x1 = y1 = 0;
            x2 = 1; y2 = 0;
            x3 = 0; y3 = 1;
        }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1; this.y1 = y1;
            this.x2 = x2; this.y2 = y2;
            this.x3 = x3; this.y3 = y3;
        }

        public Triangle(Triangle other)
        {
            x1 = other.x1; y1 = other.y1;
            x2 = other.x2; y2 = other.y2;
            x3 = other.x3; y3 = other.y3;
        }

        public double Perimeter()
        {
            double a = Distance(x1, y1, x2, y2);
            double b = Distance(x2, y2, x3, y3);
            double c = Distance(x3, y3, x1, y1);
            return a + b + c;
        }
        public double Area()
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        public static Triangle operator +(Triangle t1, Triangle t2)
        {
            return new Triangle(
                t1.x1 + t2.x1, t1.y1 + t2.y1,
                t1.x2 + t2.x2, t1.y2 + t2.y2,
                t1.x3 + t2.x3, t1.y3 + t2.y3
            );
        }

        public static Triangle operator *(Triangle t, double scalar)
        {
            return new Triangle(
                t.x1 * scalar, t.y1 * scalar,
                t.x2 * scalar, t.y2 * scalar,
                t.x3 * scalar, t.y3 * scalar
            );
        }

        public override string ToString()
        {
            return $"P={Perimeter():F2}, A={Area():F2}";
        }

        private double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}