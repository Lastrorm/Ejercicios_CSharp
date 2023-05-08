namespace EjerciciosSalaSeparada2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opc;

            do
            {
                opc = Menu();
                Console.Clear();

                switch (opc)
                {
                    case 1:
                        new MenorMayor();
                        break;
                    case 2:
                        new ParImpar();
                        break;

                    case 3:
                        new AnyoBisiesto();
                        break;

                    case 4:
                        new Palindromo();
                        break;

                    case 5:
                        new OrdenarLista();
                        break;

                    case 6:
                        new Factorial();
                        break;

                    case 7:
                        new NumeroPrimo();
                        break;

                    case 8:
                        new AreaVolumenCubo();
                        break;

                    case 9:
                        new SumaNumerosPares();
                        break;

                    case 10:
                        new NumeroPositivoNegativoCero();
                        break;

                    case 11:
                        new MediaLista();
                        break;

                    case 12:
                        new AdivinarNumero();
                        break;

                    case 13:
                        new Anagrama();
                        break;

                    case 14:
                        new EliminarDuplicados();
                        break;

                    case 15:
                        new Capicua();
                        break;
                }
            } while (opc != 16);

        }

        static int Menu()
        {

            int opc;

            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("|            MENÚ          |");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Menor/Mayor.");
            Console.WriteLine("2 - Par/Impar.");
            Console.WriteLine("3 - Año Bisiesto.");
            Console.WriteLine("4 - Palíndromo.");
            Console.WriteLine("5 - Ordenar nombres alfabéticamente.");
            Console.WriteLine("6 - Factorial.");
            Console.WriteLine("7 - Número primo.");
            Console.WriteLine("8 - Área y volumen de un cubo.");
            Console.WriteLine("9 - Sumatorio de números pares.");
            Console.WriteLine("10 - Número positivo o negativo.");
            Console.WriteLine("11 - Media aritmética.");
            Console.WriteLine("12 - Juego de adivinar el número.");
            Console.WriteLine("13 - Anagrama.");
            Console.WriteLine("14 - Eliminar números duplicados.");
            Console.WriteLine("15 - Número capicua.");
            Console.WriteLine("16 - SALIR.");
            Console.WriteLine();

            string temp = "Introduzca una opción y pulse <ENTER>: ";

            do
            {
                Console.Write(temp);
                int.TryParse(Console.ReadLine(), out opc);
                temp = "***Opción incorrecta***, introduzca un valor entre 1 y 15: ";
            } while (opc < 1 || opc > 16);

            return opc;
        }
    }
}