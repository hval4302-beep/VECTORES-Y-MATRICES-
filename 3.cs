using System;

class Program
{
    static void Main()
    {
        double [] notas = new double [5];
        double suma = 0;
        double mayor, menor;
        for (int i = 0; i < 5; i++)
        {
            do
            {
                Console.Write("Ingrese la nota " + (i + 1) + " (0 a 10): ");
                notas[i] = double.Parse(Console.ReadLine());

                if (notas[i] < 0 || notas[i] > 10)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 10.");
                }

            } while (notas[i] < 0 || notas[i] > 10);

            suma = suma + notas[i];
        }

        mayor = notas[0];
        menor = notas[0];

        for (int i = 1; i < 5; i++)
        {
            if (notas[i] > mayor)
            {
                mayor = notas[i];
            }

            if (notas[i] < menor)
            {
                menor = notas[i];
            }
        }

        Console.WriteLine("Notas del alumno:");

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(notas[i]);
        }

        Console.WriteLine("Nota media: " + (suma / 5));
        Console.WriteLine("Nota más alta: " + mayor);
        Console.WriteLine("Nota más baja: " + menor);
    }
}