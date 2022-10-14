int numeroSecreto = new Random(DateTime.Now.Millisecond).Next(1, 21);
int numeroElegido;
int intentos = 1;
Console.WriteLine("ADIVINA EL NÚMERO!!");

do
{
    Console.Write("Ingrese un número del 1 al 20 para adivinar: ");
    numeroElegido = int.Parse(Console.ReadLine());
    if (numeroElegido > numeroSecreto)
    {
        Console.WriteLine("El número elegido es muy grande, vuelve a intentarlo!");
    }
    if (numeroElegido < numeroSecreto)
    {
        Console.WriteLine("El número elegido es muy chico, vuelve a intentarlo!");
    }
    if (numeroElegido == numeroSecreto)
    {
        Console.WriteLine($"Felicitaciones, has adivinado el número secreto que era: {numeroSecreto}");
        Console.WriteLine($"Lo has logrado en {intentos} intentos!!");
    }
    intentos++;
}
while (numeroElegido != numeroSecreto);