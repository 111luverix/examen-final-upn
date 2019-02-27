using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej1111
{
    class Program
    {
        static void Main(string[] args)
        {
            Leer();
        }

        private static void Leer()
        {
            Console.WriteLine("INGRESE SU NOMBRE USUSARIO");
            String nom = Console.ReadLine();
            Console.WriteLine("ingrese número de filas");
            int numF = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese número de filas");
            int numC = int.Parse(Console.ReadLine());
        }
    }
}
