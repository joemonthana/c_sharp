using System;
public class Edad
{
    public string Codigo { get; set; }
    public string Etapa { get; set; }
    public string EdadComprendida { get; set; }
    public int Cantidad { get; set; }

    public Edad(string codigo, string etapa, string edadComprendida, int cantidad)
    {
        Codigo = codigo;
        Etapa = etapa;
        EdadComprendida = edadComprendida;
        Cantidad = cantidad;
    }
}