// Definindo o array como bidimensional, com 5 valores em cada dimensão
float[,] notas = { { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

Console.WriteLine("Digite as notas dos alunos: ");

// i = grupos // j = notas
for (int i = 0; i < notas.GetLength(0); i++)
{
    // Esse loop controla a posição das notas
    Console.WriteLine($"Grupo: {i + 1}");
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        // esse loop controla a posição das notas
        Console.Write($"Aluno {j + 1}: ");
        notas[i, j] = float.Parse(Console.ReadLine());
    }
    Console.WriteLine("");
}

// Esse loop calcula a média de cada um dos elementos
for (int i = 0; i < notas.GetLength(0); i++)
{
    float soma = 0;
    float media = 0;
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        soma += notas[i, j];

    }
    media = soma / notas.GetLength(1);
    Console.WriteLine($"Média do grupo {i + 1}: {media}\n");

}
