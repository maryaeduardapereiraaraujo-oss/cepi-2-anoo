using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maryaatividades1
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C);
            //double raiz = Math,Sqrt
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
