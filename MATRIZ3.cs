using System;

class Program
{
    static void Main()
    {
        double[] precios = new double[5];
        int[,] cantidades = new int[4, 5];
        int[] total_articulos = new int[5];
        double[] recaudacion = new double[4];

        double recaudacion_empresa = 0;
        int mayorSucursal = 0;

        // Leer los precios de los cinco artículos
        for (int articulo = 0; articulo < 5; articulo++)
        {
            Console.Write("Precio del artículo " + (articulo + 1) + ": ");
            precios[articulo] = double.Parse(Console.ReadLine());
        }

        // Leer las cantidades vendidas por sucursal
        for (int sucursal = 0; sucursal < 4; sucursal++)
        {
            Console.WriteLine("Sucursal " + (sucursal + 1));

            recaudacion[sucursal] = 0;

            for (int articulo = 0; articulo < 5; articulo++)
            {
                Console.Write("Cantidad del artículo " +
                              (articulo + 1) + ": ");

                cantidades[sucursal, articulo] =
                    int.Parse(Console.ReadLine());

                // Sumar las unidades vendidas de cada artículo
                total_articulos[articulo] =
                    total_articulos[articulo] +
                    cantidades[sucursal, articulo];

                // Calcular la recaudación de la sucursal
                recaudacion[sucursal] =
                    recaudacion[sucursal] +
                    cantidades[sucursal, articulo] * precios[articulo];
            }

            recaudacion_empresa =
                recaudacion_empresa + recaudacion[sucursal];
        }

        // Mostrar las cantidades totales por artículo
        Console.WriteLine(" TOTAL POR ARTÍCULO ");

        for (int articulo = 0; articulo < 5; articulo++)
        {
            Console.WriteLine(
                "Artículo " + (articulo + 1) + ": " +
                total_articulos[articulo] + " unidades"
            );
        }

        // Mostrar la cantidad de artículos en la sucursal 2
        int totalSucursal2 = 0;

        for (int articulo = 0; articulo < 5; articulo++)
        {
            totalSucursal2 =
                totalSucursal2 + cantidades[1, articulo];
        }

        Console.WriteLine(
            "Cantidad total vendida en sucursal 2: " +
            totalSucursal2
        );

        // Mostrar la cantidad del artículo 3 en la sucursal 1
        Console.WriteLine(
            "Artículo 3 vendido en sucursal 1: " +
            cantidades[0, 2]
        );

        // Mostrar la recaudación de cada sucursal
        Console.WriteLine(" RECAUDACIÓN POR SUCURSAL ");

        for (int sucursal = 0; sucursal < 4; sucursal++)
        {
            Console.WriteLine(
                "Sucursal " + (sucursal + 1) + ": $" +
                recaudacion[sucursal]
            );

            if (recaudacion[sucursal] > recaudacion[mayorSucursal])
            {
                mayorSucursal = sucursal;
            }
        }

        // Mostrar la recaudación total de la empresa
        Console.WriteLine(
            "Recaudación total de la empresa: $" +
            recaudacion_empresa
        );

        // Mostrar la sucursal con mayor recaudación
        Console.WriteLine(
            "Sucursal de mayor recaudación: " +
            (mayorSucursal + 1)
        );
    }
}