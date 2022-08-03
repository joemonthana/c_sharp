using System;
using System.Collections.Generic;
public class DatosMaestro
{
    public List<Mamiferos> ListadeMamiferos { get; set; }
    public List<Aves> ListadeAves { get; set; }
    public List<Peces> ListadePeces { get; set; }


    // Polimorfismo: Costructor que recibe varios parametros
    public DatosMaestro()
    {
        ListadeMamiferos = new List<Mamiferos>();
        mostrarMamiferos();
        ListadeAves = new List<Aves>();
        mostrarAves();
        ListadePeces = new List<Peces>();
        mostrarPeces();
    }

    // Polimorfismo: Costructor que recibe varios parametros

    

    // Encapsulamiento: Ocultar o crear una funcion en privado, significa que la clase no esta expuesta
    private void mostrarMamiferos()
    {
        Mamiferos m1 = new Mamiferos("Mamifero", "Vaca", "Pasto", "Terrestre");
        ListadeMamiferos.Add(m1);
        Mamiferos m2 = new Mamiferos("Mamifero", "Jirafa", "Pasto", "Terrestre");
        ListadeMamiferos.Add(m2);
        Mamiferos m3 = new Mamiferos("Mamifero", "Ballena", "Peces", "Acuatica");
        ListadeMamiferos.Add(m3);
    }
    private void mostrarAves()
    {
        Aves a1 = new Aves("Aves", "Tucan", "Semillas", "Volador");
        ListadeAves.Add(a1);
        Aves a2 = new Aves("Aves", "Gallina", "Pasto", "No volador");
        ListadeAves.Add(a2);
        Aves a3 = new Aves("Aves", "Aguila", "Carninoro", "Volador");
        ListadeAves.Add(a3);
    }
    private void mostrarPeces()
    {
        Peces p1 = new Peces("Peces", "Salmon", "Hierba", "Rio agua dulce");
        ListadePeces.Add(p1);
        Peces p2 = new Peces("Peces", "Ballena", "Peces", "Oceano");
        ListadePeces.Add(p2);
        Peces p3 = new Peces("Peces", "Tiburon", "Carnivoro", "Oceano");
        ListadePeces.Add(p3);
    }


    // Encapsulamiento: Ocultar o crear una funcion en privado, significa que la clase no esta expuesta


    // Abstracción: Es mostra o exponer de forma publica una clase
    public void listarMamiferos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Mamiferos");
        Console.WriteLine("-------------------");
        Console.WriteLine("Clase | Animal | Alimento | Habitat");
        Console.WriteLine("");
         foreach (var mamiferos in ListadeMamiferos)
        {
            Console.WriteLine(mamiferos.Tipo + " | " + mamiferos.Nombre + " | " + mamiferos.Metodo + " | " + mamiferos.HabitatMamifero);
        }
        Console.ReadLine();
    }
    public void listarAves()
    {
        Console.Clear();
        Console.WriteLine("Lista de Aves");
        Console.WriteLine("-------------------");
        Console.WriteLine("Clase | Animal | Alimento | Tipo de ave");
        Console.WriteLine("");
         foreach (var aves in ListadeAves)
        {
            Console.WriteLine(aves.Tipo + " | " + aves.Nombre + " | " + aves.Metodo + " | " + aves.TipodeAve);
        }
        Console.ReadLine();
    }
    public void listarPeces()
    {
        Console.Clear();
        Console.WriteLine("Lista de Peces");
        Console.WriteLine("-------------------");
        Console.WriteLine("Clase | Animal | Alimento | Habitat");
        Console.WriteLine("");
         foreach (var peces in ListadePeces)
        {
            Console.WriteLine(peces.Tipo + " | " + peces.Nombre + " | " + peces.Metodo + " | " + peces.HabitatPeces);
        }
        Console.ReadLine();
    }

     // Abstracción: Es mostra o exponer de forma publica una clase

}