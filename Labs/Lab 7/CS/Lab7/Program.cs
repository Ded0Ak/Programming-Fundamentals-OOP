using System;

namespace ExpressionEvaluation
{
    public class Expression
    {
        private double a, b, c, d;

        public Expression(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double A => a;
        public double B => b;
        public double C => c;
        public double D => d;

        private double CalculateRoot(double value)
        {
            if (value < 0)
                throw new ArgumentException("Invalid value for square root.");

            return Math.Sqrt(value);
        }

        public double CalculateExpression()
        {
            try
            {
                double numerator = a * b / 4 - 1;
                double denominatorExpression = 41 - d - b * a + c;
                double denominator = CalculateRoot(denominatorExpression);

                return numerator / denominator;
            }
            catch (Exception ex)
            {
                throw new Exception("Error calculating expression: " + ex.Message);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Expression[] expressions = {
                new Expression(10, 5, 2, 1),
                new Expression(3, 6, 1, 40),
                new Expression(4, 4, 3, 10)
            };

            foreach (var expr in expressions)
            {
                try
                {
                    double result = expr.CalculateExpression();
                    Console.WriteLine($"Result: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception: {e.Message}");
                }
            }
        }
    }
}
