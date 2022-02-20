using System;

namespace arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] dado1 = new int[4] {3,5,6,6};
            string[] mmm = new string[]{ "hola","ey", "probando"};
            //otra forma de hacerlo
            string [] mm = new string[4];
            mm[0] = "luis";
            mm[1] = "sssss";
            /* una forma mas legible para hacerlo, declaramos una varibale
             * para saber como se llama y asi poder identificarlos
             * Se declara const por que no queremos que ese numero nunca 
             * cambie.
             */
            const int numero = 5;
            int[] num = new int[numero];

            Console.WriteLine(mmm[0]);
            Console.WriteLine(dado1[2] + dado1[0]);
        }
    }
}
