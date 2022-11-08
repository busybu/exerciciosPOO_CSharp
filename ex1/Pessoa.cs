public class Pessoa
{
    public string Nome {get; set;}
    public int Idade {get; set;}
    public Pessoa()
    {
        this.Nome = "Sem informação";
        this.Idade = -1;
    }
    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {this.Nome} Idade: {this.Idade}");
    }
}