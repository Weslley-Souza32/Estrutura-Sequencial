/*
 * Problema "terreno"
    Fazer um programa para ler as medidas da largura e comprimento de um terreno retangular com uma
    casa decimal, bem como o valor do metro quadrado do terreno com duas casas decimais. Em seguida,
    o programa deve mostrar o valor da área do terreno, bem como o valor do preço do terreno, ambos com
    duas casas decimais, conforme exemplo.
   Exemplo 1:
    Digite a largura do terreno: 10.0
    Digite o comprimento do terreno: 30.0
    Digite o valor do metro quadrado: 200.00
    Area do terreno = 300.00
    Preco do terreno = 60000.00
   Exemplo 2:
    Digite a largura do terreno: 12.0
    Digite o comprimento do terrano: 20.0
    Digite o valor do metro quadrado: 150.00
    Area do terreno = 240.00
    Preco do terreno = 36000.00
 */
using System.Globalization;

double larguraTerreno, comprimentoTerreno, valorMetroQuadrado, areaTerreno, precoTerreno;

Console.Write ("Digite a largura do terreno: ");
larguraTerreno = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write ("Digite o comprimento do terrano: ");
comprimentoTerreno = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write ("Digite o valor do metro quadrado: ");
valorMetroQuadrado = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

areaTerreno = larguraTerreno * comprimentoTerreno;
precoTerreno = areaTerreno * valorMetroQuadrado;

Console.WriteLine($"Area do terreno = {areaTerreno.ToString("F2")}");
Console.Write($"Preço do terreno = {precoTerreno.ToString("C")}");
