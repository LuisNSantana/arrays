 using System;

namespace diaMes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] dias = new int[12] { 31, 28, 31, 30, 31, 30, 31, 30, 31, 31, 30, 31 };
            int num;
            Console.WriteLine("Escribe el numero del mes para saber cuantos dias tiene: ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[0]);
                    }
                    break;

                case 2:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[1]);
                    }
                    break;

                case 3:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[2]);
                    }
                    break;
                case 4:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[3]);
                    }
                    break;
                case 5:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[4]);
                    }
                    break;
                case 6:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[5]);
                    }
                    break;
                case 7:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[6]);
                    }
                    break;
                case 8:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[7]);
                    }
                    break;
                case 9:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[8]);
                    }
                    break;
                case 10:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[9]);
                    }
                    break;
                case 11:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[10]);
                    }
                    break;
                case 12:
                    {


                        Console.WriteLine("El numero de dias que tiene el mes que selecciono es: " + dias[11]);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("No ingreso un numero de mes correcto");
                    }
                    break;

            }
        }
    }
}
