public class Retangulo
{
    public int Basew { get; set;}
    public int Altura { get; set;}
    public int Area { get; set;}
    public Retangulo(int basew, int altura)
    {
        this.Basew = basew;
        this.Altura = altura;
        CalcularArea();
    }
    private void CalcularArea()
    {
        this.Area = Basew * Altura;
    } 
    public void ExibirPropriedades()
    {
        System.Console.WriteLine($"Altura: {Altura}, Base: {Basew}, Área: {Area}");
    }
}