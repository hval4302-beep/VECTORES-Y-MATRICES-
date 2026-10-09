using System;

class Program
{
    static void Main()
    {
        double[] minima = new double[5];
        double[] maxima = new double[5];
        double media;
        double menorTemperatura;
        double temperaturaBuscar;
        bool encontrado = false;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Día " + (i + 1));

            Console.Write("Temperatura mínima: ");
            minima[i] = double.Parse(Console.ReadLine());

            Console.Write("Temperatura máxima: ");
            maxima[i] = double.Parse(Console.ReadLine());

            while (maxima[i] < minima[i])
            {
                Console.WriteLine("La máxima no puede ser menor que la mínima.");

                Console.Write("Ingrese nuevamente la temperatura máxima: ");
                maxima[i] = double.Parse(Console.ReadLine());
            }
        }

    
        Console.WriteLine("Temperatura media de cada día:");

        for (int i = 0; i < 5; i++)
        {
            media = (minima[i] + maxima[i]) / 2;

            Console.WriteLine("Día " + (i + 1) + ": " + media);
        }

        menorTemperatura = minima[0];

        for (int i = 1; i < 5; i++)
        {
            if (minima[i] < menorTemperatura)
            {
                menorTemperatura = minima[i];
            }
        }

        Console.WriteLine("Días con menor temperatura mínima:");

        for (int i = 0; i < 5; i++)
        {
            if (minima[i] == menorTemperatura)
            {
                Console.WriteLine("Día " + (i + 1));
            }
        }

        Console.WriteLine("Temperatura mínima registrada: " + menorTemperatura);

        Console.Write("Ingrese una temperatura máxima para buscar: ");
        temperaturaBuscar = double.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            if (maxima[i] == temperaturaBuscar)
            {
                Console.WriteLine("Coincide con el día " + (i + 1));
                encontrado = true;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Ningún día tiene esa temperatura máxima.");
        }
    }
}