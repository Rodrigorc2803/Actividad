using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class GeneradorFibonacci : GeneradorDeNumero
    {
        public override int ObtenerNumero(int n)
        {
            int a = 0, b = 1, c = 0;
            if (n == 0) return a;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return b;
        }
    }
}
