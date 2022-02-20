using System;

namespace ejercicio1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int num;
            int[] vector_numeros = new int[10];
           //Console.WriteLine(vector_numeros);

            for(int i = 0; i<10; i++) 
            {
                num = rand.Next(1, 11);
                vector_numeros[i] = num;

                
                
            }
            Console.WriteLine("NUMERO ---- CUADRADO --------- CUBO");
            for (int j = 0; j<10; j++)
            {
                
                Console.WriteLine(vector_numeros[j] + "            " + Math.Pow(vector_numeros[j],2) + "             " + Math.Pow(vector_numeros[j], 3) );
            }
        }
    }
}
