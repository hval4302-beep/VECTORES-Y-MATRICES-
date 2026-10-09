using System;

class Program
{
    static void Main()
    {
        string[] nombre = new string[3];
        double[,] kms = new double[3, 7];
        double[] total_kms = new double[3];

        string[] dias = {
            "Lunes", "Martes", "Miercoles", "Jueves",
            "Viernes", "Sabado", "Domingo"
        };

        // Leer los nombres y kilómetros de cada conductor
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Nombre del conductor " + (i + 1) + ": ");
            nombre[i] = Console.ReadLine();

            total_kms[i] = 0;

            for (int j = 0; j < 7; j++)
            {
                Console.Write("Kilómetros del " + dias[j] + ": ");
                kms[i, j] = double.Parse(Console.ReadLine());

                total_kms[i] = total_kms[i] + kms[i, j];
            }
        }

        // Mostrar el total de kilómetros
        Console.WriteLine(" TOTAL DE KILÓMETROS ");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(
                nombre[i] + ": " + total_kms[i] + " km"
            );
        }
    }
}