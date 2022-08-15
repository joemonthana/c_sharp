using System;

namespace estadisticas_covid19
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarDatos datos = new MostrarDatos();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Estadisticas Covid 19");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Ingresar paciente");
                Console.WriteLine("2 - Lista de resultados");
                Console.WriteLine("3 - Estadisticas por departamento");
                Console.WriteLine("4 - Estadistica por genero");
                Console.WriteLine("5 - Estadisticas por edad");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarDepartamentos();
                        break;                                    
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}