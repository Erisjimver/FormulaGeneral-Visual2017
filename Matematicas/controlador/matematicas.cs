using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematicas.controlador
{
    class matematicas
    {
        double a, b, c, x, x1;
        double primerb,elev,raiz,denraiz,multiraiz,infe;

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }
        public double X { get => x; set => x = value; }
        public double X1 { get => x1; set => x1 = value; }

        public void formulaGeneral()
        {
            Console.WriteLine("Si entro");
            elev = Math.Pow(b, 2);
            multiraiz = 4*(a * c);
            infe = 2 * a;
            denraiz = elev - multiraiz;
            raiz = Math.Sqrt(denraiz);
            primerb = (-(b));
            x = (primerb + raiz) / infe;
            x1= (primerb - raiz) / infe;
            a = x;
            Console.WriteLine("llego hasta aca"+denraiz);
        }
    }
}
