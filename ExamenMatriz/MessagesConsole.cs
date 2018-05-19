using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMatriz
{
    class MessagesConsole
    {
        public static string rowMsg = "Ingrese el numero de Lineas\n";
        public static string columnMsg = "Ingrese el numero de Columnas\n";
        public static string firstMatrix = "\nIgresa la primera matriz : \n";
        public static string secondMatrix = "\nIgresa la segunda matriz:\n";
        public class HelperMatrix
        {
            public static bool ReadConsole(int init1, int init2, int[,] array)
            {
                return int.TryParse(Console.ReadLine(), out array[init1, init2]);
            }
            public static void GetRow(int init1, int init2)
            {
                Console.WriteLine($"Ingresa la posicion {init1} {init2}");
            }
            public static void TryAgain(int init1, int init2)
            {
                Console.WriteLine($"\nIngresa la posicion {init1} {init2} de nuevo =( ");
            }

        }

 
    }

}
