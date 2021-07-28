using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc
{
    public class Figure
    {
        public  int Sides { get; set; }
        public  double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double S { get; set; }


        public Figure(double a, double b, double c)
        {
            
            SideA = a;
            SideB = b;
            SideC = c;

        }

    }

}
