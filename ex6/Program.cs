Livro livros;

Console.WriteLine("Digite o nome do livro:");
livros = new Livro();
livros.GetTitulo = Console.ReadLine();
Console.WriteLine("Digite a quantidade de páginas do livro:");
livros.GetPaginas = int.Parse(Console.ReadLine());
Console.WriteLine("Digite quantas páginas você já leu:");
livros.GetPaginasLidas = int.Parse(Console.ReadLine());
livros.verificarProgresso();
