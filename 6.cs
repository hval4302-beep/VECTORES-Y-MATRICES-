using System;

class Program
{
    static void Main()
    {
        int[] vector1 = new int[5];
        int[] vector2 = new int[5];
        int[] vector3 = new int[5];

        //  vector1
        Console.WriteLine("Ingrese los elementos del vector1:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Posición " + i + ": ");
            vector1[i] = int.Parse(Console.ReadLine());
        }

        // vector2
        Console.WriteLine("Ingrese los elementos del vector2:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Posición " + i + ": ");
            vector2[i] = int.Parse(Console.ReadLine());
        }

        // Suma
        for (int i = 0; i < 5; i++)
        {
            vector3[i] = vector1[i] + vector2[i];
        }

        // Mostrar resultado
        Console.WriteLine("Resultado de vector3:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(
                vector1[i] + " + " + vector2[i] + " = " + vector3[i]
            );
        }
    }
}