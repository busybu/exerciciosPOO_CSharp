public class Time
{
    public string Nome { get; set; }
    public string Apelido { get; set; }
    public DateTime Fundacao = new DateTime();
    public List<Jogador> Plantel { get; set; }
    public List<Jogador> Relacionados { get; set; }
    public Time(string nome, string apelido, List<Jogador> plantel, DateTime datafundacao)
    {
        this.Nome = nome;
        this.Apelido = apelido;
        this.Plantel = plantel;
    }
    public Time(string nome, List<Jogador> plantel)
    {
        this.Nome = nome;
        this.Plantel = plantel;
    }
    public void relacionarJogadores()
    {
        this.Relacionados = Plantel;
        
        for (int i = 0; i < Relacionados.Count-1; i++)
        {   
            for (int j = 0; j < Relacionados.Count; j++)
            {   
                
                if (Relacionados[i].Qualidade < Relacionados[i+1].Qualidade)
                {
                    Jogador jogador = Relacionados[i];
                    Relacionados[i] = Relacionados[i+1];
                    Relacionados[i+1] = jogador;
                }
            }
            
        }   
    }
}
