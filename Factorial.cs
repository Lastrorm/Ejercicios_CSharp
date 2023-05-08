using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class Factorial : Ejercicio
    {
        public Factorial()
        {
            int num = 0, factorial = 1;

            Console.Write("Introduce un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out num))
            {

                for (int i = 1; i <= num; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine("El factorial de {0} es {1}", num, factorial);
            }
            else
                Console.WriteLine("Número inválido");

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
