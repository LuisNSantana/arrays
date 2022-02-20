using System;

namespace rellenoMatriz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] matriz = new int[3, 4];
            int num = 0;
            int num2 = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("Ingresa un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                matriz[0, i] = num;


 

            }

            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.WriteLine("Ingresa un numero matriz2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                matriz[1, j] = num2;

            }

            for (int i = 0; i < matriz.GetLength(0); i++)
            {


                Console.Write(matriz[0, i] + "|"); 

                }

            Console.Write("--------------------");

            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                Console.Write( matriz[1, i] + "|");


            }


        }

    }
    }

