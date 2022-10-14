Console.Clear();

Console.WriteLine("Ingrese su nombre:");
string name = Console.ReadLine();
Console.WriteLine($"¡Hola {name}!");

Console.WriteLine("Desea continuar (S/N): ");
string text = Console.ReadLine();

if (text.ToUpper() == "S")
{
    Console.Clear();
    Console.WriteLine("Ingrese su nombre:");
    name = Console.ReadLine();
    Console.WriteLine($"¡Hola {name}!");
}
else if (text.ToUpper() == "N")
{
    Console.WriteLine("Programa finalizado correctamente");
}
else
{
    Console.WriteLine("Opción no válida");
}