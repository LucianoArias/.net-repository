Console.WriteLine("Ingrese la cantidad de filas: ");
int cantidadFilas = int.Parse(Console.ReadLine());
Console.WriteLine("ingrese la cantidad de columnas: ");
int cantidadColumnas = int.Parse(Console.ReadLine());

int[,] numeros = new int[cantidadFilas, cantidadColumnas];
int lengthFilas = numeros.GetUpperBound(0) + 1;
int lengthColumnas = numeros.GetUpperBound(1) + 1;

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    Console.WriteLine($"Columna {columnas + 1} ");

    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.Write($"Ingresa un número para la fila {filas + 1}: ");
        numeros[filas, columnas] = int.Parse(Console.ReadLine());
    }
}

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    Console.WriteLine("==================================");
    Console.WriteLine("---" + $"Columna N° {columnas + 1}" + "---");

    for (int filas = 0; filas < lengthFilas; filas++)
    {
        Console.Write($"Número de la fila N° {filas + 1}: ");
        Console.WriteLine(numeros[filas, columnas]);
    }
}

Console.WriteLine("==================================");

double[] promedio = new double[lengthColumnas];

for (int columnas = 0; columnas < lengthColumnas; columnas++)
{
    double suma = 0;
    for (int filas = 0; filas < lengthFilas; filas++)
    {
        suma = suma + numeros[filas, columnas];
    }
    promedio[columnas] = suma / lengthFilas;
    Console.WriteLine($"El promedio de los numeros de la columna {columnas + 1}" + " es " + promedio[columnas]);
}