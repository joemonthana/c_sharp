// En esta clase se cumple la herencia, el cual hereda propiedades de la clase Animal
public class Aves: Animal
{
    public string TipodeAve { get; set; }

    public Aves(string tipo, string nombre, string metodo, string tipodeave)
    {
        Tipo = tipo;
        Nombre = nombre;
        Metodo = metodo;
        TipodeAve = tipodeave;
    }
}