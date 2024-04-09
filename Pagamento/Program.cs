/*
 * Problema "pagamento"
    Fazer um programa para ler o nome de um(a) funcionário(a), o valor que ele(a) recebe por hora, e a
    quantidade de horas trabalhadas por ele(a). Ao final, mostrar o valor do pagamento do funcionário com
    uma mensagem explicativa, conforme exemplo.
Exemplo 1:
    Nome: Joao Silva
    Valor por hora: 50.00
    Horas trabalhadas: 60
    O pagamento para Joao Silva deve ser 3000.00
Exemplo 2:
    Nome: Maria Dias
    Valor por hora: 60.00
    Horas trabalhadas: 100
    O pagamento para Maria Dias deve ser 6000.00
 */

using Pagamento;

Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Valor por hora: ");
double valorHora = double.Parse(Console.ReadLine());
Console.Write("Horas trabalhadas: ");
int horasTrabalhadas = int.Parse(Console.ReadLine());

Funcionario funcionario = new Funcionario (nome);

double pagamento = funcionario.CalcularPagamento (valorHora, horasTrabalhadas);

Console.WriteLine($"O pagamento para {funcionario.Nome} deve ser: {pagamento.ToString("C")}");