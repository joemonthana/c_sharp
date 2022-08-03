// En esta clase se cumple la herencia, el cual hereda propiedades de la clase Animal
public class Peces: Animal
{
    public string HabitatPeces { get; set; }

    public Peces(string tipo, string nombre, string metodo, string habitatPeces)
    {
        Tipo = tipo;
        Nombre = nombre;
        Metodo = metodo;
        HabitatPeces = habitatPeces;
    }
}