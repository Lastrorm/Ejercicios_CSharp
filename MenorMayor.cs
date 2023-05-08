using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class MenorMayor : Ejercicio
    {
        public MenorMayor()
        {

            List<int> numeros = PedirListaInt();
            int mayor = numeros[0];
            int menor = numeros[0];

            foreach (int numero in numeros)
            {
                if (numero > mayor)
                {
                    mayor = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine("El mayor número es: " + mayor);
            Console.WriteLine("El menor número es: " + menor);

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
