/*
 * Problema "medidas"
    Fazer um programa para ler três medidas A, B e C. Em seguida, calcular e mostrar (imprimir os dados
    com quatro casas decimais):
    a) a área do quadrado que tem lado A
    b) a área do triângulo retângulo que base A e altura B
    c) a área do trapézio que tem bases A e B, e altura C
    Exemplo 1:
        Digite a medida A: 4.0
        Digite a medida B: 3.5
        Digite a medida C: 5.2
        AREA DO QUADRADO = 16.0000
        AREA DO TRIANGULO = 7.0000
        AREA DO TRAPEZIO = 19.5000
    Exemplo 2:
        Digite a medida A: 7.13
        Digite a medida B: 8.05
        Digite a medida C: 11.912
        AREA DO QUADRADO = 50.8369
        AREA DO TRIANGULO = 28.6983
        AREA DO TRAPEZIO = 90.4121
 */


using ProblemasMedidas;

Console.Write ("Digite a medida A: ");
double a = Convert.ToDouble (Console.ReadLine ());

Console.Write ("Digite a medida B: ");
double b = Convert.ToDouble (Console.ReadLine ());

Console.Write ("Digite a medida C: ");
double c = Convert.ToDouble (Console.ReadLine ());

Medidas medidas = new Medidas (a, b, c);

double areaQuadrado = medidas.CalcularAreaQuadrado ();
double areaTriangulo = medidas.CalcularAreaTriangulo ();
double areaTrapezio = medidas.CalcularAreaTrapezio ();

Console.WriteLine ($"AREA DO QUADRADO = {areaQuadrado:F4}");
Console.WriteLine ($"AREA DO TRIANGULO = {areaTriangulo:F4}");
Console.WriteLine ($"AREA DO TRAPEZIO = {areaTrapezio:F4}");