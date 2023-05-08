using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class Palindromo : Ejercicio
    {
        public Palindromo()
        {
            Console.Write("Ingrese una palabra o frase: ");
            string? texto = Console.ReadLine();
            if (texto == null)
            {
                Console.Write("Texto invalido");
                return;
            }
            texto = texto.ToLower().Replace(" ", "");
            bool palindromo = true;
            for (int i = 0; i < texto.Length / 2; i++)
            {
                if (texto[i] != texto[texto.Length - 1 - i])
                {
                    palindromo = false;
                    break;
                }
            }

            if (palindromo)
            {
                Console.WriteLine("La cadena es un palíndromo");
            }
            else
            {
                Console.WriteLine("La cadena no es un palíndromo");
            }

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
