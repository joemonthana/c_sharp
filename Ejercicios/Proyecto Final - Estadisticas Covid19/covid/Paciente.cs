public class Paciente
{
    public string Nombre { get; set; }
    public string Departamento { get; set; }

    public Paciente(string nombre, string departamento)
    {
        Nombre = nombre;
        Departamento = departamento;
    }
}