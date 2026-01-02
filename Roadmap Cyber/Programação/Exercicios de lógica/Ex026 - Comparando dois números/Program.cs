using System;

Console.Write("Insira o primeiro valor inteiro: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("Insira o segundo valor inteiro: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.Write($"O número {n1} é maior (Primeiro número)");
}
else if (n2 > n1)
{
    Console.Write($"O número {n2} é maior (Segundo número)");
}
else
{
    Console.Write($"Nenhum deles é maior, são iguais");
}
