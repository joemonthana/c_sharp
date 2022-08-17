public class Departamentos
{
    public string CodigoPostal { get; set; }
    public string Departamento { get; set; }
    public int Casos { get; set; }


    public Departamentos(string codigoPostal, string departamento, int casos)
    {
        CodigoPostal = codigoPostal;
        Departamento = departamento;
        Casos = casos;
    }
}