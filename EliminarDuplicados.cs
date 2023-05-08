using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class EliminarDuplicados : Ejercicio
    {
        public EliminarDuplicados()
        {
            List<int> numeros = PedirListaInt();

            List<int> numerosSinDuplicados = new List<int>();

            foreach (int numero in numeros)
            {
                if (!numerosSinDuplicados.Contains(numero))
                {
                    numerosSinDuplicados.Add(numero);
                }
            }

            Console.WriteLine("Números originales: " + string.Join(", ", numeros));
            Console.WriteLine("Números originales: " + string.Join(", ", numeros));

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
