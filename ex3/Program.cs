Animal animal;

List<Animal> listAnimais = new List<Animal>();
int gato = 0;
int cachorro = 0;
int peixe = 0;

for(int i = 0 ; i < 5 ; i++)
{

    Console.WriteLine("Digite o nome do animal:");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o tipo do animal:");
    string tipo = Console.ReadLine();
    tipo = tipo.ToLower();
    if (tipo == "cachorro") 
    {
        Cachorro animal = new Cachorro(nome);
        listAnimais.Add(animal);
        cachorro++;
    }
    else if (tipo == "gato")
    {
        Gato animal = new Gato(nome);
        listAnimais.Add(animal);
        gato++;
    }
    else
    {
        Peixe animal = new Peixe(nome);
        listAnimais.Add(animal);
        peixe++;
    }
}