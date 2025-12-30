using System;

//Pegando as informações
Console.Write("Insira a primeira nota: ");
float n1 = float.Parse(Console.ReadLine());
Console.Write("Insira a segunda nota: ");
float n2 = float.Parse(Console.ReadLine());

//tratamento dos dados e resultado
float media = (n1 + n2) / 2f;

if (media >= 7f)
{
    Console.WriteLine($"O aluno ficou acima da média, tendo a nota {media.ToString("F1")}");
}
else
{
    Console.WriteLine($"O aluno ficou a baixo da nota não atingindo a média 7 \nMédia do aluno {media.ToString("F1")}");
}
