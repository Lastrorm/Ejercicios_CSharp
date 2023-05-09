using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class Anagrama : Ejercicio
    {
        public Anagrama()
        {
            string? palabra1 = "";
            string? palabra2 = "";

            Console.Write("Escribe la primera palabra: ");
            palabra1 = Console.ReadLine();

            Console.Write("Escribe la segunda palabra: ");
            palabra2 = Console.ReadLine();

            char[] letras1 = {};
            char[] letras2 = {};

            if(palabra1 is not null && palabra2 is not null)
            {
                letras1 = palabra1.ToLower().ToCharArray();
                letras2 = palabra2.ToLower().ToCharArray();
            }
            

            Array.Sort(letras1);
            Array.Sort(letras2);

            bool sonAnagramas = letras1.SequenceEqual(letras2);

            if (sonAnagramas)
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
            }
            else
            {
                Console.WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
            }

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
