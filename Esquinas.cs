using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura
{
    internal class Esquinas
    {
        public static int [,] Matriz = new int[5, 5];//se instancia la matriz


        public static void llenarMatriz()
        {
            Random random = new Random();
            //Se rellena la matriz
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Matriz[fila, columna] = random.Next(1, 100); //Aqui se generan los numeros de forma aleatoria del 1 al 100
                }
                
            }
            Console.WriteLine("La matriz se ha llenado correctamente.");
        }
        public static void sumaEsquinas()
        {
            //Ciclo para imprimir la matriz
            for (int fila = 0; fila < 5; fila++)
            {
                for (int columna = 0; columna < 5; columna++)
                {
                    Console.Write(Matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }
            int Sumatoria = Matriz[0, 0] + Matriz[0, 4] + Matriz[4, 0] + Matriz[4, 4];
            Console.WriteLine("La sumatoria de las esquinas del vector es de: " + Sumatoria);

        }
        public static void MenuEsquinas()

        {
            int opcion;
            bool salir = false;

            do
            {
                Console.WriteLine("1. Llenar la matriz");
                Console.WriteLine("2. Sumar esquinas");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        llenarMatriz();
                        break;
                    case 2:
                        sumaEsquinas();
                        break;
                    case 3:
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
