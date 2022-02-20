using System;

namespace ejercicio4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] vector = new int [10];

            int num;
            int cont = 0;

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                vector[cont] = num;
                cont++;

            } while (cont < 10 && num > 0);

            
           
            for (int j = 0; j < 10; j++)
            {
                Console.Write(vector[j] + "|");
            }


        }
    }
}
