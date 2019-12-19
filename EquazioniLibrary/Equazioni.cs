using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risposta = false;
            if (a != 0)
                risposta = true;
            return risposta;
        }
        public static bool IsInconsisted(double a)
        {
            bool risposta2 = false;
            if (a == 0)
                risposta2 = true;
            return risposta2;
        }
        public static bool IsDegree2(double a)
        {
            bool risposta3 = false;
            if (a == 0)
                risposta3 = true;
            return risposta3;
        }
        public static double Delta(double a,double b, double c)
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }
        public static double EquationDegree1(double a, double b)
        {
            if(a==0&&b==0)
            {
                Console.WriteLine("indeterminato");
            }
            else if(a!=0&&b==0)
            {
                Console.WriteLine("impossibile");
            }
            else
            {
                double x = -b/a;
                return x;
            }
            return 0;
        }
    }
}
