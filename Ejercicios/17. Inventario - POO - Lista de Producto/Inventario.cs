using System;
public class Inventario
{
     public List<Producto> listadeProductos { get; set; }
    public Inventario()
    {
        listadeProductos = new List<Producto>();
        Producto a = new Producto("001", "IphoneX", "0", "33000");
        Producto b = new Producto("002", "laptop Dell", "5", "25000");
        Producto c = new Producto("003", "Monitor Samsung", "2", "5500");
        Producto d = new Producto("004", "Mouse", "100", "150");
        Producto e = new Producto("005", "Headset", "25", "1200");
        listadeProductos.Add(a);
        listadeProductos.Add(b);
        listadeProductos.Add(c);
        listadeProductos.Add(d);
        listadeProductos.Add(e);
    }

    public void listarProductos() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion Existencia y Precio");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i, 0] + " | " + productos[i, 1] + " | " + productos[i, 2] + " | " + productos[i, 3]);
            }

            Console.ReadLine();
        }

        private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (tipoMovimiento == "+") {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) + cantidad).ToString();
                    } else {
                        productos[i, 2] = (Int32.Parse(productos[i, 2]) - cantidad).ToString();
                    }
                }
            }
        }
        private void cambioDePrecio(string codigo, int ajustePrecio, string movimientoPrecio) {
            for (int i = 0; i < 5; i++)
            {
                if (productos[i, 0] == codigo) {
                    if (movimientoPrecio == "+") {
                        productos[i, 3] = (Int32.Parse(productos[i, 3]) + ajustePrecio).ToString();
                    } else {
                        productos[i, 3] = (Int32.Parse(productos[i, 3]) - ajustePrecio).ToString();
                    }
                }
            }
        }

        public void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        public void salidaDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Salida de Productos de Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "-");
        }
        public void aumentodeprecio() {
            string codigo = "";
            string aumentodeprecio = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Aumento de precio de Productos");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese el aumento de precio del producto: ");
            aumentodeprecio = Console.ReadLine();

            cambioDePrecio(codigo, Int32.Parse(aumentodeprecio), "+");
        }
        public void rebajadeprecio() {
            string codigo = "";
            string rebajadeprecio = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Rebaja de precio de Productos");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la rebaja de precio del producto: ");
            rebajadeprecio = Console.ReadLine();

            cambioDePrecio(codigo, Int32.Parse(rebajadeprecio), "-");
        }
}