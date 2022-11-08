using System.Collections.Generic;

Retangulo retangulo;

Console.WriteLine("Insira o valor da base:");
int basew= int.Parse(Console.ReadLine());
Console.WriteLine("Insira o valor da altura:");
int altura = int.Parse(Console.ReadLine());
retangulo = new Retangulo(basew,altura);
retangulo.ExibirPropriedades();