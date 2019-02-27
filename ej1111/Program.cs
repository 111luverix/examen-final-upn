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
        static string nom;
        static int numF, numC;
        static void Main(string[] args)
        {
            Leer();
            Rellenar_0();
            Menú();
            Console.ReadKey();
        }

        public static void Leer()
        {
            Console.WriteLine("Ingrese su nombre de usuario");
            nom = Console.ReadLine();
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
            Console.WriteLine("Bienvenido(a) "+nom);   
            do
            {
                Console.WriteLine("Ingrese una opción");
                Console.WriteLine("[1] Mostrar la matriz.");
                Console.WriteLine("[2] Rellenar la matriz de números binarios.");
                Console.WriteLine("[3] Rellenar la matriz de números aleatorios.");
                Console.WriteLine("[4] Editar un elemento por su ubicación.");
                Console.WriteLine("[5] Editar un elemento por su nombre.");
                Console.WriteLine("[6] Cambiar todos los elementos de la matriz.");
                Console.WriteLine("[7] Salir.");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:Mostrar();break;
                    case 2:Rellenar_Binarios();break;
                    case 3:Rellenar_Aleatorios();break;
                    case 4:Editar_ubi();break;
                    case 5:Editar_nom();break;
                    case 6:Editar_todo();break;
                    case 7:Console.WriteLine("Saliendo...");break;
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
            Random aleatorio = new Random();
            Console.WriteLine("Ingresa el rango Mínimo");
            int ranMi = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el rango Máximo");
            int ranMa = int.Parse(Console.ReadLine());
            for (int i = 0; i < numF; i++)
            {
                for (int y = 0; y < numC; y++)
                {
                    matriz[i, y] = aleatorio.Next(ranMi, ranMa);
                }
            }
        }

        public static void Editar_ubi()
        {
            Console.WriteLine("Ingresa la fila del elemento");
            int ubif = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la columna del elemento");
            int ubic = int.Parse(Console.ReadLine());
            if (numF >= ubif && numC >= ubic) 
            {
                Console.WriteLine("Ingresa el nuevo elemento");
                matriz[ubif, ubic] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Ubicación no encontrada");
            }
        }

        public static void Editar_nom()
        {
            int cont_elem = 0;
            Console.WriteLine("Ingresa el elemento a buscar");
            int elem = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el reemplazo");
            int rempla = int.Parse(Console.ReadLine());
            for (int i = 0; i < numF; i++)
            {
                for (int y = 0; y < numC; y++)
                {
                    if (matriz[i,y]==elem)
                    {
                        cont_elem++;
                        matriz[i, y] = rempla;
                    }
                }
            }
            if (cont_elem > 0)
            {
                Console.WriteLine("El elemento " + elem + " fue reemplazado por " + rempla);
            }
            else
            {
                Console.WriteLine("El elemento " + elem + " no fue encontrado");
            }
        }

        public static void Editar_todo()
        {
            Console.WriteLine("Acontinuación ingresa los elementos");
            for (int i = 0; i < numF; i++)
            {
                for (int y = 0; y < numC; y++)
                {
                    Console.Write("Ingresa el elementos ["+i+" , "+y+"]: ");
                    matriz[i, y] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
    }
}
