using System;

namespace inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion = "";
            while (true)
            {
                Console.Clear();
              Console.WriteLine("sistema de Inventario");  
              Console.WriteLine("*********************");  
              Console.WriteLine("");  
              Console.WriteLine("1 - Productos");
              Console.WriteLine("2 - Ingreso de Inventario");  
              Console.WriteLine("3 - Salida de Inventario");  
              Console.WriteLine("0 - Salir");
              opcion = Console.ReadLine();
              
              switch (opcion)
              {
                case "1":
                Console.WriteLine("Produtos!");
                Console.ReadLine();
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