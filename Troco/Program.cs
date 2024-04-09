/*
 * Problema "troco"
    Fazer um programa para calcular o troco no processo de pagamento de um produto de uma mercearia.
    O programa deve ler o preço unitário do produto, a quantidade de unidades compradas deste produto,
    e o valor em dinheiro dado pelo cliente (suponha que haja dinheiro suficiente). Seu programa deve
    mostrar o valor do troco a ser devolvido ao cliente.
    Exemplo 1:
        Preço unitário do produto: 8.00
        Quantidade comprada: 2
        Dinheiro recebido: 20.00
        TROCO = 4.00
    Exemplo 2:
        Preço unitário do produto: 30.00
        Quantidade comprada: 3
        Dinheiro recebido: 100.00
        TROCO = 10.00
 */

using Troco;

Console.Write("Preço unitário do produto: ");
double precoUnitario = Convert.ToDouble(Console.ReadLine());
Console.Write("Quantidade comprada: ");
int quantidade = Convert.ToInt32(Console.ReadLine());
Console.Write("Dinheiro recebido: ");
double dinheiroRecebido = Convert.ToDouble(Console.ReadLine());

Produto p1 = new Produto(precoUnitario, quantidade);

double troco = p1.CalcularTroco(dinheiroRecebido);

Console.WriteLine($"TROCO = {troco.ToString("C")}");
