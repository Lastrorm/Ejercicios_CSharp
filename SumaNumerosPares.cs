using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class SumaNumerosPares : Ejercicio
    {
        public SumaNumerosPares()
        {
            List<int> numeros = PedirListaInt();
            int suma = 0;

            foreach (int num in numeros)
            {
                if (num % 2 == 0)
                    suma += num;
            }

            Console.WriteLine("La suma de los números pares es {0}", suma);

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
