public class Genero
{
    public string CodigoXY { get; set; }
    public string Sexo { get; set; }
    public string F { get; set; }
    public int Cantidad { get; set; }

    public Genero(string codigoXY, string sexo, int cantidad)
    {
        CodigoXY = codigoXY;
        Sexo = sexo;
        Cantidad = cantidad;
    }
}