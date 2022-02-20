using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string contAlumnos;
            string[] alumnos = new string[5];
            int contador=0;
            int[] edades = new int[5];
            int contedades;

            
            do
            {
                
                Console.WriteLine("Escribe el nombre del alumno: ");
                contAlumnos = Console.ReadLine();
                Console.WriteLine("Ingrese la edad: ");
                contedades = Convert.ToInt32(Console.ReadLine());
                contador++;

                alumnos[contador] = contAlumnos;
                edades[contador] = contedades; 

            } while (contAlumnos !="*");

            
            for (int j = 0; j < alumnos.Length; j++)
            {
                Console.Write(alumnos[j] + "|" + " ");
                Console.Write( edades[j] + "|");
            }
        }
    }
}
