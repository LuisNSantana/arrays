using System;

namespace ejercicio2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] vector1 = new string[5];
            string[] vector2 = new string[5];
            string caracter;
            int contador = 5;
            

           for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingresa un caracter: ");
                caracter = Console.ReadLine();
                vector1[i] = caracter;
               
            }

            for (int j = 0; j< 5; j++)
            {
                
                vector2[--contador] = vector1[j];

               
            }
            

            for (int k = 0; k< 5; k++)
            {
                Console.WriteLine(vector1[k] + " ---  "+ vector2[k]);
            }




        }
    }
}
