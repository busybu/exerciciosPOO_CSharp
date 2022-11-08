public class Livro
{
    private string Titulo;
    private int QtdPaginas;
    private int PaginasLidas;
    public string GetTitulo
    {
        get { return Titulo;}
        set { this.Titulo = value;}
    }
    
    public int GetPaginas
    {
        get { return QtdPaginas; }
        set { QtdPaginas = value; }
    }

    public int GetPaginasLidas
    {
        get { return PaginasLidas; }
        set { PaginasLidas = value; }
    }
    
    public Livro(){ }
    public Livro(string nome, int qtdpaginas)
    {
        this.Titulo = nome;
        this.QtdPaginas = qtdpaginas;
    }
    public void verificarProgresso()
    {
        int porcentagem = 0;
        porcentagem = (int) this.PaginasLidas * 100 / this.QtdPaginas;
        Console.WriteLine($"Você leu {porcentagem}% do livro {this.Titulo}.");
    }

    
}