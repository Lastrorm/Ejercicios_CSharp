using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class Ejercicio
    {
        public List<int> PedirListaInt()
        {
            List<int> lista = new List<int>();
            int num;

            do
            {
                Console.Write("Inserta un número entero (Introduce 0 para terminar): ");

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    lista.Add(num);
                }
                else
                {
                    Console.WriteLine("Valor no válido");
                    num = -1;
                }
            } while (num != 0);

            return lista;
        }

        public List<string> PedirListaString()
        {
            List<string> lista = new List<string>();
            string cadena;
            do
            {

                Console.Write("Inserta una cadena de caracteres (Deja vacío para terminar): ");
                cadena = Console.ReadLine();

            } while (cadena != "");

            return lista;
        }

        public List<double> PedirListaDouble()
        {
            List<double> lista = new List<double>();
            double num;

            do
            {
                Console.Write("Inserta un número (Introduce 0 para terminar): ");

                if (double.TryParse(Console.ReadLine(), out num))
                {
                    lista.Add(num);
                }
                else
                {
                    Console.WriteLine("Valor no válido");
                    num = -1;
                }
            }while (num != 0);

            return lista;
        }
    }
}
