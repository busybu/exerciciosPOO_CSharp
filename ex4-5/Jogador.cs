public class Jogador
{
    public int ID {get; set;}
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public DateTime DataNascimento = new DateTime();
    public int Numero { get; set; }
    public string Posicao { get; set; }
    public int Qualidade { get {} set{ if(this.Qualidade > 100)} }
    public int Cartoes { get; set; }
    public bool Suspenso { get {return this.verificarCondicaoDeJogo(this.Cartoes);}  set{} }
    public Random aleatorio = new Random();
    public int qtTreinamento { get; set; }

    public Jogador(
        int id,
        string nome,
        string apelido,
        DateTime dataNascimento,
        int numero,
        string posicao,
        int qualidade,
        int cartoes = 0,
        bool suspenso = false,
        int qtTreinamento = 0

    )
    {
        this.ID = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.DataNascimento = dataNascimento;
        this.Numero = numero;
        this.Posicao = posicao;
        this.Qualidade = qualidade;
    }
    public Jogador(int id, string nome, string apelido, DateTime dataNascimento)
    {
        this.ID = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.DataNascimento = dataNascimento;
    }
    public bool verificarCondicaoDeJogo(int cartao)
    {
        if(cartao == 1)
        {
            Console.WriteLine("O cartão que o jogador possui é vermelho?");
            char resposta = Console.ReadKey(true).KeyChar;
            if(resposta == 's')
                return false;
            else
                return true;
        }
        else if(cartao == 3)
            return false;
        else
            return true;
    }
    public void aplicarCartao(int quantidade)
    {
        this.Cartoes = quantidade;
    }
    public void cumprirSuspencao()
    {
        this.Cartoes = 0;
    }
    public void sofrerLesao()
    {   
        int lesao = (int)aleatorio.NextInt64(0,100);
             if(lesao < 5)
                this.Qualidade = (int) this.Qualidade - ((this.Qualidade/ 100 * 15));
            else if(lesao < 10)
                this.Qualidade = (int) this.Qualidade - ((this.Qualidade/ 100 * 10));
            else if(lesao < 15)
                this.Qualidade = (int) this.Qualidade - ((this.Qualidade/ 100 * 5));
            else if(lesao < 30)
                this.Qualidade = (int) this.Qualidade - 2;
            else if(lesao < 40)
                this.Qualidade = (int) this.Qualidade - 1;
            if(this.Qualidade < 0)
                this.Qualidade = 0;
    }
    public void executarTreinamento(int qtTreinamento)
    {   
        if(qtTreinamento == 1)
        {
            Console.WriteLine("O jogador não pode efetuar mais que um treinamento por partida");
        }
        int treino = (int)aleatorio.NextInt64(0,100);
             if(treino < 5)
                this.Qualidade += 5;
            else if(treino < 10)
                this.Qualidade += 4;
            else if(treino < 15)
                this.Qualidade += 3;
            else if(treino < 30)
                this.Qualidade += 2;
            else if(treino < 40)
                this.Qualidade += 1;
            if(this.Qualidade > 100)
                this.Qualidade = 100;
    }
}
