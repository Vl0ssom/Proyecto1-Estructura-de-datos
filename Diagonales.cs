using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura
{
    internal class Diagonales
    {
        public static int[,] matriz = new int[5, 5];
        

        public static void creacíonNumeros()
        {
        Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rnd.Next(1, 10);
                }
            }
            Console.WriteLine("La matriz se ha generado correctamente.");
            Console.WriteLine();
        }
        public static int sumarPrimeraDiagonal()
        {
            int primeraDiagonal = 0;
            for (int i = 0; i < 5; i++)
            {
                primeraDiagonal += matriz[i, i];

            }
            return primeraDiagonal;
        }

        public  static int sumarSegundaDiagonal()
        {
            int segundaDiagonal = 0;
            for (int i = 0; i < 5; i++)
            {
                segundaDiagonal += matriz[i, 4 - i];
            }

            return segundaDiagonal;
        }

        public static void MostrarMatriz()
        {
            Console.Write("Matriz generada:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <5; j++)
                {
                    Console.WriteLine($"{matriz[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Para salir presione enter.");
        }

        public static void MostrarSumaDiagonales ()
        {
            int sumaPrimeraDiagonal = sumarPrimeraDiagonal();
            int sumaSegundaDiagonal = sumarSegundaDiagonal();
            Console.WriteLine("Suma de la primera diagonal principal: " + " " + sumaPrimeraDiagonal);
            Console.WriteLine("Suma de la segunda diagonal principal:" + " " + sumaSegundaDiagonal);            
        }

        public static void MenuDiagonales()

        {
            int opcion;
            bool salir = false;

            do
            {
                Console.WriteLine("1. Llenar la matriz ");
                Console.WriteLine("2. Sumar diagonales ");
                Console.WriteLine("3. Mostrar la matriz ");
                Console.WriteLine("4. Regresar al menú principal");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        creacíonNumeros();
                        break;
                    case 2:                            
                            MostrarSumaDiagonales();
                        break;
                    case 3: MostrarMatriz();  
                            Console.ReadLine();
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Por favor, selecciona otra.");
                        Console.WriteLine();
                        break;
                }
            } while (!salir);
        }
    }
}
