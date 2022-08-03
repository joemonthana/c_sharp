// En esta clase se cumple la herencia, el cual hereda propiedades de la clase Animal
public class Mamiferos: Animal
{
    public string HabitatMamifero { get; set; }

    public Mamiferos(string tipo, string nombre, string metodo, string habitatMamifero)
    {
        Tipo = tipo;
        Nombre = nombre;
        Metodo = metodo;
        HabitatMamifero = habitatMamifero;
    }
}