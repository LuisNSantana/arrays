using System;

namespace ejercicio7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            int[] vector3 = new int[5];
            int num = 0;
            int num2 = 0;

            for (int i = 0; i< vector1.Length; i++)
            {
                Console.WriteLine("Ingrese un numero para el vector 1: ");
                num = Convert.ToInt32(Console.ReadLine());
                vector1[i] += num;

                
                
            }
            Console.WriteLine(" \n ---------VECTOR 1---------------");
            for (int j = 0; j < vector1.Length; j++)
            {

                Console.Write(vector1[j] + "|");

            }

            
            for (int i = 0; i < vector2.Length; i++)
            {
                Console.WriteLine("\n Ingrese un numero para el vector 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());
                vector2[i] += num2;
            }

            Console.WriteLine(" \n ---------VECTOR 2---------------");

            for (int j = 0; j < vector2.Length; j++)
            {
                Console.Write(vector2[j] + "|");
            }


            for(int i = 0; i<vector3.Length; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }

            Console.WriteLine(" \n ---------VECTOR 3---------------");

            for (int j =0; j < vector3.Length; j++)
            {
                Console.Write(vector3[j] + "|");

            }





        }
    }
}
