using System;

namespace ahorcado
{
    class MainClass
    {
        static void mostrarVector(char [] vector)
        {
            Console.Write("[");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
                if (i < vector.Length - 1)
                {
                    Console.WriteLine(",");
                }
            }
            Console.Write("]");
        }

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Introduzca palabra a advinar: ");
            String palabra = Console.ReadLine();
            Console.WriteLine("Escribe una letra: ");
            
            char[] letra = new char[palabra.Length];
            

        }
    }
}
