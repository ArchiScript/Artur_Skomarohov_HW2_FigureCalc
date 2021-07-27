using System;

namespace FigureCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle(3, 3, 4, 3);
            Console.WriteLine(triangle.S);
            Calc(triangle);
            Calc2(triangle);
        }
        public static object Calc(Triangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Triangle triangle2 = new Triangle(3, a, b, c);
            return triangle2;


        }
        public static void Calc2(Triangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            triangle.S = S;
            Console.WriteLine(triangle.S);
            
        }
        public static object StCalc(StTriangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Triangle triangle2 = new Triangle(3, a, b, c);
            return triangle2;


        }
        public static void StCalc2(StTriangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            triangle.S = S;
            Console.WriteLine(triangle.S);

        }

    }
}
