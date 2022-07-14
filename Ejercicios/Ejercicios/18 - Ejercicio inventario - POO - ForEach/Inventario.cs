using System;
using System.Collections.Generic;
public class Inventario
{
     public List<Producto> ListadeProductos { get; set; }
    public Inventario()
    {
        ListadeProductos = new List<Producto>();
        Producto a = new Producto("001", "IphoneX", "0", "33000");
        Producto b = new Producto("002", "laptop Dell", "5", "25000");
        Producto c = new Producto("003", "Monitor Samsung", "2", "5500");
        Producto d = new Producto("004", "Mouse", "100", "150");
        Producto e = new Producto("005", "Headset", "25", "1200");
        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
    }

    public void listarProductos() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion Existencia y Precio");


            foreach (var producto in ListadeProductos)
            {
                Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia + " | " + producto.Precio);
            }

            Console.ReadLine();
        }

        private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
            
            foreach (var producto in ListadeProductos)
            {
                if (producto.Codigo == codigo) {
                    if (tipoMovimiento == "+") {
                        producto.Existencia = (Int32.Parse(producto.Existencia) + cantidad).ToString();
                    } else {
                        producto.Existencia = (Int32.Parse(producto.Existencia) - cantidad).ToString();
                    }
                }
            }

        }
        private void cambioDePrecio(string codigo, int ajustePrecio, string movimientoPrecio) {
            
            foreach (var producto in ListadeProductos)
            {
                if (producto.Codigo == codigo) {
                    if (movimientoPrecio == "+") {
                        producto.Precio = (Int32.Parse(producto.Precio) + ajustePrecio).ToString();
                    } else {
                        producto.Precio = (Int32.Parse(producto.Precio) - ajustePrecio).ToString();
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