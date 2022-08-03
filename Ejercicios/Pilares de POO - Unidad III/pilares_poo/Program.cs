using System;
using System.Collections.Generic;
DatosMaestro datos = new DatosMaestro();
string opcion = "";

while (true)
{
    Console.Clear();
    Console.WriteLine("Reino Animal");
    Console.WriteLine("-------------");
    Console.WriteLine("1 - Mamiferos");
    Console.WriteLine("2 - Aves");
    Console.WriteLine("3 - Peces");
    Console.WriteLine("0 - Salir");
    
    opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
         datos.listarMamiferos();
         break;
        case "2":
         datos.listarAves();
         break;
        case "3":
         datos.listarPeces();
         break;
        default:
        break;
    }
    if (opcion == "0")
    {
        break;
    }
}
