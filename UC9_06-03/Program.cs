﻿string[,] alunos = new string[5, 7];
int linha, coluna;
double media, falta;

linha = 0;
coluna = 0;
media = 0;
falta = 0;

for (linha = 0; linha <= 4; linha++)
{
    Console.WriteLine("NOME do Aluno: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Aulas dadas: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("FALTAS do aluno: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 1: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 2: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Nota da PROVA 3: ");
    alunos[linha, coluna++] = Console.ReadLine();
    Console.WriteLine("Nota do TRABALHO: ");
    alunos[linha, coluna++] = Console.ReadLine();

    coluna = 0;
}

for (linha = 0; linha <=4; linha++)
{
    media = (double.Parse(alunos[linha, 3]) * 0.3) + (double.Parse(alunos[linha, 4]) * 0.25) + (double.Parse(alunos[linha, 5]) * 0.35) + (double.Parse(alunos[linha, 6]) + 1);
    falta = (double.Parse(alunos[linha,2]) * 100) / double.Parse(alunos[linha, 1]);
}