Console.WriteLine("Ingrese la longitud del vector:");
var longitud = int.Parse(Console.ReadLine());

int[] miVector = new int[longitud];
Random numerosAleatorios = new Random();

Console.WriteLine("======================");
Console.WriteLine("Antes de invertir: ");
for (int i = 0; i < miVector.Length; i++)
{
    miVector[i] = numerosAleatorios.Next(100);
    Console.WriteLine(miVector[i]);
}

for (int indiceDelExtremoIzquierdo = 0; indiceDelExtremoIzquierdo < miVector.Length / 2; indiceDelExtremoIzquierdo++)
{
    int indiceDelExtremoDerecho = miVector.Length - indiceDelExtremoIzquierdo - 1;
    int temporal = miVector[indiceDelExtremoDerecho];
    miVector[indiceDelExtremoDerecho] = miVector[indiceDelExtremoIzquierdo];
    miVector[indiceDelExtremoIzquierdo] = temporal;
}

Console.WriteLine("======================");
Console.WriteLine("Después de invertir: ");
for (int i = 0; i < miVector.Length; i++)
{
    Console.WriteLine(miVector[i]);
}