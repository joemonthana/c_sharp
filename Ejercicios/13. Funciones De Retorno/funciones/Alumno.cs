public class Alumno

// Propiedades
{
    public int Id { get; set; }
public string PrimerNombre { get; set; }
public string SegundoNombre { get; set; }

//Constructores
public Alumno(int id, string primerNombre, string segundoNombre)
{
    Id = id;
    PrimerNombre = primerNombre;
    SegundoNombre = segundoNombre;
}

//Funciones
public string nombreCompleto() 
{
    return PrimerNombre + " " + SegundoNombre;
}

}