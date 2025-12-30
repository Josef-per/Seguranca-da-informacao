using System;

//pegando as informações
Console.Write("Insira um número: ");
int n = int.Parse(Console.ReadLine());

//tratando as informações e mostrando o reusltado
if (n % 2 == 0)
{
    Console.Write($"O número {n} é par");
}
else
{
    Console.Write($"O número {n} é impar");
}
