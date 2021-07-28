using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc
{
    public struct StFigure
    {
        public int SideNumber { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double S { get; set; }


        public StFigure(double a, double b, double c) : this()
        {
           
            SideA = a;
            SideB = b;
            SideC = c;

        }
    }
}
