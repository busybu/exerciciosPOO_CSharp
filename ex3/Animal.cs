public abstract class Animal
{
    private string nome;
    private string tipo;
    public int GetNome
    { 
        get { return nome; }
        set { nome = value; }
    }
    
    public int GetTipo
    {
        get { return tipo; }
        set { tipo = value; }
    }
    
}
public class Cachorro : Animal
{
    public Cachorro(string nome)
    {
        base.GetTipo = "cachorro";
        base.GetNome = nome;
    }
}
public class Gato : Animal
{
    public Gato(string nome)
    {
        base.GetTipo = "gato";
        base.GetNome = nome;
    }
}
public class Peixe : Animal
{
    public Peixe(string nome)
    {
        base.GetTipo = "peixe";
        base.GetNome = nome;
    }
}