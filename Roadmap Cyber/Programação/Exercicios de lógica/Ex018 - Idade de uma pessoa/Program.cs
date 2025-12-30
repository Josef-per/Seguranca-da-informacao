using System;

//Pegando as informações
Console.Write("Qual é o ano de seu nascimento: ");
int ano = int.Parse(Console.ReadLine());

//tratamento dos dados e exebição de resultado.
int idade = 2025 - ano;
if (idade >= 18)
{
    Console.Write("Você já pode votar !");
}
else
{
    Console.Write("Você ainda não pode votar");
}
