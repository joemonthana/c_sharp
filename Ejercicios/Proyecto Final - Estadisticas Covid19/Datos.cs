using System;
using System.Collections.Generic;
public class Datos
{
    public List<Departamentos> ListadeDepartamentos {get; set; }
    public List<Edad> ListadeEdad {get; set; }
    public List<Genero> ListadeGenero {get; set; }

    public Datos()
    {
        ListadeDepartamentos = new List<Departamentos>();
        mostrarDepartamentos();

        ListadeEdad = new List<Edad>();
        mostrarEdad();

        ListadeGenero = new List<Genero>();
        mostrarGenero();
    }

    private void mostrarDepartamentos()
    {
        Departamentos d1 = new Departamentos("21101", "Cortes           ", 0);
        ListadeDepartamentos.Add(d1);
        Departamentos d2 = new Departamentos("11101", "Francisco Morazan", 0);
        ListadeDepartamentos.Add(d2);
        Departamentos d3 = new Departamentos("31101", "Atlantida        ", 0);
        ListadeDepartamentos.Add(d3);
        Departamentos d4 = new Departamentos("32101", "Colon            ", 0);
        ListadeDepartamentos.Add(d4);
        Departamentos d5 = new Departamentos("23101", "Yoro             ", 0);
        ListadeDepartamentos.Add(d5);
        Departamentos d6 = new Departamentos("16101", "Olancho          ", 0);
        ListadeDepartamentos.Add(d6);
        Departamentos d7 = new Departamentos("52101", "Valle            ", 0);
        ListadeDepartamentos.Add(d7);
        Departamentos d8 = new Departamentos("15101", "La Paz           ", 0);
        ListadeDepartamentos.Add(d8);
        Departamentos d9 = new Departamentos("51101", "Choluteca        ", 0);
        ListadeDepartamentos.Add(d9);
        Departamentos d10 = new Departamentos("14101", "Intibuca         ", 0);
        ListadeDepartamentos.Add(d10);
        Departamentos d11 = new Departamentos("42101", "Lempira          ", 0);
        ListadeDepartamentos.Add(d11);
        Departamentos d12 = new Departamentos("43101", "Ocotepeque       ", 0);
        ListadeDepartamentos.Add(d12);
        Departamentos d13 = new Departamentos("33101", "Gracias a Dios   ", 0);
        ListadeDepartamentos.Add(d13);
        Departamentos d14 = new Departamentos("41101", "Copan            ", 0);
        ListadeDepartamentos.Add(d14);
        Departamentos d15 = new Departamentos("22101", "Santa Barbara    ", 0);
        ListadeDepartamentos.Add(d15);
        Departamentos d16 = new Departamentos("34101", "Islas de la Bahia", 0);
        ListadeDepartamentos.Add(d16);
        Departamentos d17 = new Departamentos("12101", "Comayagua        ", 0);
        ListadeDepartamentos.Add(d17);
        Departamentos d18 = new Departamentos("13101", "El Paraiso       ", 0);
        ListadeDepartamentos.Add(d18);
    }

    private void mostrarEdad()
    {
        Edad e1 = new Edad("100101", "Niños                ", "1 a 11 años        ", 0);
        ListadeEdad.Add(e1);
        Edad e2 = new Edad("100102", "Adolescentes(Jovenes)", "12 a 26 años       ", 0);
        ListadeEdad.Add(e2);
        Edad e3 = new Edad("100103", "Adultos              ", "27 a 59 años       ", 0);
        ListadeEdad.Add(e3);
        Edad e4= new Edad("100104", "Adulto Mayor         ", "60 años en adelante", 0);
        ListadeEdad.Add(e4);
        
        
    }

    private void mostrarGenero()
    {
        Genero g1 = new Genero("01", "Hombres", 0);
        ListadeGenero.Add(g1);
        Genero g2 = new Genero("02", "Mujeres", 0);
        ListadeGenero.Add(g2);
    }

    public void ListarDepartamentos()
    {
        Console.Clear();
        Console.WriteLine("Registro de Contagio por Departamentos");
        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("Código Postal | Departamento      | Casos Positivos");
        Console.WriteLine("");

         foreach (var departamento in ListadeDepartamentos)
        {
            Console.WriteLine(departamento.CodigoPostal + "         | " + departamento.Departamento + " | " + departamento.Casos);
        }

        Console.ReadLine();
    }

    public void ListarEdad()
    {
        Console.Clear();
        Console.WriteLine("Registro de Contagios por Edad");
        Console.WriteLine("===============================");
        Console.WriteLine("");
        Console.WriteLine("Código | Grupo                 | Rango de Edad       | Casos Positivos");
        Console.WriteLine("");

         foreach (var edad in ListadeEdad)
        {
            Console.WriteLine(edad.Codigo + " | " + edad.Etapa + " | " + edad.EdadComprendida + " | " + edad.Cantidad);
        }

        Console.ReadLine();
    }

    public void ListarGenero()
    {
        Console.Clear();
        Console.WriteLine("Registro de Contagios por Género");
        Console.WriteLine("=================================");
        Console.WriteLine("");
        Console.WriteLine("Código | Género  | Casos Positivos");
        Console.WriteLine("");

         foreach (var genero in ListadeGenero)
        {
            Console.WriteLine(genero.CodigoXY + "     | " + genero.Sexo + " | " + genero.Cantidad);
        }

        Console.ReadLine();
    }
    private void movimientoDepartamento(string codigoPostal, int casosPositivos, string tipoMovimiento)
    {
        foreach (var departamento in ListadeDepartamentos)
        {
            if (departamento.CodigoPostal == codigoPostal)
            {
                if (tipoMovimiento == "+")
                {
                    departamento.Casos = departamento.Casos + casosPositivos;
                }
            }
        }
    }
    private void movimientoEdad(string codigo, int casosPositivos, string tipoMovimiento)
    {
        foreach (var edad in ListadeEdad)
        {
            if (edad.Codigo == codigo)
            {
                if (tipoMovimiento == "+")
                {
                    edad.Cantidad = edad.Cantidad + casosPositivos;
                }
            }
        }
    }
    private void movimientoGenero(string codigoXY, int casosPositivos, string tipoMovimiento)
    {
        foreach (var genero in ListadeGenero)
        {
            if (genero.CodigoXY == codigoXY)
            {
                if (tipoMovimiento == "+")
                {
                    genero.Cantidad = genero.Cantidad + casosPositivos;
                }
            }
        }
    }


    public void ingresodePacientes()
    {
        string codigoPostal = "";
        string casosPositivos = "";
        string codigo = "";
        string codigoXY = "";

        Console.Clear();
        Console.WriteLine();

        Console.WriteLine("Ingreso de Casos Positivos");
        Console.WriteLine("===========================");
        Console.WriteLine("");
        Console.WriteLine("Ingrese el Código de Rango de Edad de los Pacientes");
        Console.WriteLine("");
        Console.WriteLine("Codigo | Grupo                  | Rango de Edad ");
        Console.WriteLine("");
        Console.WriteLine("100101 | Niños                  | 1 a 11 años");
        Console.WriteLine("100102 | Adolescentes (Jóvenes) | 12 a 27 años");
        Console.WriteLine("100103 | Adultos                | 27 a 59 años");
        Console.WriteLine("100104 | Adultos Mayores        | 60 años en adelante");
        Console.WriteLine("");
        codigo = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ingrese el Género de los Pacientes Según el Código");
        Console.WriteLine("");
        Console.WriteLine("Código | Género");
        Console.WriteLine();
        Console.WriteLine("01     | Masculino");
        Console.WriteLine("02     | Femenino");
        Console.WriteLine("");
        codigoXY = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ingrese el Código Postal del Departamento: ");
        Console.WriteLine("");
        codigoPostal = Console.ReadLine();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("Ingrese la Cantidad de Contagios: ");
        Console.WriteLine("");
        casosPositivos = Console.ReadLine();
        Console.Clear();


        movimientoDepartamento(codigoPostal, Int32.Parse(casosPositivos), "+");

        movimientoEdad(codigo, Int32.Parse(casosPositivos), "+");

        movimientoGenero(codigoXY, Int32.Parse(casosPositivos), "+");

    }
}
