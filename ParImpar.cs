using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class ParImpar : Ejercicio
    {
        public ParImpar()
        {
            int numero = 0;
            Console.Write("Ingrese un número entero: ");
            if (int.TryParse(Console.ReadLine(), out numero))
                if (numero % 2 == 0)
                {
                    Console.WriteLine("El número es par");
                }
                else
                {
                    Console.WriteLine("El número es impar");
                }
            else
            {
                Console.WriteLine("Ha entrado un número erroneo");
            }

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
