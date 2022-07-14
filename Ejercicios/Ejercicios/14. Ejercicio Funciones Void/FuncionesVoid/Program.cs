// See https://aka.ms/new-console-template for more information
Alumno a = new Alumno(1, "Juan", "Perez");
Alumno b = new Alumno(2, "Maria", "Martinez");

a.inactivarAlumno();

Console.WriteLine(a.nombreCompleto());
Console.WriteLine(b.nombreCompleto());

a.activarAlumno();

Console.WriteLine("");

Console.WriteLine(a.nombreCompleto());
Console.WriteLine(b.nombreCompleto());

