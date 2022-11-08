using System;

Jogador jogador;
List<Jogador> time = new List<Jogador>();

for(int i = 0; i < 2; i++)
{
    DateTime dataNascimento = new DateTime();
    Console.WriteLine("---------CADASTRO DE JOGADORES---------");
    Console.Write("Nome do jogador:");
    string nome = Console.ReadLine();
    Console.WriteLine("Data de nascimento:");
    Console.Write("Dia:");
    int dia = int.Parse(Console.ReadLine());
    Console.Write("Mês:");
    int mes = int.Parse(Console.ReadLine());
    Console.Write("Ano:");
    int ano = int.Parse(Console.ReadLine());
    dataNascimento = new DateTime(ano,mes,dia);
    Console.Write("ID do jogador:");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Apelido do jogador:");
    string apelido = Console.ReadLine();
    Console.Write("Número do jogador:");
    int numero = int.Parse(Console.ReadLine());
    Console.Write("Posição do jogador:");
    string posicao = Console.ReadLine();
    Console.Write("Qualidade do jogador:");
    int qualidade = int.Parse(Console.ReadLine());
    dataNascimento = dataNascimento.Date;
    jogador = new Jogador
    (
        id,
        nome,
        apelido,
        dataNascimento,
        numero,
        posicao,
        qualidade
    );
    time.Add(jogador);
    
}
string suspenso;
Console.WriteLine("---------JOGADORES CADASTRADOS---------");
for (int i = 0; i < 2; i++)
{
    if(time[i].Suspenso)
    {
        suspenso = "SUSPENSO";
    } 
    else suspenso = "TÁ PRA JOGO";
    {
        Console.WriteLine($"{time[i].Posicao}: {time[i].Numero} - {time[i].Nome} ({time[i].Apelido}) - {time[i].DataNascimento} CONDIÇÃO: {suspenso}");
    }
}



