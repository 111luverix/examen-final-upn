using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_2
{
    class Program
    {
        static int n1, n2, op = 0, opD = 0;
        static void Main(string[] args)
        {
            leer();
            do
            {
                Console.WriteLine("Ingrese una opcion ");
                Console.WriteLine("[A] Binarios ");
                Console.WriteLine("[B] Decimales ");
                Console.WriteLine("[C] Salir ");
                char opG = char.Parse(Console.ReadLine());

                switch (opG)
                {
                    case 'A': MenuB(); break;
                    case 'B': MenuD(); break;
                    default:
                        Console.WriteLine("Opción invalida");
                        break;
                }

            } while (op != 6);
        }

        private static void MenuD()
        {
            Console.WriteLine("Ingrese una opción: ");
            Console.WriteLine("[1] Mostrar");
            Console.WriteLine("[2] sumar");
            Console.WriteLine("[3] restar");
            Console.WriteLine("[4] multiplicar");
            Console.WriteLine("[5] dividir");
            Console.WriteLine("[6] salir");

            opcionesD();
        }
        public static void opcionesD()
        {
            do
            {
                opD = int.Parse(Console.ReadLine());

                switch (opD)
                {
                    case 1: MostrarD(n1); MostrarD(n2); break;
                    case 2: MostrarD(n1 + n2); break;
                    case 3: MostrarD(n1 - n2); break;
                    case 4: MostrarD(n1 * n2); break;
                    case 5: MostrarD(n1 / n2); break;
                    case 6:
                        Console.WriteLine("Saliendo....");
                        Environment.Exit(1);
                        break;
                    default: Console.WriteLine("Opción inválida"); break;
                }
                MenuD();
            } while (opD != 6);
        }

        private static void MostrarD(int x)
        {
            Console.WriteLine("El elemento es:" + x);
        }

        public static void leer()
        {
            Console.WriteLine("Ingrese 2 números");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
        }

        public static void MenuB()
        {
            Console.WriteLine("Ingrese una opción: ");
            Console.WriteLine("[1] Mostrar los números en binario");
            Console.WriteLine("[2] sumar");
            Console.WriteLine("[3] restar");
            Console.WriteLine("[4] multiplicar");
            Console.WriteLine("[5] dividir");
            Console.WriteLine("[6] salir");

            opcionesB();
        }
        public static void opcionesB()
        {
            do
            {
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: MostrarB(n1); MostrarB(n2); break;
                    case 2: MostrarB(n1 + n2); break;
                    case 3: MostrarB(n1 - n2); break;
                    case 4: MostrarB(n1 * n2); break;
                    case 5: MostrarB(n1 / n2); break;
                    case 6:
                        Console.WriteLine("Saliendo....");
                        Environment.Exit(1);
                        break;
                    default: Console.WriteLine("Opción inválida"); break;
                }
            } while (op != 6);
        }

        public static void MostrarB(int num)
        {
            Console.WriteLine("{0} en binario es {1}", num, Convert.ToString(num, 2));
        }
    }
}
