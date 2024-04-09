/*
 * Problema "retangulo"
    Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor
    da área, perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplos.
        Exemplo 1:
    Base do retangulo: 4.0
    Altura do retangulo: 5.0
    AREA = 20.0000
    PERIMETRO = 18.0000
    DIAGONAL = 6.4031
        Exemplo 2:
    Base do retangulo: 10.3
    Altura do retangulo: 13.1
    AREA = 134.9300
    PERIMETRO = 46.8000
    DIAGONAL = 16.6643
 */

using System.Globalization;

double baseRetangulo, alturaRetangulo, areaRetangulo, perimetro, diagonal;

Console.Write("Base do retangulo: ");
baseRetangulo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Altura do retangulo: ");
alturaRetangulo = Convert.ToDouble (Console.ReadLine(), CultureInfo.InvariantCulture);

areaRetangulo = baseRetangulo * alturaRetangulo;
perimetro = 2 * (baseRetangulo + alturaRetangulo);
diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(alturaRetangulo, 2));

Console.WriteLine($"AREA = {areaRetangulo.ToString("F4")}");
Console.WriteLine($"PERIMETRO = {perimetro.ToString ("F4")}");
Console.WriteLine($"DIAGONAL = {diagonal.ToString ("F4")}");
