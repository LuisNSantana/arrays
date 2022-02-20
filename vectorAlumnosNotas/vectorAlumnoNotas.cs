using System;

namespace vectorAlumnosNotas
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const int numeros = 5;
            string[] alumnos = new string[numeros];
            int[] notas = new int[numeros];
            //string nombres;
            //int nota;
            double media;
            int cont = 0;

            // Rellenar los valores del array
            for(int i = 0; i < alumnos.Length - 1; i++)
            {
                Console.WriteLine("INGRESAR NOMBRE " + (i + 1) + ":");
                alumnos[i] = Console.ReadLine();
                Console.WriteLine("INGRESAR NOTA " + (i + 1) + ":");
                notas[i] =  Convert.ToInt32(Console.ReadLine());

                
                if (notas[i] > 10)
                {
                    Console.WriteLine("No se puede colocar una nota mayor a 10");
                }
                cont += notas[i];
            }

            

           /* for (int i = 0; i< alumnos.Length; i++)
            {
                if (notas[i]>= 5)
                {
                    Console.WriteLine("ALUMNO: " + alumnos[i] + " nota: " + notas[i]);
                }
            }*/

            

            media = cont/numeros;

            Console.WriteLine("La media es: " + media);

        


            

            //Console.WriteLine(string.Join(" ", alumnos ));
            //Console.WriteLine(string.Join(" ", notas));
            //Console.WriteLine(string.Join("notas: ", notas));
            
        }
    }
}
