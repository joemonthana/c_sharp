public class Paciente
{
    public string Nombre { get; set; }
    public bool Resultado { get; set; }
    public string Departamento { get; set; }
    public int Edad { get; set; }

    public paciente(string nombre, bool resultado, string departamento, int edad)
    {
        Nombre = nombre;
        Resultado = resultado;
        Departamento = departamento;
        Edad = edad;
    }


}