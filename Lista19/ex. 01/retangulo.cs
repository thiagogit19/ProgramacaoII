using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._01
{
    class retangulo
    {
        private double b, h;

        public retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public double GetBase()
        {
            return b;
        }

        public double GetAltura()
        {
            return h;
        }

        public double CalcArea()
        {
            return b * h;
        }

        public double CalcDiagonal()
        {
            double x = Math.Sqrt(Math.Pow(b, 2) + Math.Pow(h, 2));
            return x;
        }

        public override string ToString()
        {
            return $"{b} - {h} - {CalcArea()} - {CalcDiagonal()}";
        }
    }
}
