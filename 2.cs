using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[100];
        int suma=0;
        double media=0;

        for (int i = 0; i < 100; i++)
        {
            numeros[i]] = i + 1;
        }

        for (int i = 0; i < 100; i++)
        {
            suma= suma + numeros[i];
        }
        media=(double)suma/100;
        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("La media es: " + media);
    }
}