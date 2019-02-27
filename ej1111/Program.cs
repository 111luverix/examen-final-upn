using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN_EJERCICIO_1
{
    class Program
    {
        static int[,] matriz;
        static int numF, numC;
        static void Main(string[] args)
        {
            Leer();
            Rellenar_0();
            Menú();
        }

        public static void Leer()
        {
            Console.WriteLine("Ingrese su nombre de usuario");
            String nom = Console.ReadLine();
            Console.WriteLine("ingrese número de filas");
            numF = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese número de columnas");
            numC = int.Parse(Console.ReadLine());
        }

        public static void Rellenar_0()
        {
            matriz= new int[numF, numC];
            for (int i = 0; i < numF; i++)
            {
                for (int y = 0; y < numC; y++)
                {
                    matriz[i, y] = 0;
                }
            }
        }

        public static void Menú()
        {
            int op;
            Console.WriteLine("Ingrese una opción");
            Console.WriteLine("[1] Mostrar la matriz.");
            Console.WriteLine("[2] Rellenar la matriz de números binarios.");
            Console.WriteLine("[3] Rellenar la matriz de números aleatorios.");
            Console.WriteLine("[4] Editar un elemento por su ubicación.");
            Console.WriteLine("[5] Editar un elemento por su nombre.");
            Console.WriteLine("[6] Cambiar todos los elementos de la matriz.");
            Console.WriteLine("[7] Salir.");
            do
            {
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:Mostrar();break;
                    case 2:Rellenar_Binarios();break;
                    case 3:Rellenar_Aleatorios();break;
                    default:
                        break;
                }
            } while (op!=7);

        }

        public static void Mostrar()
        {
            for (int i = 0; i < numF; i++)
            {
                Console.Write("{ ");
                for (int y = 0; y < numC; y++)
                {
                    Console.Write(matriz[i, y]+" ");
                }
                Console.Write("}");
                Console.WriteLine();
            }
        }

        public static void Rellenar_Binarios()
        {
            Console.WriteLine("Rellenado de binarios");
            Random aleatorio = new Random();
            for (int i = 0; i < numF; i++)
            {
                for (int y = 0; y < numC; y++)
                {
                    matriz[i, y] = aleatorio.Next(0,2);
                }
            }
        }

        public static void Rellenar_Aleatorios()
        {
            
        }
    }
}
