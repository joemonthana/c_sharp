using System;
using System.Collections.Generic;

namespace Estadisticas
{
    class Program
{
    static void Main(string[] args)
    {
        Datos mostrar = new Datos();
        string opcion = "";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Estadisticas de Covid19");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("1 - Ingresar Pacientes");
            Console.WriteLine("2 - Registro de contagios por Departamento");
            Console.WriteLine("3 - Registro  de contagio por Edad");
            Console.WriteLine("4 - Registro  de contagio por Genero");
            Console.WriteLine("0 - Salir");
            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                mostrar.ingresodePacientes();
                break;
                case "2":
                mostrar.ListarDepartamentos();
                break;
                case "3":
                mostrar.ListarEdad();
                break;
                case "4":
                mostrar.ListarGenero();
                break;
                default:
                break;
            }
            if (opcion == "0")
            {
                break;
            }
        }
    }
}
}