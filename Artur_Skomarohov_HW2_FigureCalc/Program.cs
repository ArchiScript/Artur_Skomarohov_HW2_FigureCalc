using System;

namespace FigureCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Классы
            Figure triangle1 = new Figure(3, 4, 3);
            
            Figure triangle2 = CreateFigureFrom(triangle1);
            Console.WriteLine("Площадь первичного треугольника: " + triangle1.S);
            ChangeS(triangle2);
            Console.WriteLine("Измененная площадь первичного треугольника: " + triangle1.S);
            Console.WriteLine(triangle2.S);
            //Структруры
            StFigure stTriangle1 = new StFigure(4, 5, 4);
            StFigure stTriangle2 = CreateStFigureFrom( ref stTriangle1);
            Console.WriteLine(stTriangle1.S);
            ChangeStS( ref stTriangle1);
            Console.WriteLine(stTriangle1);
            Console.WriteLine(stTriangle2);



        }

        // Рассчет площади треугольника 
        public static double Calc(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return S;

        }

        //Метод принимает экземпляр тр., рассчит S и создает другой тр.
        public static Figure CreateFigureFrom(Figure triangle)
        {

            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            triangle.S = Calc(a, b, c);
            Figure triangle2 = new Figure(4, 5, 4);
            return triangle2;
        }

        // Метод принимает экз. тр, рассч S и меняет S тр.
        public static void ChangeS(Figure triangle)
        {
            double a = triangle.SideA;
            double b = triangle.SideB;
            double c = triangle.SideC;
            triangle.S = Calc(a, b, c);


        }
        public static  StFigure CreateStFigureFrom( ref StFigure stTriangle)
        {
            double a = stTriangle.SideA;
            double b = stTriangle.SideB;
            double c = stTriangle.SideC;
            Calc(a, b, c);
            StFigure stTriangle2 = new StFigure(4, 5, 5);

            return stTriangle2;

        }
        public static void ChangeStS( ref StFigure stTriangle)
        {
            double a = stTriangle.SideA;
            double b = stTriangle.SideB;
            double c = stTriangle.SideC;
            double S = Calc(a, b, c);
            stTriangle.S = S;

        }

    }
}
