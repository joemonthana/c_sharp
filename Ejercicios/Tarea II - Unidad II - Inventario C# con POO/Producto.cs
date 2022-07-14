public class Producto {
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public string Existencia { get; set; }
    public string Precio { get; set; }

    public Producto(string codigo, string descripcion, string existencia, string precio)
    {
        Codigo = codigo;
        Descripcion = descripcion;
        Existencia = existencia;
        Precio = precio;
    }
}