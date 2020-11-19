using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            // int[] arreglo1;
            // arreglo1 = new int [10];


            // int[] arreglo2 = new int[10];
            // arreglo1[0] = 123;

            // for( i = 0; i <= arreglo1.Length; i++){
            //     Console.Write("Ingresa un valor para el arreglo enla posicion # " + i + ": ");
            //     num = int.Parse(Console.ReadLine());
            //     arreglo1[i] = num;
            // }
            // Console.WriteLine("Indice      Valor");
            // for(i = 0; i <= arreglo1.Length; i++){
            //     Console.WriteLine("  " + i + "           " + arreglo1[i]);
            // }

            string[] nombres = new string[5];

            for(i = 0; i < 5; i++){
                Console.WriteLine(i);
                nombres[i] = Console.ReadLine();
            }
            Console.WriteLine("Indice      Valor");
            for(i = 0; i < 5; i++){
                Console.WriteLine("  " + i + "           " + nombres[i]);
            }
        }
    }
}
