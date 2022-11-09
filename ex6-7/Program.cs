TestarLivros.Main();

Livro livros;

Console.WriteLine("Digite o nome do livro:");
livros = new Livro();
livros.Titulo = Console.ReadLine();
Console.WriteLine("Digite a quantidade de páginas do livro:");
livros.Paginas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantas páginas você já leu:");
livros.PaginasLidas = int.Parse(Console.ReadLine());
livros.verificarProgresso();
