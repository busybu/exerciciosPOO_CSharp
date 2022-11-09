public class Despesas 
{
    private string cpf;
    public string CPF
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public List<DespesaMes> DespesasTotal { get; set; }
    public Despesas(string cpf, List<DespesaMes> despesas)
    {
        this.CPF = cpf;
        this.DespesasTotal = despesas;
    }
    public float Total(int mes) => this.DespesasTotal[mes-1].Total;

    
}

public class DespesaMes { 
    private int Mes { get; set;} // mes da despesa private float valor; // valor da despesa
    private float total = 0;
    public DespesaMes(int mes, float valor) 
    { 
        this.Mes = mes; 
        this.total = valor; 
    }
    public float Total
    {
        get{ return this.total; }
        set{ this.total += value; }
    }

}
public class DespesaDia
{
     private int Dia; // dia da despesa 
    public DespesaDia(int dia, DespesaMes mes, float valor)
    { 
        this.Dia = dia;
        mes.Total = valor;
    } 
    public int getDia() => this.Dia;
}