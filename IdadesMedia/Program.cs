/*
 * Problema "idades"
    Fazer um programa para ler o nome e idade de duas pessoas. Ao final mostrar uma mensagem com os
    nomes e a idade média entre essas pessoas, com uma casa decimal, conforme exemplo.
    Exemplo:
        Dados da primeira pessoa:
        Nome: Maria Silva
    Idade: 19
        Dados da segunda pessoa:
        Nome: Joao Melo
    Idade 20
    A idade média de Maria Silva e Joao Melo é de 19.5 anos
 */

using IdadesMedia;

Console.WriteLine("Dados da pessoa 1");
Console.Write("Informe o nome da pessoa 1: ");
string nome = Console.ReadLine();
Console.Write("Informe a idade da pessoa 1: ");
int idade = Convert.ToInt32(Console.ReadLine());

Pessoa p1 = new Pessoa(nome, idade);

Console.WriteLine ("Dados da pessoa 2");
Console.Write ("Informe o nome da pessoa 2: ");
nome = Console.ReadLine ();
Console.Write ("Informe a idade da pessoa 2: ");
idade = Convert.ToInt32 (Console.ReadLine ());

Pessoa p2 = new Pessoa (nome, idade);

Console.WriteLine($"Nome: {p1.Nome} - Idade: {p1.Idade}" );
Console.WriteLine($"Nome: {p2.Nome} - Idade: {p2.Idade}");

double media = (p1.Idade + p2.Idade) / 2.0;

Console.WriteLine ($"A idade média de {p1.Nome} e {p2.Nome} é de: {media}");
