// See https://aka.ms/new-console-template for more information
Alumno a = new Alumno();
a.PrimerNombre = "Juan";
a.SegundoNombre = "Andres";

Alumno b = new Alumno();
b.Id = 2;
b.PrimerNombre = "Maria";
b.SegundoNombre = "Jose";

Alumno c = new Alumno(3);
c.PrimerNombre = "Joel";

Console.WriteLine(a.Id);
Console.WriteLine(b.Id);
Console.WriteLine(c.Id);
