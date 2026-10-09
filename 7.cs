using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[100];
        int[] edades = new int[100];

        int cantidad = 0;
        int mayorEdad = 0;
        string nombre;

        // Leer nombres y edades
        while (cantidad < 100)
        {
            Console.Write("Ingrese el nombre del alumno (* para terminar): ");
            nombre = Console.ReadLine();

            if (nombre == "*")
            {
                break;
            }

            nombres[cantidad] = nombre;

            Console.Write("Ingrese la edad: ");
            edades[cantidad] = int.Parse(Console.ReadLine());

            if (edades[cantidad] > mayorEdad)
            {
                mayorEdad = edades[cantidad];
            }

            cantidad++;
        }

        Console.WriteLine("Alumnos mayores de edad:");

        for (int i = 0; i < cantidad; i++)
        {
            if (edades[i] >= 18)
            {
                Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
            }
        }

        if (cantidad > 0)
        {
            Console.WriteLine("Alumnos con mayor edad:");

            for (int i = 0; i < cantidad; i++)
            {
                if (edades[i] == mayorEdad)
                {
                    Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
                }
            }

            Console.WriteLine("Edad máxima: " + mayorEdad);
        }
        else
        {
            Console.WriteLine("No se ingresaron alumnos.");
        }
    }
}