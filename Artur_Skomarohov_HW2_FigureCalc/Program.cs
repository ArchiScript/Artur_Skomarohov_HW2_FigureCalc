using System;

namespace FigureCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Обявление нового экземпляра класса треугольник
            Triangle triangle1 = new Triangle(3, 3, 4, 3);


            // Обявление нового экземпляра структуры треугольник
            StTriangle stTriangle = new StTriangle(3, 4, 5, 4);


            double test = CreateTriangleFrom(triangle1).SideA;
            Console.WriteLine(test);
            //Console.WriteLine(Calc(triangle.S));
            /*Console.WriteLine(StCalc( ref stTriangle));*/

        }

        // Рассчет площади треугольника
        public static double Calc(int sides, double a, double b, double c)
        {

            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;
        }

        //Метод принимает экземпляр тр., рассчит S и создает другой тр.
        public static Triangle CreateTriangleFrom(Triangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double S = Calc(a, b, c);
            triangle.S = S;

            Triangle triangle2 = new Triangle(3, 4, 5, 5);
            return triangle2;
        }

        // Метод принимает экз. тр, рассч S и меняет S первого тр.
        public static void ChangeS(Triangle triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            double S = Calc(a, b, c);
            triangle.S = S;

            
            

        }
        public static Triangle CreateStTriangleFrom(ref StTriangle stTriangle)
        {
            double a = stTriangle.SideA;
            double b = stTriangle.SideB;
            double c = stTriangle.SideC;
            Calc(a, b, c);
            Triangle stTriangle2 = new Triangle(3, 4, 5, 5);

            return stTriangle2;


        }
        public static void ChangeStS(ref StTriangle stTriangle)
        {
            double a = stTriangle.SideA;
            double b = stTriangle.SideB;
            double c = stTriangle.SideC;
            double S = Calc(a, b, c);
            stTriangle.S = S;

        }

    }
}
