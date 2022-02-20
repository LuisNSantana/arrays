using System;

namespace ceroYUno
{
  
    class MainClass
    {
        public static void mostrarVector(int  [] vector)
        {
            for (int j = 0; j < vector.Length; j++)
            {

                Console.Write(vector[j] + "|");

            }
        }

        public static void Main(string[] args)
        {
            int[] vector = new int[10];
            int num;

            for(int i = 1; i< vector.Length; i+=2)
            {

                vector[i] = 1;

            }


            mostrarVector(vector);
          

            Console.WriteLine("");
            do
            {
                Console.WriteLine("Posicion a eliminar de 0 y " + (vector.Length-1) + " :");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < 0 || num > (vector.Length - 1));

            for(int i = 0; i < vector.Length -1; i++)
            {
                vector[i] = vector[i + 1];
            }

            mostrarVector(vector);
        }
    }
}
