using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int row, column, init1, init2;
                Console.Write(MessagesConsole.rowMsg);
                while (!int.TryParse(Console.ReadLine(), out row))
                {
                    GetErrorMsg();
                    Console.Write(MessagesConsole.rowMsg);
                }
                Console.Write(MessagesConsole.columnMsg);
                while (!int.TryParse(Console.ReadLine(), out column))
                {
                    GetErrorMsg();
                    Console.Write(MessagesConsole.columnMsg);
                }
                int[,] MatrixA = new int[row, column];
                Console.Write(MessagesConsole.firstMatrix);
                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        MessagesConsole.HelperMatrix.GetRow(init1, init2);
                        while (!MessagesConsole.HelperMatrix.ReadConsole(init1, init2, MatrixA))
                        {
                            GetErrorMsg();
                            MessagesConsole.HelperMatrix.TryAgain(init1, init2);
                        }
                    }
                }

                int[,] MatrixB = new int[row, column];
                Console.Write(MessagesConsole.secondMatrix);

                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        MessagesConsole.HelperMatrix.GetRow(init1, init2);
                        while (!MessagesConsole.HelperMatrix.ReadConsole(init1, init2, MatrixB))
                        {
                            GetErrorMsg();
                            MessagesConsole.HelperMatrix.TryAgain(init1, init2);
                        }
                    }
                }
                //Results 
                //Matrix A
                Console.Clear();
                MatrixMsg("A");
                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        Console.Write(MatrixA[init1, init2] + "\t");
                    }
                    Console.WriteLine();
                }
                //Matrix B
                MatrixMsg("B");
                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        Console.Write(MatrixB[init1, init2] + "\t");
                    }
                    Console.WriteLine();
                }

                int[,] MatrixResult = new int[row, column];
                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        MatrixResult[init1, init2] = MatrixA[init1, init2] + MatrixB[init1, init2];
                    }
                }
                //Sum Result
                MatrixResultMsg();
                for (init1 = 0; init1 < row; init1++)
                {
                    for (init2 = 0; init2 < column; init2++)
                    {
                        Console.Write(MatrixResult[init1, init2] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.Read();
            }


            //Prints
            //Error MSG
            void GetErrorMsg()
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingresaste un numero Invalido");
                Console.Write("Ingresa un numero valido");
                Console.ResetColor();
            }
            //MSG Matrix
            void MatrixMsg(string matrix)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"\nMatrix {matrix} : ");
                Console.ResetColor();
            }
            //MSG Result
            void MatrixResultMsg()
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nSuma Matrixes :\n");
                Console.ResetColor();
            }
        }


    }
}
