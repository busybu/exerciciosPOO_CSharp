public class Pais
{
    private string iso { get; set;}
    private string nome { get; set;}
    private double populacao { get; set;}
    private double dimensao { get; set; }
    public List<Pais> PaisesFronteira { get; set;}

    public string Iso
    {
        get { return iso;}
        set {this.iso = value;}
    }
    public string Nome
    {
        get { return nome;}
        set {this.nome = value;}
    }
    public double Populacao
    {
        get { return populacao;}
        set {this.populacao = value;}
    }
    public double Dimensao
    {
        get { return dimensao;}
        set {this.dimensao = value;}
    }
    public Pais(string iso, string nome, double populacao, double dimensao)
    {
        this.Iso = iso;
        this.Nome = nome;
        this.Populacao = populacao;
        this.Dimensao = dimensao;
    }
    public override bool Equals(object obj) => SameCountry(obj as Pais);
    private bool SameCountry(Pais iso1) => iso1 == this.iso;

    public bool IsLimitrofe(Pais pais)
    {
        for (int i = 0; i < pais.PaisesFronteira.Count; i++)
        {
            if(pais.Nome == pais.PaisesFronteira[i].Nome)
                return true;
            return false;
        }
    }
    public double PopulationDensity() => this.Populacao / this.Dimensao;
    public List<Pais> HaveSameCountry(Pais pais)
    {
        for (int i = 0; i < pais.PaisesFronteira.Count; i++)
        {
            for (int j = 0; j < length; j++)
            {
                
            }
        }

    }
}