using System;

Console.Write("Insira a primeira nota: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Insira a segunda nota: ");
int n2 = int.Parse(Console.ReadLine());

float media = (n1 + n2) / 2;

if (media <= 4.9f)
{
    Console.Write($"Média: {media.ToString("F1")}\nStatus: Reprovado");
}
else if (media > 5f && media <= 6.9f)
{
    Console.Write($"Média: {media.ToString("F1")}\nStatus: Recuperação");
}
else
{
    Console.Write($"Média: {media.ToString("F1")}\nStatus: Aprovado");
}
