/*
 * Problema "duracao"
    Fazer um programa para ler uma duração de tempo em segundos, daí imprimir na tela esta duração no
    formato horas:minutos:segundos.
    Exemplo 1:
        Digite a duracao em segundos: 300
        0:5:0
    Exemplo 2:
        Digite a duracao em segundos: 12506
        3:28:26
    Exemplo 3:
        Digite a duracao em segundos: 140811
        39:6:51
 */

using ProblemaDuracao;

Console.Write ("Digite a duração em segundos: ");
int duracaoSegundos = Convert.ToInt32 (Console.ReadLine ());

Duracao duracao = new Duracao (duracaoSegundos);
duracao.ImprimirDuracaoFormatada ();