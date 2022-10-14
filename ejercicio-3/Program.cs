Console.WriteLine("Ingrese 10 números: ");
int[] numeros = new int[10];
int suma = 0;
int mayor = 0;
int menor = 0;

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el número N° {i + 1}:");
    numeros[i] = int.Parse(Console.ReadLine());
    suma = suma + numeros[i];

    if (i == 0)
    {
        mayor = numeros[i];
        menor = numeros[i];
    }
    else
    {
        if (numeros[i] > mayor)
        {
            mayor = numeros[i];
        }
        if (numeros[i] < menor)
        {
            menor = numeros[i];
        }
    }
}

var promedio = suma / numeros.Length;

Console.WriteLine("========================================");
Console.WriteLine($"La suma de los números es: {suma}");
Console.WriteLine($"El número mayor es: {mayor}");
Console.WriteLine($"El números menor es: {menor}");
Console.WriteLine($"El promedio de los números es: {promedio}");
Console.WriteLine($"Números ingresados: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}