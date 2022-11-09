public class Livro
{
    private string titulo;
    private int qtdPaginas;
    private int paginasLidas;
    public string Titulo
    {
        get { return titulo;}
        set { this.titulo = value;}
    }
    
    public int Paginas
    {
        get { return qtdPaginas; }
        set { qtdPaginas = value; }
    }

    public int PaginasLidas
    {
        get { return paginasLidas; }
        set { paginasLidas = value; }
    }
    
    public Livro(){ }
    public Livro(string nome, int qtdpaginas)
    {
        this.Titulo = nome;
        this.Paginas = qtdpaginas;
    }
    public void verificarProgresso()
    {
        int porcentagem = 0;
        porcentagem = (int) this.PaginasLidas * 100 / this.Paginas;
        Console.WriteLine($"Você leu {porcentagem}% do livro {this.Titulo}.");
    }
   
}
public class TestarLivros
{
    public static void Main()
    {
        Livro livrofavorito = new Livro();
        livrofavorito.Titulo = "O Pequeno Príncipe";
        livrofavorito.Paginas = 98;
        Console.WriteLine($"O livro {livrofavorito.Titulo} possui {livrofavorito.Paginas} páginas.");
        livrofavorito.PaginasLidas = 20;
        livrofavorito.verificarProgresso();
        livrofavorito.PaginasLidas = 50;
        livrofavorito.verificarProgresso();
        
    }
}