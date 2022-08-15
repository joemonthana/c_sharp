public class Departamentos
{
    public string Departamento { get; set; }
    public int CasosPositivos { get; set; }


    public Departamentos(string departamento, int casosPositivos)
    {
        Departamento = departamento;
        CasosPositivos = casosPositivos;
    }
    
}