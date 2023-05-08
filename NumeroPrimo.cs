using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class NumeroPrimo : Ejercicio
    {
        public NumeroPrimo()
        {
            int num = 0, i;
            bool esPrimo = true;

            Console.Write("Introduce un número entero positivo: ");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Número invalido");
                return;
            }

            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }

            if (esPrimo)
                Console.WriteLine("{0} es un número primo", num);
            else
                Console.WriteLine("{0} no es un número primo", num);

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
