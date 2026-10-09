using System;

class Program
{
    static void Main()
    {
        int[,] marco = new int[5, 15];

        // Recorrer las filas y columnas de la matriz
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 15; columna++)
            {
                // Colocar 1 en los bordes y 0 en el interior
                if (fila == 0 || fila == 4 ||
                    columna == 0 || columna == 14)
                {
                    marco[fila, columna] = 1;
                }
                else
                {
                    marco[fila, columna] = 0;
                }
            }
        }

        // Mostrar la matriz
        Console.WriteLine("Matriz marco:");

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 15; columna++)
            {
                Console.Write(marco[fila, columna]);
            }

            Console.WriteLine();
        }
    }
}