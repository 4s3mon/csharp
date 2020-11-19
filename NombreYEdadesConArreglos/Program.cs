using System;

namespace NombreYEdadesConArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            int[] edades = new int[5];

            //Guardar datos en un arreglo con un for
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Cual es el nombre de la persona #" + (i+1) + "? ");
                nombres[i] = Console.ReadLine();

                Console.Write("Cual es la edad de la persona? ");
                edades[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            //Mostrar el contenido del arreglo con un for
            Console.WriteLine("NOMBRES   EDADES");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(nombres[i] + "  " + edades[i]);
            }
        }
    }
}
