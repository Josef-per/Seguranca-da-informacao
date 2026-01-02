using System;

Console.Write("Insira a largura do terreno: ");
int la = int.Parse(Console.ReadLine());
Console.Write("Insira a altura do terreno: ");
int al = int.Parse(Console.ReadLine());

int a = (la * al);

if (a <= 100)
{
    Console.Write($"{a}m² Terreno popular");
}
else if (a < 500 && a > 100)
{
    Console.Write($"{a}m² Terreno master");
}
else
{
    Console.Write($"{a}m² Terreno vip");
}
