using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
     class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area;

        public double CalcArea(double a1, double b1, double c1)
        {
            double p = (a1 + b1 + c1) / 2;

            double area = Math.Sqrt(p * (p - a1) *(p - b1) *(p-c1) );

            return area;   
        }
    }
}
