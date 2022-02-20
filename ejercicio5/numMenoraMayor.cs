using System;

namespace ejercicio5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();

            int num = 0;
            

            int[] vector = new int[20];
            int temp = 0;

            //almaceno los datos del array
            for (int i = 0; i < vector.Length; i++)
            {

                num = rand.Next(1, 20);
                
                vector[i] = num;

               
            }
            //hago comparacion del array
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = i + 1; j < vector.Length; j++)
                {

                    if (vector[j] > vector[i])
                    {   /*Esta es la parte importante aca es donde se realiza
                        la comparacion de los vectores. para ir organizando.
                        */
                        temp = vector[j];
                        vector[j] = vector[i];
                        vector[i] = vector[j];
                        vector[i] = temp;
                        
                    }
                }
            }
            //aqui recorro el array
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " |");

            }
        }
    }
}
