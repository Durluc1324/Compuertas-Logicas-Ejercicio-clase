namespace DefaultNamespace;

public class Not: ICompuerta
{
    public string Nombre { get; set }
    public List<int> Entradas { get; set; } = new List<int>();
    public int Salida { get; set };


    public void AgregarEntrada(int)
    {
        
    }

    public int Calcular()
    {
        
        foreach (int variable in Entradas)
        {
            if (int variable == 0)
            this.Salida = 0;
            else if (int variable == 1)
            this.Salida = 1;
        }

        return this.Salida;

    }
}