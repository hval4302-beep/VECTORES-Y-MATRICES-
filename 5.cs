using System;

class Program
{
    static void Main()
    {
        string[] meses = {
            "Enero", "Febrero", "Marzo", "Abril",
            "Mayo", "Junio", "Julio", "Agosto",
            "Septiembre", "Octubre", "Noviembre", "Diciembre"
        };

        int[] dias = {
            31, 28, 31, 30, 31, 30,
            31, 31, 30, 31, 30, 31
        };

        int numeroMes;

        Console.Write("Ingrese el número del mes (1-12): ");
        numeroMes = int.Parse(Console.ReadLine());

        if (numeroMes >= 1 && numeroMes <= 12)
        {
            Console.WriteLine("Mes: " + meses[numeroMes - 1]);
            Console.WriteLine("Cantidad de días: " + dias[numeroMes - 1]);
        }
        else
        {
            Console.WriteLine("Número de mes inválido.");
        }
    }
}