using System;

class Program
{
    static void Main()
    {
        int[] vector = new int[10];
        int numero;
        int cantidad = 0;
        while (cantidad < 10)
        {
            Console.Write("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                break;
            }

            vector[cantidad] = numero;
            cantidad++;
        }
        Console.WriteLine("Elementos del vector:");

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine(vector[i]);
        }
    }
}