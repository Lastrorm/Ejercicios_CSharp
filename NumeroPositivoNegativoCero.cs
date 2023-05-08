using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class NumeroPositivoNegativoCero : Ejercicio
    {
        public NumeroPositivoNegativoCero()
        {

            int num;

            Console.Write("Introduce un número entero: ");
            if (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Número invalido");
                return;
            }

            if (num > 0)
                Console.WriteLine("{0} es un número positivo", num);
            else if (num < 0)
                Console.WriteLine("{0} es un número negativo", num);
            else
                Console.WriteLine("{0} es cero", num);

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
