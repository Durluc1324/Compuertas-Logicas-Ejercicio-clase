namespace DefaultNamespace;

public class And: ICompuerta
{
    public string Nombre { get; set; }
    public List<int> Entradas { get; set; } = new List<int>();
    public int Salida { get; set };

    public And(string unNombre)
    {
        this.Nombre = unNombre;
        this.Salida = null;
    }

    public void AgregarEntrada(int variable)
    {
        this.Entradas.Add(variable)
    }

    public int Calcular()
    {
        this.Salida = 1;
        foreach (int variable in Entradas)
        {
            this.Salida *= variable;
        }

        return Salida;
    }
}