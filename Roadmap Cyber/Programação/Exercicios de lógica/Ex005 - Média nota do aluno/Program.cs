using System;

//
//Pegando as informações

Console.Write("Primeira nota: ");
float n1 = float.Parse(Console.ReadLine());
Console.Write("Segunda Nota: ");
float n2 = float.Parse(Console.ReadLine());

//tratando os dados
float media = (n1 + n2) / 2;

//mostrando o resultado
Console.WriteLine($"A média desse aluno é de: {media.ToString("F1")}");
