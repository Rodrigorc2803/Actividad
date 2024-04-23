using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public abstract class GeneradorDeNumero
    {
        public abstract int ObtenerNumero(int n);

        protected static bool EsPrimo(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        protected static bool EsPerfecto(int num)
        {
            int suma = 1;
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    suma += i;
                    if (i != num / i) suma += num / i;
                }
            }
            return suma == num && num != 1;
        }
    }
}
