using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosSalaSeparada2
{
    internal class AnyoBisiesto : Ejercicio
    {
        public AnyoBisiesto()
        {
            Console.Write("Ingrese un año: ");
            int anio = 0;
            if (int.TryParse(Console.ReadLine(), out anio))

                if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
                {
                    Console.WriteLine(anio + " es un año bisiesto");
                }
                else
                {
                    Console.WriteLine(anio + " no es un año bisiesto");
                }
            else
                Console.WriteLine("Ha entrado un año incorrecto");

            Console.Write("Pulsa una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
