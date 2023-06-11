using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura
{
    internal class Menu
    {
        public static void menu()

        {
            byte opcion = 0;

            do
            {
                Console.WriteLine("1. Creación de matriz con suma en esquinas. ");
                Console.WriteLine("2. Creación de matriz con suma en diagonales. ");
                Console.WriteLine("3. Creación y modificación de proveeduría. ");             
                Console.WriteLine("4. Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = byte.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                            Esquinas.MenuEsquinas();
                        break;
                    case 2: Diagonales.MenuDiagonales();
                       
                        break;
                    case 3:
                        Proveeduria.menuProveeduria(); 
                        break;
                    case 4:
                        System.Environment.Exit(0);                                       
                        break;
                    default:
                        break;

                }
            } while (opcion != 4);
        }
    }
}
