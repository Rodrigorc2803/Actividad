using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1
{
    public class GeneradorPrimoYPerfecto : GeneradorDeNumero
    {
        private bool buscarPrimo;

        public GeneradorPrimoYPerfecto(bool buscarPrimo)
        {
            this.buscarPrimo = buscarPrimo;
        }

        public override int ObtenerNumero(int n)
        {
            int contador = 0;
            int num = 2;
            while (contador < n)
            {
                if (buscarPrimo && EsPrimo(num) || !buscarPrimo && EsPerfecto(num))
                {
                    contador++;
                }
                num++;
            }
            return num - 1;
        }
    }
}
