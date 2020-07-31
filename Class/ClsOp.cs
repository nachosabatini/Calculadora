using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Class
{
    class ClsOp
    {
        public double Dividir(double N1, double N2)
        {
            double S = N1 / N2;
            return S;
        }

        public double Multiplicar(double N1, double N2)
        {
            double S = N1 * N2;
            return S;
        }

        public double Restar(double N1, double N2)
        {
            double S = N1 - N2;
            return S;
        }

        public double Sumar(double N1, double N2)
        {
            double S = N1 + N2;
            return S;
        }
        public double Fact(double N1)
        {
            double S=1;
            int i = 1;
            while (i <= N1)
            {
                S = S * i;
                i++;
            }
            return S;

        }
    }

}
