/*
 * Problema "consumo"
    Fazer um programa para ler a distância total (em km) percorrida por um carro, bem como o total de
    combustível gasto por este carro ao percorrer tal distância. Seu programa deve mostrar o consumo
    médio do carro, com três casas decimais.
    Exemplo 1:
        Distancia percorrida: 500
        Combustível gasto: 38.5
        Consumo medio = 12.987
    Exemplo 2:
        Distancia percorrida: 1108
        Combustível gasto: 71.4
        Consumo medio = 15.518
 */

using ProblemaConsumo;

Console.Write("Distancia percorrida: ");
double distancia = Convert.ToDouble(Console.ReadLine());
Console.Write ("Combustivel: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

Veiculo carro = new Veiculo(distancia, combustivel);

double consumoMedio = carro.CalcularConsumoMedio();

Console.WriteLine($"Consumo médio: {consumoMedio.ToString("F3")}");