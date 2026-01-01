using System;
using System.Globalization;

//pegando os dados
Console.Write("Qual a distância a ser percorrida (em km): ");
float km = float.Parse(Console.ReadLine());

//tratamento dos dados
if (km > 200)
{
    float valor = km * 0.40f;
    Console.Write($"O valor total da sua passagem ficara em {valor.ToString("C")}");
}
else
{
    float valor = km * 0.50f;
    Console.Write($"O valor total da sua passagem ficara em {valor.ToString("C")}");
}
