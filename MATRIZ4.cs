using System;

class Program
{
    static void Main()
    {
        string[,] equipos = new string[15, 2];
        int[,] resultados = new int[15, 2];

        // Leer los equipos y resultados de los 15 partidos
        for (int partido = 0; partido < 15; partido++)
        {
            Console.WriteLine("Partido " + (partido + 1));

            Console.Write("Nombre del primer equipo: ");
            equipos[partido, 0] = Console.ReadLine();

            Console.Write("Nombre del segundo equipo: ");
            equipos[partido, 1] = Console.ReadLine();

            Console.Write("Goles de " + equipos[partido, 0] + ": ");
            resultados[partido, 0] =
                int.Parse(Console.ReadLine());

            Console.Write("Goles de " + equipos[partido, 1] + ": ");
            resultados[partido, 1] =
                int.Parse(Console.ReadLine());
        }

        // Mostrar la quiniela de la jornada
        Console.WriteLine(" QUINIELA DE LA JORNADA ");

        for (int partido = 0; partido < 15; partido++)
        {
            Console.WriteLine(
                (partido + 1) + ". " +
                equipos[partido, 0] + " " +
                resultados[partido, 0] + " - " +
                resultados[partido, 1] + " " +
                equipos[partido, 1]
            );
        }
    }
}