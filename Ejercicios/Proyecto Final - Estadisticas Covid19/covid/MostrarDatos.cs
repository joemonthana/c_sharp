using System;
using System.Collections.Generic;
public class MostrarDatos
{
    public List<Departamentos> ListadeDepartamentos { get; set; }
    public List<Paciente> ListadePaciente { get; set; }

    public MostrarDatos()
    {
        ListadeDepartamentos = new List<Departamentos>();
        mostrarDepartamentos();
        ListadePaciente = new List<Paciente>();
        ingresarPaciente();
    }

    private void mostrarDepartamentos()
    {
        Departamentos d1 = new Departamentos("Cortes", 0);
        ListadeDepartamentos.Add(d1);
        Departamentos d2 = new Departamentos("Francisco Morazan", 0);
        ListadeDepartamentos.Add(d2);
    }
    private void ingresarPaciente()
    {
        foreach (var paciente in ListadePaciente)
        { 
            if (paciente.Departamento == "Cortes")
            {
                paciente.Departamento = (Int32.Parse(paciente.Departamento) + 1).ToString();
            }
        }
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

        foreach (var departamentos in ListadeDepartamentos)
        {
            Console.WriteLine(departamentos.Departamento + " | " + departamentos.CasosPositivos);
        }
        Console.WriteLine();
        Console.ReadLine();

    }
    
}
