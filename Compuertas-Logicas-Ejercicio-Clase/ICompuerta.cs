namespace DefaultNamespace;

public interface ICompuerta
{
    public string Nombre { get; set }
    public List<int> Entradas { get; set; } = new List<int>();
    public int Salida { get; set };

    public void AgregarEntrada(int)
    {
        
    }

    public int Calcular()
    {
        
    }

}