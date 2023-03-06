string[,] alunos = new string[5, 7];
int linha, coluna;
linha = 0;
coluna = 0;

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
}