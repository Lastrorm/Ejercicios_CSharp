using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class OrdenarLista : Ejercicio
    {
        public OrdenarLista()
        {
            List<string> nombres = PedirListaString();

            nombres.Sort();

            Console.WriteLine("Lista ordenada alfabéticamente:");

            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
