using System;

// pegando as informações

Console.Write("Insira o valor de A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de B: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Insira o valor de C: ");
int c = int.Parse(Console.ReadLine());

// calculando o Delta
double delta = Math.Pow(b, 2) - 4 * a * c;

// Mostrando o Resultado
Console.WriteLine($"O resultado do delta dessa equação é: {delta}");
