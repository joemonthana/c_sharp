using System.Collections.Generic;

List<string> nombres = new List<string>();
nombres.Add("Joel");
nombres.Add("Esdras");
nombres.Add("Cesia");
nombres.Add("Mario");

foreach (var nombre in nombres)
{
    Console.WriteLine(nombre);
}

List<int> numeros = new List<int>();
numeros.Add(15);
numeros.Add(30);
numeros.Add(45);
numeros.Add(50);

    foreach (var numero in numeros)
    {
        Console.WriteLine(numero);
    }

List<Alumno> alumnos = new List<Alumno>();
Alumno a = new Alumno(1, "Joel");
Alumno b = new Alumno(2, "Fidelina");
Alumno c = new Alumno(3, "Mario");
Alumno d = new Alumno(4, "Cesia");

alumnos.Add(a);
alumnos.Add(b);
alumnos.Add(c);
alumnos.Add(d);

foreach (var alumno in alumnos)
{
    Console.WriteLine(alumno.Nombre);
}
