using ejercicio_7.Modelo;

Billetera[] billeteras = new Billetera[2];

billeteras[0] = new Billetera();
billeteras[1] = new Billetera();
int contador = 0;

Console.WriteLine("Ingrese la cantidad de billetes de cada billetera");

foreach (var item in billeteras)
{
    contador++;
    Console.WriteLine($"Billetera {contador}");

    Console.WriteLine("Billetes de 10: ");
    int b10 = int.Parse(Console.ReadLine());
    item.BilletesDe10 = b10;

    Console.WriteLine("Billetes de 20: ");
    int b20 = int.Parse(Console.ReadLine());
    item.BilletesDe20 = b20;

    Console.WriteLine("Billetes de 50: ");
    int b50 = int.Parse(Console.ReadLine());
    item.BilletesDe50 = b50;

    Console.WriteLine("Billetes de 100: ");
    int b100 = int.Parse(Console.ReadLine());
    item.BilletesDe100 = b100;

    Console.WriteLine("Billetes de 200: ");
    int b200 = int.Parse(Console.ReadLine());
    item.BilletesDe200 = b200;

    Console.WriteLine("Billetes de 500: ");
    int b500 = int.Parse(Console.ReadLine());
    item.BilletesDe500 = b500;

    Console.WriteLine("Billetes de 1000: ");
    int b1000 = int.Parse(Console.ReadLine());
    item.BilletesDe1000 = b1000;

    Console.WriteLine("------------------------------------------------");
}

Billetera primerBilletera = billeteras[0];
Console.WriteLine($"Dinero total de la primer billetera: ${primerBilletera.Total()}");

Billetera segundaBilletera = billeteras[1];
Console.WriteLine($"Dinero total de la segunda billetera: ${segundaBilletera.Total()}");

Billetera nuevaBilletera = billeteras[0].Combinar(billeteras[1]);
Console.WriteLine($"Suma total de ambas billeteras ${nuevaBilletera.Total()}");