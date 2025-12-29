using System;
using System.Globalization;

//pegando as informações
Console.Write("Insira o valor do produto: ");
float Produto = float.Parse(Console.ReadLine());

//calculando o valor do desconto de 5%
float NewPreco = Produto * 0.95f; // Como o desconto é fixo, eu posso fazer dessa maneira, o que não aconteceiria se fosse pra poder adicoinar o valor do desconto

//Mostrando o resultado
Console.WriteLine($"Com um desconto de 5% seu produto está saindo por: {NewPreco.ToString("C")}");
