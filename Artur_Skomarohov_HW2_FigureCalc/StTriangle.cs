using System;
using System.Collections.Generic;
using System.Text;

namespace FigureCalc
{
    struct StTriangle
    {
        public double SideNumber { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double S { get; set; }


        public StTriangle(double sides, double a, double b, double c)
        {
            SideNumber = sides;
            SideA = a;
            SideB = b;
            SideC = c;

        }
    }
}
