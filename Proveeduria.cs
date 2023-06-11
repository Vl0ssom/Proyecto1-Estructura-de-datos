using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_1_Estructura
{
    internal class Proveeduria
    {
        public static float[] articulos = new float[1];
        public static string[] nombre = new string[1];
        public static string[] ciudad = new string[1];

        public static void menuProveeduria()
        {
            string op = "";
            do
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar un nuevo proveedor");
                Console.WriteLine("2. Consultar un proveedor");
                Console.WriteLine("3. Actualizar el nombre de la ciudad");
                Console.WriteLine("4. Actualizar el numero de articulos");
                Console.WriteLine("5. Borrar un proveedor");
                Console.WriteLine("6. Salir");
                Console.Write("Digite una opcion: ");
                op = Console.ReadLine().ToLower();
                switch (op)
                {
                    case "1": IngresarP(); break;
                    case "2": ConsultaP(); break;
                    case "3": ModificarC(); break;
                    case "4": ModificarA(); break;
                    case "5": Borrar(); break;
                    case "6": break;
                    default:
                        Console.WriteLine("Opcion no es valida");
                        break;
                }
            } while (!op.Equals("6"));
        }
        public static void IngresarP()
        {
            for (int i = 0; i < articulos.Length; i++)
            {
                Console.Write("Digite el nombre: ");
                nombre[i] = Console.ReadLine();
                Console.Write("Digite la ciudad: ");
                ciudad[i] = Console.ReadLine();
                Console.Write("Digite el numero de articulos: ");
                articulos[i] = float.Parse(Console.ReadLine());
            }
        }
        public static void ConsultaP()
        {
            String nombProveedor = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de proveedor");
            nombProveedor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (nombre[i].Equals(nombProveedor))
                {
                    Console.Clear();

                    Console.WriteLine("El numero de articulos que provee es: " + articulos[i] + " y su ciudad es " + ciudad[i]);
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("El proveedor no existe");
            }
            Console.Read();
        }
        public static void ModificarC()
        {
            String nombProveedor = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de proveedor");
            nombProveedor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (nombre[i].Equals(nombProveedor))
                {
                    Console.Clear();
                    Console.Write("Actualice la ciudad: ");
                    ciudad[i] = Console.ReadLine();
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Proveedor no existe");
            }
        }
        public static void ModificarA()
        {
            String nombProveedor = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de proveedor");
            nombProveedor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (nombre[i].Equals(nombProveedor))
                {
                    Console.Clear();
                    Console.Write("Actualice el numero de articulos: ");
                    articulos[i] = float.Parse(Console.ReadLine());
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Proveedor no existe");
            }
        }
        public static void Borrar()
        {
            String nombProveedor = "";
            Boolean Existe = false;
            Console.WriteLine("Digite un nombre de proveedor");
            nombProveedor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (nombre[i].Equals(nombProveedor))
                {
                    Console.Clear();
                    Console.WriteLine("Se ha eliminado el siguiente proveedor:");
                    Console.WriteLine("Nombre: " + nombre[i]);
                    Console.WriteLine("Ciudad: " + ciudad[i]);
                    Console.WriteLine("Articulos: " + articulos[i]);
                    nombre[i] = null;
                    ciudad[i] = null;
                    articulos[i] = 0;
                    Existe = true;
                    break;
                }

            }

            if (Existe == false)
            {
                Console.Clear();
                Console.WriteLine("Proveedor no existe");
            }
        }

    }
}
