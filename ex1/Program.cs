Pessoa pessoa;
List<Pessoa> Pessoas = new List<Pessoa>();


for(int i = 0; i < 3 ; i++)
{
    Console.Write("Digite o nome da pessoa "+(i+1)+":");
    string ?nome = Console.ReadLine();
    Console.Write("Digite a idade da pessoa "+(i+1)+":");
    int idade = int.Parse(Console.ReadLine());
    pessoa = new Pessoa(nome,idade);
    Pessoas.Add(pessoa);
}
int maisVelhoIdade = -1000;
string maisVelhoNome = "";

foreach(var i in Pessoas)
{
    if(i.Idade > maisVelhoIdade)
    {
        maisVelhoIdade = i.Idade;
        maisVelhoNome = i.Nome;
    }
    i.ExibirDados();
}
Console.WriteLine($"A pessoa mais velha é {maisVelhoNome} e possui {maisVelhoIdade} anos.");