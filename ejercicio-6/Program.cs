var numRandom = new Random();
var carton = new int[3, 9];

for (int columnas = 0; columnas < 9; columnas++)
{
    for (int filas = 0; filas < 3; filas++)
    {
        int nuevoNumero = 0;
        bool encontreUnoNuevo = false;
        while (!encontreUnoNuevo)
        {
            if (columnas == 0)
            {
                nuevoNumero = numRandom.Next(1, 10);
            }
            else if (columnas == 8)
            {
                nuevoNumero = numRandom.Next(80, 91);
            }
            else
            {
                nuevoNumero = numRandom.Next(columnas * 10, columnas * 10 + 10);
            }

            encontreUnoNuevo = true;
            for (int i = 0; i < 3; i++)
            {
                if (carton[i, columnas] == nuevoNumero)
                {
                    encontreUnoNuevo = false;
                    break;
                }
            }
        }
        carton[filas, columnas] = nuevoNumero;
    }
}


Console.WriteLine("----------------------------------------------");
for (int filas = 0; filas < 3; filas++)
{
    for (int columnas = 0; columnas < 9; columnas++)
    {
        if (columnas == 0)
        {
            Console.Write("|");
        }
        if (carton[filas, columnas] == 0)
        {
            Console.Write("    |");
        }
        else
        {
            Console.Write($" {carton[filas, columnas]:00} |");
        }
    }
    Console.WriteLine();
}
Console.WriteLine("----------------------------------------------");
Console.WriteLine();