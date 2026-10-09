using System;

class Program
{
    static void Main()
    {
        // Crear un vector de 5 cadenas
        string[] vector = new string[5];

        // Crear otro vector de 5 cadenas
        string[] inverso = new string[5];

        // Leer los datos por teclado
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Ingrese una palabra: ");
            vector[i] = Console.ReadLine();
        }

        // Copiar los elementos en orden inverso
        for (int i = 0; i < 5; i++)
        {
            inverso[i] = vector[4 - i];
        }

        // Mostrar el vector inverso
        Console.WriteLine("\nVector en orden inverso:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(inverso[i]);
        }
    }
}