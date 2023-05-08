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
            string palabra1 = "roma";
            string palabra2 = "amor";

            char[] letras1 = palabra1.ToLower().ToCharArray();
            char[] letras2 = palabra2.ToLower().ToCharArray();

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
