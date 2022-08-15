using System;
using System.Collections.Generic;
public class MostrarDatos
{
    public List<Departamentos> ListadeDepartamentos { get; set; }

    public MostrarDatos()
    {
        ListadeDepartamentos = new List<Departamentos>();
    }

    private void mostrarDepartamentos()
    {
        Departamentos d1 = new Departamentos("Cortes", 0);
        ListadeDepartamentos.Add(d1);
    }

    public void ListarDepartamentos()
    {
        Console.Clear();
        Console.WriteLine("Lista de Departamentos");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine("Departamento | Casos Positivos");
        Console.WriteLine("======================");
        Console.WriteLine("");

        foreach (var Departamentos in ListadeDepartamentos)
        {
            Console.WriteLine(Departamentos.Departamento + " | " + Departamentos.CasosPositivos);
        }

    }
}
