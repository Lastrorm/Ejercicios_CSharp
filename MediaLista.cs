using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class MediaLista : Ejercicio
    {
        public MediaLista()
        {
            List<int> numeros = PedirListaInt();
            double media = numeros.Average();
            Console.WriteLine("La media es: " + media);

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
