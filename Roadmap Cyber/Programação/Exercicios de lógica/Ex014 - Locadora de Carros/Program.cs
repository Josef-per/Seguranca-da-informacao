using System;
using System.Globalization;

//Pegando as informações
Console.Write("Por quantos dias ficou com o carro: ");
float Dias = float.Parse(Console.ReadLine());
Console.Write("Quantos Km foram percorridos: ");
float Km = float.Parse(Console.ReadLine());

//tratando os dados
float Total = (Dias * 90f) + (Km * 0.20f);

//Mostrando o resultado
Console.WriteLine($"O total pelo aluguel do carro é {Total.ToString("C")}");
